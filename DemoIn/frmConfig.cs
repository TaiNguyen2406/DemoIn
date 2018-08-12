using System;
using System.Xml;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
namespace DemoIn
{
    public partial class frmConfig : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public frmConfig()
        {
            InitializeComponent();
        }
        public void getConfig()
        {
            try
            {
                xmlDoc.Load(Application.StartupPath + @"\Config.xml");
                XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("ComPort");
                cbPort.SelectedItem = node.Attributes["Name"].Value;
                tbBaudRate.Value = decimal.Parse(node.Attributes["BaudRate"].Value);
                tbParity.Value = decimal.Parse(node.Attributes["Parity"].Value);
                tbDataBits.Value = decimal.Parse(node.Attributes["DataBits"].Value);
                tbStopBits.Value = decimal.Parse(node.Attributes["StopBits"].Value);
                tbRevBThreshold.Value = decimal.Parse(node.Attributes["ReceivedBytesThreshold"].Value);
                //tbParity.Value = decimal.Parse(GetElement(comport).GetAttribute("Parity"));
                //tbDataBits.Value = decimal.Parse(GetElement(comport).GetAttribute("DataBits"));
                //tbStopBits.Value = decimal.Parse(GetElement(comport).GetAttribute("StopBits"));
                //tbRevBThreshold.Value = decimal.Parse(GetElement(comport).GetAttribute("ReceivedBytesThreshold"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btTestCom_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
            }
            try
            {
                SerialPort1.PortName = cbPort.SelectedItem.ToString();
                SerialPort1.BaudRate = decimal.ToInt32(tbBaudRate.Value);
                SerialPort1.Parity = Parity.Even;
                SerialPort1.DataBits = decimal.ToInt32(tbDataBits.Value);
                SerialPort1.StopBits = StopBits.One;
                SerialPort1.ReceivedBytesThreshold = decimal.ToInt32(tbRevBThreshold.Value);
                SerialPort1.Open();
                if (SerialPort1.IsOpen)
                {
                    MessageBox.Show("Connect thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SerialPort1.Close();
            }
        }
        private static XmlElement GetElement(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc.DocumentElement;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\Config.xml"))
            {
                xmlDoc.Load(Application.StartupPath + @"\Config.xml");
                XmlNode node = xmlDoc.DocumentElement.SelectSingleNode("ComPort");
                node.Attributes["Name"].Value = cbPort.SelectedItem.ToString();
                node.Attributes["BaudRate"].Value = tbBaudRate.Value.ToString();
                node.Attributes["Parity"].Value = tbParity.Value.ToString();
                node.Attributes["DataBits"].Value = tbDataBits.Value.ToString();
                node.Attributes["StopBits"].Value = tbStopBits.Value.ToString();
                node.Attributes["ReceivedBytesThreshold"].Value = tbRevBThreshold.Value.ToString();

                xmlDoc.Save(Application.StartupPath + @"\Config.xml");
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            string[] comList = SerialPort.GetPortNames();
            cbPort.Items.Clear();
            foreach (string com in comList)
            {
                cbPort.Items.Add(com);
            }
            getConfig();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
