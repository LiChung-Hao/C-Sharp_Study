using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using TMPro;
using UnityEditor;
using UnityEngine;

public class ChatManager : MonoBehaviour //-p55
{
    public string ipAdress = "192.168.1.78";
    public int portNum = 9541;
    public TMP_InputField textInput;
    public TextMeshProUGUI chatBox;

    private Thread t;
    private Socket clientSocket;
    private byte[] data = new byte[1024];
    private string message=null;
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }

    // Update is called once per frame
    void Update()
    {
        if (message != null && message != "")
        {
            chatBox.text += "\n" + message;
            message = "";
        }
    }
    private void ConnectToServer()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipAdress), portNum));

        //create a new thread to receive message
        t = new Thread(ReceiveMessage);
        t.Start();
    }

    public void ReceiveMessage()
    {
        while (true)
        {
            if (clientSocket.Connected == false)
            {
                break;
            }
            int length = clientSocket.Receive(data);
            message = Encoding.UTF8.GetString(data, 0, length);
        }
    }

    void Send(string message)
    {
        byte[] messageByte = Encoding.UTF8.GetBytes(message);
        clientSocket.Send(messageByte);
    }

    public void OnSendButtonClick()
    {
        string value = textInput.text;
        Send(value);
        textInput.text = "";
    }

    private void OnDestroy() //-p56
    {
        clientSocket.Close();
    }
}
