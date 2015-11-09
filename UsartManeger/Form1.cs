using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace UsartManeger
{
    public partial class Form1 : Form
    {

        Sender send;
        string SendBuff;
        bool InputEmpty ;
        SerialPort com;
        int SendCount;
        int ReceiveCount;
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
        private void PortInit()
        {            
            com = new SerialPort(); 
            com.NewLine = "/r/n";
            com.RtsEnable = true;
            SendCount = 0;
            ReceiveCount = 0;
            com.DataReceived += com_DataReceived;
        }
        public Form1()
        {

            InitializeComponent();
            PortInit();
            InputEmpty = true;
            send = new Sender();
            send.DataBits = int.Parse(DataCom.Text);
            send.Baudrate = int.Parse(BauCom.Text);
            send.PortName = PortCom.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = com.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
            ReceiveCount += n;//增加接收计数  
            com.Read(buf, 0, n);//读取缓冲数据  
            builder.Clear();//清除字符串构造器的内容  
            //因为要访问ui资源，所以需要使用invoke方式同步ui。  
            this.Invoke((EventHandler)(delegate
            {
                //判断是否是显示为16禁止  
           //     if (checkBoxHexView.Checked)
            //    {
                    //依次的拼接出16进制字符串  
            //        foreach (byte b in buf)
            //        {
             //           builder.Append(b.ToString("X2") + " ");
             //       }
              //  }
             //   else
              //  {
                    //直接按ASCII规则转换成字符串  
                    builder.Append(Encoding.ASCII.GetString(buf));
            //    }
                //追加的形式添加到文本框末端，并滚动到最后。  
                    this.RecieveBox.AppendText(builder.ToString());
                //修改接收计数  
                label11.Text = ReceiveCount.ToString();
            }));
        }  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = StopCom.SelectedItem.ToString();
            switch (temp)
            {
                case "1":
                    send.Stopbits = StopBits.One;
                    break;
                case "2":
                    send.Stopbits = StopBits.Two;
                    break;
                default:
                    break;
            }
            label12.Text = StopCom.SelectedItem.ToString();
        }
        private void PortCom_DropDown(object sender, EventArgs e)
        {
            try
            {
                PortCom.Items.Clear();//讲combobox中的端口名丢弃
                string[] portnames = SerialPort.GetPortNames();//获取当前串行端口的名称数组
                for (int i = 0; i < portnames.Length; i++)
                    PortCom.Items.Add(portnames[i]);//讲端口名添加到combobox中的集合中
            }
            catch { }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                send.PortName = PortCom.SelectedItem.ToString();//端口变化时，串口名改变
            }
            catch {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] data;
                SendBuff = InputBox.Text;
                data = new ASCIIEncoding().GetBytes(SendBuff);
                com.Write(data, 0, data.Length);
                SendBox.Text = SendBox.Text + SendBuff + "\n";
                if (InputEmpty == true)
                    InputBox.Clear();
                SendCount += data.Length;
                label9.Text = SendCount.ToString();
            }
            catch
            {
                MessageBox.Show("       串口未打开。", "数据发送失败", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        public class Sender
        {
            private string sendbuff;
            private int databits;
            private int baudrate;
            private string portname;
            private Parity check;
            private StopBits stopbits;
            public StopBits Stopbits
            {
                get
                {
                    return stopbits;
                }
                set
                {
                    stopbits = value;
                }
            }
            public Parity Check
            {
                get
                {
                    return check;
                }
                set
                {
                    check = value;
                }
            }
            public string Sendbuff
            {
                get
                {
                    return sendbuff;
                }
                set
                {
                    sendbuff = value;
                }
            }
            public int DataBits
            {
                get
                {
                    return databits;
                }
                set
                {
                    databits = value;
                }
            }
            public string PortName
            {
                get
                {
                    return portname;
                }
                set
                {
                    portname = value;
                }
            }
            public int Baudrate
            {
                get
                {
                    return baudrate;
                }
                set
                {
                    baudrate = value;
                }
            }

        }

        private void BauCom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                send.Baudrate = int.Parse (BauCom.SelectedItem.ToString());//端口变化时，串口名改变
            }
            catch { }
        }

        private void CheckCom_TextChanged(object sender, EventArgs e)
        {
        }

        private void DataCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataCom_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                send.DataBits = int.Parse(DataCom.SelectedItem.ToString());//端口变化时，串口名改变
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                com.BaudRate = send.Baudrate;
                com.PortName = send.PortName;
                com.DataBits = send.DataBits;
                com.Parity = send.Check;
                com.StopBits = send.Stopbits;
                com.Open();
                label6.Text = com.BaudRate.ToString();
                label5.Text = send.PortName;
                label7.Text = com.DataBits.ToString();
                button1.Visible = false;
                button3.Visible = true;
                label2.Text ="已打开";

            }
            catch
            {
                MessageBox.Show("       请查看串口配置是否正确，\n       或串口是否被占用。", "串口打开失败", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void SendClean_Click(object sender, EventArgs e)
        {
            SendBox.Clear();
        }

        private void RecieveClean_Click(object sender, EventArgs e)
        {
            RecieveBox.Clear();
        }

        private void SendBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (EnterBox.Checked == true)
                InputBox.KeyDown += InputBox_KeyDown;
            else if (EnterBox.Checked == false)
                InputBox.KeyDown -= InputBox_KeyDown;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Enter )
                button2_Click(this, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if (EmptyBox.Checked == true)
                InputEmpty = true;
            else if (EmptyBox.Checked == false)
                InputEmpty = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                com.Close();
                button1.Visible = true;
                button3.Visible = false;
                label6.ResetText();
                label5.ResetText();
                label7.ResetText();
                label2.Text = "未打开";
            }
            catch
            {

                MessageBox.Show("       请查看串口是否正在使用", "串口关闭失败", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                
            }
        }

        private void CheckCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CheckCom.SelectedItem.ToString())
            {
                case "None": break;
                case "Odd" :
                    send.Check = Parity.Odd;
                    break;
                case "Even":
                    send.Check = Parity.Even;
                    break;
                case "Mark":
                    send.Check = Parity.Mark;
                    break;
                case "Space":
                    send.Check = Parity.Space;
                    break;
                default:
                    break;
            }
        }
    }
}
