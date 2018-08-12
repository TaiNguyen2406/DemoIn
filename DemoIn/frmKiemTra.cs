using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace DemoIn
{
    public partial class frmKiemTra : Form
    {
        private const Byte STX = 0x02;
        private const Byte ETX = 0x03;
        private const Byte CR = 0x0d;

        private const int SERIAL_PORT_COUNT = 2;    // Number of COM ports used
        private const int RECV_DATA_MAX = 10240;
        private const bool binaryDataMode = false;  // Whether using binary data mode
        private SerialPort[] serialPortInstance;    // Array to store instances of COM ports used
        string duongDan = ".\\txtFile\\1.txt";
        public frmKiemTra()
        {
            InitializeComponent();
        }
        private string[] DocFile()
        {
            string text = File.ReadAllLines(duongDan).Last();
            string[] str = text.Split(',');
            txtDocFile.Text = str[3];
            return str;
        }
        private string KiemTra(string codeTuMayFile, string codeTuMayScan)
        {
            if ("\n"+ codeTuMayFile+"\r"  == codeTuMayScan)
            {
                if (DocFile()[4] == "")
                {

                    string text = File.ReadAllLines(duongDan).Last();
                    File.WriteAllText(duongDan, String.Empty);
                    string str = text + "OK";
                    File.WriteAllText(duongDan, str);

                }

                return "OK";
            }
            else
            {
                if (DocFile()[4] == "")
                {

                    string text = File.ReadAllLines(duongDan).Last();
                    File.WriteAllText(duongDan, String.Empty);
                    string str = text + "NG";
                    File.WriteAllText(duongDan, str);

                }
                // File.AppendAllText(duongDan, "NG");
                return "NG";
            }

        }
        private bool checkDataSize(Byte[] recvBytes, int recvSize)
        {
            const int dataSizeLen = 4;

            if (binaryDataMode == false)
            {
                return true;
            }

            if (recvSize < dataSizeLen)
            {
                return false;
            }

            int dataSize = 0;
            int mul = 1;
            for (int i = 0; i < dataSizeLen; i++)
            {
                dataSize += (recvBytes[dataSizeLen - 1 - i] - '0') * mul;
                mul *= 10;
            }

            return (dataSize + 1 == recvSize);
        }
        private int readDataSub(Byte[] recvBytes, SerialPort serialPortInstance)
        {
            int recvSize = 0;
            bool isCommandRes = false;
            Byte d;

            //
            // Distinguish between command response and read data.
            //
            try
            {
                d = (Byte)serialPortInstance.ReadByte();
                recvBytes[recvSize++] = d;
                if (d == STX)
                {
                    isCommandRes = true;    // Distinguish between command response and read data.
                }
            }
            catch (TimeoutException)
            {
                return 0;   //  No data received.
            }

            //
            // Receive data until the terminator character.
            //
            for (; ; )
            {
                try
                {
                    d = (Byte)serialPortInstance.ReadByte();
                    recvBytes[recvSize++] = d;

                    if (isCommandRes && (d == ETX))
                    {
                        break;  // Command response is received completely.
                    }
                    else if (d == CR)
                    {
                        if (checkDataSize(recvBytes, recvSize))
                        {
                            break;  // Read data is received completely.
                        }
                    }
                }
                catch (TimeoutException ex)
                {
                    //
                    // No terminator is received.
                    //
                  //  MessageBox.Show(ex.Message);
                    return 0;
                }
            }

            return recvSize;
        }
        private void ConnectCOM()
        {
         
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.StartupPath + @"\Config.xml");
            XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("ComPort");
            string[] comList = SerialPort.GetPortNames();
            foreach (string com in comList)
            {
                if (node.Attributes["Name"].Value.ToString()==com)
                {
                    serialPort1.PortName = node.Attributes["Name"].Value.ToString();
                    serialPort1.BaudRate = Convert.ToInt32(node.Attributes["BaudRate"].Value);
                    serialPort1.Parity = Parity.Even;
                    serialPort1.DataBits = Convert.ToInt32(node.Attributes["DataBits"].Value);
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.ReceivedBytesThreshold = Convert.ToInt32(node.Attributes["ReceivedBytesThreshold"].Value);
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }

                    //
                    // Open the COM port.
                    //
                    serialPort1.Open();
                    lblPort.Text = "Giá trị đọc từ cổng " + serialPort1.PortName.ToString();
                }
                else
                {
                    lblPort.Text = "Không có cổng " + node.Attributes["Name"].Value.ToString();
                }
            }
          

        }

        private string DocCom()
        {
            Byte[] recvBytes = new Byte[RECV_DATA_MAX];
            int recvSize;

            if (serialPort1.IsOpen)
            {
                for (; ; )
                {
                    try
                    {
                        recvSize = readDataSub(recvBytes, serialPort1);
                    }
                    catch (IOException ex)
                    {
                        lblStatus.Text = ex.Message.ToString();
                        return "NO DATA";
                       
                    }

                    if (recvSize == 0)
                    {
                        return "NO DATA";
                    }
                    if (recvBytes[0] != STX)
                    {
                        //
                        // Show the receive data after converting the receive data to Shift-JIS.
                        // Terminating null to handle as string.
                        //
                        recvBytes[recvSize] = 0;
                        return Encoding.GetEncoding("Shift_JIS").GetString(recvBytes);
                    }
                    else
                    {
                       continue;
                    }
                }
               
            }
            else
            {
                return "PORT IS CLOSED";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string codeTuMayFile = DocFile()[3];
            string codeTuMayScan = txtDocScan.Text;
            txtKetQua.Text = KiemTra(codeTuMayFile, codeTuMayScan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDocScan.Text = DocCom();
            string codeTuMayFile = DocFile()[3];
            string codeTuMayScan = txtDocScan.Text;
            txtKetQua.Text = KiemTra(codeTuMayFile, codeTuMayScan);
        }

        private void frmKiemTra_Load(object sender, EventArgs e)
        {
            duongDan = ".\\txtFile\\1.txt";
            ConnectCOM();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                ConnectCOM();
            }
            else
            {
                lblStatus.Text = "Connected";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Enabled = false;
            timer2.Enabled = false;
            if (!serialPort1.IsOpen)
            {
                frmConfig f = new frmConfig();
                f.ShowDialog();
                ConnectCOM();
                timer1.Enabled = true ;
                timer2.Enabled = true ;
            }
              
        }
    }
}
