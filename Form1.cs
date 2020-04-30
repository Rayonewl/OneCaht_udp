using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MetroFramework;

namespace OneChat
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private delegate void InvokeDelegate();
        public MainForm()
        {
            InitializeComponent();
        }
        //全局变量
        Thread t = null;        //接收进程、接收显示进程
        string RecvData = null;    //接收的数据
        static Socket UdpClient = null;

        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        public string GetLocalIp()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }
        /// <summary>
        /// 接收发送给本机ip对应端口号的数据报
        /// </summary>
        void ReciveMsg()
        {
            while (true)
            {
                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);    //用来保存发送方的ip和端口号
                    byte[] buffer = new byte[1024];
                    int length = UdpClient.ReceiveFrom(buffer, ref point);//接收数据报
                    //led = Encoding.Default.GetString(buffer, 0, length);
                    //led_ctrl();
                    RecvData += "【from " + point + "】:" + Encoding.Default.GetString(buffer, 0, length);//Encoding.UTF8.GetString方法不能支持中文
                    RecvData += "\r\n";//接收完换行   
                   this.Invoke(new InvokeDelegate(DisplayReciveMsg));//方法2:

            }
        }
        /// <summary>
        /// 显示数据，并滑到最底
        /// </summary>
        public void DisplayReciveMsg()
        {
            this.rtB_RecvMsg.Text = RecvData;
            //让富文本框自动滑到最底行
            //让文本框获取焦点 
            this.rtB_RecvMsg.Focus();
            //设置光标的位置到文本尾 
            this.rtB_RecvMsg.Select(this.rtB_RecvMsg.TextLength-1, 0);
            //滚动到控件光标处 
            this.rtB_RecvMsg.ScrollToCaret();
        }

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            /* 实列化Socket套接字对象
             * 参数: 
             *       AddressFamily(地址族) :InterNetwork ——> IP 版本 4 的地址
             *       SocketType(套接字类型):Dgram        ——> 数据报       
             *       ProtocolType(支持类型):UDP          ——> UDP协议  
             * 
             */
            Socket sSndMag = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //获取UI中对方的IP地址
            IPAddress ipaddrRemote = IPAddress.Parse(this.tB_RemoteIp.Text);
            //IPEndPoint——>指定地址和端口号
            EndPoint edpRemote = new IPEndPoint(ipaddrRemote, Convert.ToInt16(this.tB_RemotePort.Text));
            //发送，发送前需要把发送的内容转成字节类型的
            sSndMag.SendTo(System.Text.Encoding.Default.GetBytes(this.rtB_SendMsg.Text), edpRemote);
            //关闭套接字
            sSndMag.Close();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //方法1:
            //CheckForIllegalCrossThreadCalls = false;
            this.tB_LocalIp.Text = GetLocalIp();
            this.tB_RemoteIp.Text = this.tB_LocalIp.Text;
            UdpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint localIPEndPoint = new IPEndPoint(IPAddress.Parse(this.tB_LocalIp.Text), Convert.ToInt16(this.tB_LocalPort.Text));
            UdpClient.Bind(localIPEndPoint);
            //开启线程
            t = new Thread(ReciveMsg);
            t.Start();
        }

        private void btn_ClrSendMsg_Click(object sender, EventArgs e)
        {
            rtB_SendMsg.Text = "";
        }

        private void btn_ClrRecvMsg_Click(object sender, EventArgs e)
        {
            RecvData = "";
            rtB_RecvMsg.Text = "";
        }
    }
}
