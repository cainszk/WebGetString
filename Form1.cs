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
using System.Text.RegularExpressions;

namespace WebGetString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void getcode()
        {
            string back = getwebcode1(txt4url.Text, "UTF-8");
            txt4show.Text = back;
        }

        public static string getwebcode1(string url, string encoder)
        {
            WebClient myWebClient = new WebClient();
            byte[] myDataBuffer = myWebClient.DownloadData(url);
            string SourceCode = Encoding.GetEncoding(encoder).GetString(myDataBuffer);
            return SourceCode;
        }

        private void btn4get_Click(object sender, EventArgs e)
        {
            getcode();
        }

        private void ck4auto_CheckStateChanged(object sender, EventArgs e)
        {
            if (ck4auto.CheckState == CheckState.Checked)
            {
                timer1.Enabled = true;
                t1int.Enabled = true;
                if(Convert.ToDouble(t1int.Text)<1)
                {
                    t1int.Text = "1";
                }
                timer1.Interval = Convert.ToInt32(t1int.Text)*1000;
            }
            else
            {
                timer1.Enabled = false;
                t1int.Enabled = false;
            }

         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getcode();
            substr();
        }

        private void t1int_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(t1int.Text) < 1)
            {
                t1int.Text = "1";
                
            }
        }

        private void t1int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46) //小数点
            {
                if (t1int.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(t1int.Text, out oldf);
                    b2 = float.TryParse(t1int.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        void substr()
        {
            string txt = txt4show.Text;
            string[] sArray = txt.Split(new string[] { txt4sub0x.Text, txt4sub0y.Text }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sub0 in sArray)
            {
                txt4sub0.Text = sArray[1];
            }
        }
        private void btn4substr_Click(object sender, EventArgs e)
        {
            substr();
        }
    }
}
