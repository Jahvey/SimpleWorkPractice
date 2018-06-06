using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winApp0100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pdf2img_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello !!!");
            
        }

        private void emf2pdf_Click(object sender, EventArgs e)
        {


        

            //PdfDocument doc = new PdfDocument();
            //PdfSection section = doc.Sections.Add();
            //section.PageSettings.Margins = new PdfMargins(0);
            //PdfPageBase page = doc.Pages.Add(section.PageSettings.Size, section.PageSettings.Margins);
            //PdfImage image = PdfImage.FromFile(@"..\loanapplpg1.emf");
            //float widthFitRate = image.PhysicalDimension.Width / page.Canvas.ClientSize.Width;
            //float heightFitRate = image.PhysicalDimension.Height / page.Canvas.ClientSize.Height;
            //float fitRate = Math.Max(widthFitRate, heightFitRate);
            //float fitWidth = image.PhysicalDimension.Width / fitRate;
            //float fitHeight = image.PhysicalDimension.Height / fitRate;
            //page.Canvas.DrawImage(image, 30, 30, fitWidth, fitHeight); doc.SaveToFile(@"..result.pdf");
            //doc.Close();


        }
    }
}
