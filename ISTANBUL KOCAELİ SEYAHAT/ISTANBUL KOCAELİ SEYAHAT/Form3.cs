using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTANBUL_KOCAELİ_SEYAHAT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bilet = new Form2();
            bilet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            groupBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin1.yayindakiler.com:3040/";
            
        }

        private void button4_Click(object sender, EventArgs e)
            
        {
            
            axWindowsMediaPlayer2.URL = "http://dinle.arabeskradyo.biz:2011/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = "http://dinle.arabeskradyo.biz:2011/";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.freemeteo.com/havadurumu/van/current-weather/location/?gid=298117&language=turkish&country=turkey");

        }
    }
}
