using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DemoIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i= Convert.ToInt32(nudTu .Value); i<=nudDen.Value;i++)
            {
               
                pbQRcode.Image = null;
                pbQRcode.Update();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                string str = txtMa.Text.ToUpper() + String.Format("{0:D6}", i);
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
                lblSTT.Text = i.ToString();
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                pbQRcode.Image = qrCodeImage;
                PrintDocument p = new PrintDocument();

                //PrintDialog dlgSettings = new PrintDialog();      //for choosing printer
                //PrintPreviewDialog preview = new PrintPreviewDialog();
                //preview.Document = p;
                //dlgSettings.Document = p;
                comboPaperSource.DisplayMember = "SourceName";
     
                //for (int j = 0; j < p.PrinterSettings.PaperSources.Count; j++)
                //{
                //    pkSource = p.PrinterSettings.PaperSources[j];
                //    comboPaperSource.Items.Add(pkSource);
                //}
             //   p.PrinterSettings.DefaultPageSettings.Landscape = true; 
                p.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Tai", 115, 45);
                p.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                p.DefaultPageSettings.PaperSize = new PaperSize("Tai", 115, 45);
              //  p.DefaultPageSettings.Landscape = true;
                p.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                p.DocumentName = txtMa.Text + i.ToString();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawImage(qrCodeImage,15,8,30,30);
                    e1.Graphics.DrawString(txtMa.Text.ToUpper() + "\n" + String.Format("{0:D6}", i), new Font("Times New Roman",8), new SolidBrush(Color.Black), new PointF(60, 10));
                };
                PrintController pc = new StandardPrintController();
                p.PrintController = pc;
                p.Print();

                Application.DoEvents();
                Thread.Sleep(1000);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudDen.Maximum = int.MaxValue;
            nudTu.Maximum = int.MaxValue;
        }

    }
}
