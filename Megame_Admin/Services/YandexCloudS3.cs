using System.IO;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;

namespace Megame_Admin.Services
{
    public interface IYandexCloudS3
    {
         Task PutObjectAsync(Stream stream,string key);
         Task CreateFolder(string folderName);
    }

    public class YandexCloudS3:IYandexCloudS3
    {
        private readonly AmazonS3Client client;
        //настройки доступа к s3-хранилищу
        private readonly AWSCredentials creds;
        private readonly string BucketName;
        //конфигурация хранилища (подключаемся к яндексу)
        readonly AmazonS3Config configsS3 = new AmazonS3Config()
        {
            ServiceURL = "http://s3.yandexcloud.net",
            UseHttp = true,
            SignatureVersion = "v4"
        };

        //настройки из конфигураций
        public IConfiguration Configuration { get; }

        //иницилизация клиента (ключи из секретов)
        public YandexCloudS3(IConfiguration configuration)
        {
            Configuration = configuration;
            creds = new BasicAWSCredentials(Configuration["accessKey"], Configuration["secretKey"]);
            client = new AmazonS3Client(creds, configsS3);
            BucketName = Configuration["BucketName"];
        }

        //загрузка файла в хранилище
        public async Task PutObjectAsync(Stream stream, string key)
        {            
            try
            {
                await client.PutObjectAsync(new PutObjectRequest()
                {
                    BucketName = BucketName,
                    InputStream = stream,
                    Key = key
                });
            }
            catch
            {

            }
        }

        //создание папки в хранилище
        public async Task CreateFolder(string folderName)
        {
            var folderKey = folderName + "/";
            var request = new PutObjectRequest();
            request.BucketName = BucketName;
            request.StorageClass = S3StorageClass.Standard;
            request.ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
            request.Key = folderKey;
            request.ContentBody = string.Empty;
            await client.PutObjectAsync(request);
        }
    }
}
