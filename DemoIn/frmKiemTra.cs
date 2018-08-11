using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace DemoIn
{
    public partial class frmKiemTra : Form
    {
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
            if (codeTuMayFile == codeTuMayScan)
            {
               if (DocFile()[4]=="")
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
        private void button2_Click(object sender, EventArgs e)
        {
            string codeTuMayFile = DocFile()[3];
            string codeTuMayScan = txtDocScan.Text;
            txtKetQua.Text = KiemTra(codeTuMayFile, codeTuMayScan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string codeTuMayFile = DocFile()[3];
            string codeTuMayScan = txtDocScan.Text;
            txtKetQua.Text = KiemTra(codeTuMayFile, codeTuMayScan);
        }

        private void frmKiemTra_Load(object sender, EventArgs e)
        {
            duongDan = ".\\txtFile\\1.txt";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfig f =new frmConfig ();
            f.ShowDialog();
        }
    }
}
