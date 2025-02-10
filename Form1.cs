using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ExploradorWeb
{
    public partial class Explorador : Form
    {
        public Explorador()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            BotonIr.Left = this.ClientSize.Width - BotonIr.Width;
            textBox1.Width = BotonIr.Left - textBox1.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //webBrowser1.GoHome();
        }

        private void BotonIr_Click(object sender, EventArgs e)
        {
            
            if (webView != null && webView.CoreWebView2 != null)
            {
                if (textBox1.Text.Contains("https://") && textBox1.Text.Contains(".com") || textBox1.Text.Contains(".com/")) {
                    webView.CoreWebView2.Navigate(textBox1.Text);
                }
                if (textBox1.Text.Contains(".com/") || textBox1.Text.Contains(".com"))
                {
                    webView.CoreWebView2.Navigate("https://" + textBox1.Text);
                }
                if (textBox1.Text.Contains("https://"))
                {
                    webView.CoreWebView2.Navigate(textBox1.Text);
                }
                else {
                    webView.CoreWebView2.Navigate(" https://www.google.com/search?q=" + textBox1.Text);
                }
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void haciaAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void haciaAdelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void webView_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
