using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoapp
{
    public partial class Form1 : Form
    {
        bool CargoGoogle = false;
        bool CargoMsn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bingresult = "";
          //  decimal totalGoogle = 0;
          //  decimal totalMsn = 0;

            HtmlDocument doc = GoogleBrowser.Document;
            HtmlElement elemento = doc.GetElementById("result-stats");
            string stats = elemento.InnerHtml;

            var matches = Regex.Matches(stats, @"Cerca de ([0-9,]+) ");

            var total = matches[0].Groups[1].Value;
           // totalGoogle = Decimal.Parse(total,NumberStyles.AllowThousands);
            resultado.Text = "Google : " +total.ToString() + " total coincidencias.";

            doc = MsnBrowser.Document;
            elemento = doc.GetElementById("b_tween");
            foreach (HtmlElement elem in elemento.Children)
            {
               bingresult = elem.InnerHtml;
                break;
            }
            //if(bingresult.IndexOf(".")>0)
              //  bingresult = bingresult.Remove(bingresult.IndexOf("."), 1);
            total = bingresult.Substring(0, bingresult.IndexOf(" resultados"));

            /*totalMsn = Decimal.Parse(total, NumberStyles.AllowThousands);

            if (totalGoogle > totalMsn)
                lblComparativo.Text = "el ganador es Google";
            else
                lblComparativo.Text = "el ganador es MSN";*/
            msnlabel.Text = "BING: "+total.ToString() + " total coincidencias.";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
    
            button1.Enabled = false;

            Uri googleUri = new Uri(util.Constantes.URL_GOOGLE + txtSearch.Text);
            GoogleBrowser.Navigate(googleUri);
            
            Uri msnUri = new Uri(util.Constantes.URL_MSN + txtSearch.Text);
            MsnBrowser.Navigate(msnUri);

        }

        private void GoogleBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            CargoGoogle = true;
            if (CargoGoogle && CargoMsn)
                button1.Enabled = true;
        }

        private void MsnBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            CargoMsn = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
