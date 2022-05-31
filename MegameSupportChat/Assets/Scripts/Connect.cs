using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using MegameAPI;

public class Connect : MonoBehaviour
{
    public InputField Username; //���� ����� ��������
    public InputField Token; //���� ����� ������
    private MegameHttpClient client = new MegameHttpClient(); //������ api

    public async void onClick()
    {
        try
        {
            //���� ���� �������� ��� �� ������ � �������� 16 ��������
            if (Username.text.ToString().Trim().Length != 0 && Username.text.Length <= 16) 
            {               
                //�������� ����� ���������� 
                string id = SystemInfo.deviceUniqueIdentifier;
                //������ ������ �� ����������� ������
                string response = await client.RegisterPlayerAsync(new Player
                {
                    Username = Username.text.ToString(),
                    Token = id
                });
                //�������� ������ � ������ ���� �� �����
                var button = GetComponent<Button>();
                GetComponent<Graphic>().color = Color.green;
                //�������� ����� ������ � ������ ��� ���� ������� � ����� ��� ����� � �������
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
        //����� ��� ���� � input
        Token.text = SystemInfo.deviceUniqueIdentifier;
    }
}
