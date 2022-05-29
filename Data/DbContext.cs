using Megame_Admin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Megame_Admin
{
    public class DbContext : IdentityDbContext<UserIdentity>
    {
        //таблицы для пользователей
        public DbSet<UserIdentity> AppUsers { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbContext() { }

        //настройки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=MegameAdmin;Trusted_Connection=true"); //получаем из конфигов
        }

        //настройки моделей
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //вызов из баз. IdentityDbContext(там хрянятся данные для БД  Identity контекста)
            base.OnModelCreating(builder);
            //подключение настроек из других классов
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new BaseUserConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());

            builder.Entity<Skill>().Property(x => x.Name).HasMaxLength(50).HasDefaultValue("");
            builder.Entity<Skill>().Property(x => x.Percent).HasMaxLength(100).HasDefaultValue(0);
            builder.Entity<WorkPlatform>().Property(x => x.PlatformTitle).HasMaxLength(100).HasDefaultValue("");
            builder.Entity<WorkPlatform>().Property(x => x.Description).HasMaxLength(400).HasDefaultValue("");

            builder //многие к многим между юзером и чатами
                .Entity<Chat>()
                .HasMany(x => x.Users)
                .WithMany(x => x.Chats);

            builder.Entity<Chat>() //связь между сообщениями и чатом
                .HasMany(x => x.Messages)
                .WithOne(x => x.Chat)
                .HasForeignKey(x => x.ChatId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        //настройки модели UserIdentity в отдельном классе
        public class UserConfiguration : IEntityTypeConfiguration<UserIdentity>
        {
            //реализация интерфейса методом-настройщиком
            public void Configure(EntityTypeBuilder<UserIdentity> builder)
            {
                builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
                builder.Property(x => x.PhoneNumber).HasMaxLength(30).HasDefaultValue("+7");
                builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
                builder.Property(x => x.RegistrationDate).IsRequired().HasDefaultValue(System.DateTime.UtcNow);

                builder //связь 1 к 1 между юзером и его профилем,
                    .HasOne(x => x.BaseUser)
                    .WithOne(y => y.UserIdentity)
                    .HasForeignKey<BaseUser>(x => x.UserIdentityKey)
                    .OnDelete(DeleteBehavior.Cascade);

                builder //связь 1 к многим между юзером и его скилами
                    .HasMany(x => x.Skills)
                    .WithOne(x => x.UserIdentity)
                    .HasForeignKey(x => x.UserIdentityKey)
                    .OnDelete(DeleteBehavior.Cascade);

                builder //связь 1 к многим между юзером и его раб.проектами
                    .HasMany(x => x.WorkPlatforms)
                    .WithOne(x => x.UserIdentity)
                    .HasForeignKey(x => x.UserIdentityKey)
                    .OnDelete(DeleteBehavior.Cascade);

                builder //связь 1 к многим между юзером и его друзьями
                    .HasMany(x => x.Friends)
                    .WithOne(x => x.UserIdentity)
                    .HasForeignKey(x => x.UserIdentityId)
                    .OnDelete(DeleteBehavior.Cascade);

                builder //связь 1 к многим между юзером и его сообщениями
                    .HasMany(x => x.Messages)
                    .WithOne(x => x.UserIdentity)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }

        //настройки модели UserIdentity в отдельном классе
        public class PlayerConfiguration : IEntityTypeConfiguration<Player>
        {
            //реализация интерфейса методом-настройщиком
            public void Configure(EntityTypeBuilder<Player> builder)
            {
                builder.Property(x => x.Username).IsRequired().HasMaxLength(16).HasDefaultValue("");
                builder.Property(x => x.Token).IsRequired().HasDefaultValue("");
            }
        }

        public class BaseUserConfiguration : IEntityTypeConfiguration<BaseUser>
        {
            //реализация интерфейса методом-настройщиком
            public void Configure(EntityTypeBuilder<BaseUser> builder)
            {
                builder.Property(x => x.Photo).HasDefaultValue("");
                builder.Property(x => x.Profession).HasMaxLength(150).HasDefaultValue("");
                builder.Property(x => x.FullName).HasMaxLength(150).HasDefaultValue("");
                builder.Property(x => x.Adress).HasMaxLength(50).HasDefaultValue("Moscow");
                builder.Property(x => x.Country).HasMaxLength(30).HasDefaultValue("Russia");
                builder.Property(x => x.Bio).HasMaxLength(300).HasDefaultValue("");
                builder.Property(x => x.Website).HasDefaultValue("https://");
                builder.Property(x => x.Linkedin).HasDefaultValue("https://");
                builder.Property(x => x.Facebook).HasDefaultValue("https://");
                builder.Property(x => x.Twitter).HasDefaultValue("https://");
                builder.Property(x => x.Github).HasDefaultValue("https://");
                builder.Property(x => x.Birthday).HasDefaultValue(System.DateTime.UtcNow);
                builder.Property(x => x.Location).HasMaxLength(50).HasDefaultValue("");
            }
        }
    }
}