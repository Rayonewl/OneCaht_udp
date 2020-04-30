
# OneChat
一款基于Tcp&Udp协议的聊天软件 —— by C#Winform

### Information：
最近在学计算机网络，学到了TCP协议和UDP协议，这里具体就不说这两个协议了，主要讲讲如何通过C#Winform来写一个聊天程序，用实践来加深理论。由于学习时间的安排，我分阶段实现这个程序的功能。

### MyTask：
- OneChat task
  - Simple UI
    - Winform窗体搭建
  - 实现UDP通信
    - UDP Send data
    - UDP Receive data
  - 实现TCP通信
    - Tcp Client
    - Tcp Sever
  - UI美化
    - 用第三方控件美化
  - 拓展
    - 实现图片的发送
    - 用数据库实现用户注册和登录 

### Let's Start The Project On VS2019 
——————————————————————————————————————————————————
##### 1. 创建OneChat工程
##### 2. 设计WinForm窗体，添加所需控件
##### 3. 更改控件属性
##### 4. 实现UDP发送
- 引用所需要的类
    ```javascript
    using System.Net.Sockets;
    using System.Net;
    using System.Threading; //用于进行多线程编程，接收消息需要用到
    ```
  - 创建一个Socket对象
    ```javascript
    /* 实列化Socket套接字对象
    * 实列化参数: 
    *       AddressFamily(地址族) :InterNetwork ——> IP 版本 4 的地址
    *       SocketType(套接字类型):Dgram        ——> UDP对应数据报，而TCP对应的是Stream       
    *       ProtocolType(支持类型):UDP          ——> UDP协议  
    * 
    */
    Socket sSndMag = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
    ```
- 指定发送地址和端口号
  ```javascript
  //获取UI中对方的IP地址
  IPAddress ipaddrRemote = IPAddress.Parse(this.tB_RemoteIp.Text);
  //创建IPEndPoint并实列化——>指定地址和端口号
  EndPoint edpRemote = new IPEndPoint(ipaddrRemote, Convert.ToInt16(this.tB_RemotePort.Text));
  ```
- UDP发送数据
  ```javascript
  //UDP发送数据，发送前需要把发送的内容转成字节类型的
  sSndMag.SendTo(System.Text.Encoding.Default.GetBytes(this.rtB_SendMsg.Text), edpRemote);
  ```
- 关闭套接字
  ```javascript
  //关闭套接字
  sSndMag.Close();
  ```
##### 5. 实现UDP接收
  - 全局变量
    ```javascript
    Thread t;
    string RecvData;
    static Socket UdpClient;
    //string led;
    ```
  - 接收函数
    - 创建并是实列化IPEndPoint
    - 指定IP Address为Any和Port = 0
    - Create a Buffer用于接收数据
    - 用ReceiveFrom方法接收
    - 显示地址、端口和数据(Bytes -> String)
      ```javascript
      void ReciveMsg()
          {
              while (true)
              {
                  EndPoint point = new IPEndPoint(IPAddress.Any, 0);//用来保存发送方的ip和端口号
                  byte[] buffer = new byte[1024];
                  int length = UdpClient.ReceiveFrom(buffer, ref point);//接收数据报
                  //led = Encoding.Default.GetString(buffer, 0, length);
                  RecvData += "【from "+ point+"】:" + Encoding.Default.GetString(buffer, 0, length);//Encoding.UTF8.GetString方法不能支持中文
                  RecvData += "\r\n";//接收完换行
                  /*********************************************************************/
                  //非主线程访问，会报错 CheckForIllegalCrossThreadCalls =false 去掉检查
                  //led_ctrl();//这里我用来调试Esp8266开发板的LED的，可屏蔽
                  this.rtB_RecvMsg.Text = RecvData;
                  /*********************************************************************/
              }
          }
        ```
  - 创建线程
    - 在MainForm_Load中创建一个Client套接字对象并是实列化
    - 在MainForm_Load中创建线程，在线程中调用接收函数,然后打开线程
      ```javascript
      private void MainForm_Load(object sender, EventArgs e)
      {
          CheckForIllegalCrossThreadCalls = false;//屏蔽掉线程报错，这里不是最好的办法，我代码里面用的另外一种方法
          this.tB_LocalIp.Text = GetLocalIp();     //获取本机地址
          this.tB_RemoteIp.Text = this.tB_LocalIp.Text;  //方便调试，可屏蔽
          UdpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
          IPEndPoint localIPEndPoint = new IPEndPoint(IPAddress.Parse(this.tB_LocalIp.Text),Convert.ToInt16(this.tB_LocalPort.Text));
          UdpClient.Bind(localIPEndPoint);
          //开启线程
          t = new Thread(ReciveMsg);
          t.Start();
      }
      ```

  - Note：
    - 接收函数非主线程，而textBox是在主进程中创建的，所以接收函数不能调用主线程创建的控件，否则会报错，我用了一个最简单但不是最好的方法
      ```javascript
      //去掉检查
      CheckForIllegalCrossThreadCalls =false
      ```
##### 6. 实现清除文本框数据功能
  - 清除发送数据文本框内容
    ```javascript
    private void btn_ClrSendMsg_Click(object sender, EventArgs e)
    {
        rtB_SendMsg.Text = "";
    }    
    ```
   - 清除接收数据文本框内容
      ```javascript
      private void btn_ClrRecvMsg_Click(object sender, EventArgs e)
      {
          RecvData = "";
          this.rtB_RecvMsg.Text = "";
      }
      ```
## UDP的部分已近实现，TCP未完待续。。。。