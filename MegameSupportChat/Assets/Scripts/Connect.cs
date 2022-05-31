using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using MegameAPI;

public class Connect : MonoBehaviour
{
    public InputField Username; //поле ввода никнейма
    public InputField Token; //поле ввода токена
    private MegameHttpClient client = new MegameHttpClient(); //клиент api

    public async void onClick()
    {
        try
        {
            //если ввод никнейма был не пустой и максимум 16 символов
            if (Username.text.ToString().Trim().Length != 0 && Username.text.Length <= 16) 
            {               
                //получаем токен устройства 
                string id = SystemInfo.deviceUniqueIdentifier;
                //делаем запрос на регистрацию игрока
                string response = await client.RegisterPlayerAsync(new Player
                {
                    Username = Username.text.ToString(),
                    Token = id
                });
                //получаем кнопку и меняем цвет на синий
                var button = GetComponent<Button>();
                GetComponent<Graphic>().color = Color.green;
                //получаем текст кнопки и ставим его цвет красным и пишем ему ответ с сервера
                var Buttontext = button.GetComponentInChildren<Text>();
                Buttontext.text = response;
                Buttontext.enabled = false;
                Username.interactable = false;
            }
            else Debug.Log("Nickname cannot be empty and max 16 characters");
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    public void Start()
    {
        //пишем наш айди в input
        Token.text = SystemInfo.deviceUniqueIdentifier;
    }
}
