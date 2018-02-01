using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace 创建和客户端通信的Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadyListen_Click(object sender, EventArgs e)
        {
            //当点击开始监听的时候 在服务器端创建一个负责监听的IP地址和端口号的Socket
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建端口号
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            socketWatch.Bind(point);
            ShowMsg("监听成功");
            socketWatch.Listen(10);
            //等待客户端的连接 并且创建一个负责通信的Socket
            Socket socketSend = socketWatch.Accept();
            //通过属性远程拿到客户端发送过来的端口号和ip地址
            ShowMsg(socketSend.RemoteEndPoint.ToString()+":"+"连接成功");
        }

        private void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }
    }
}
