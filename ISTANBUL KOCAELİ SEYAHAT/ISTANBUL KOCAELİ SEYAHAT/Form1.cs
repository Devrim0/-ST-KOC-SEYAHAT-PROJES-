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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "devrim" && textBox2.Text=="1234") {
                Form3 seyahat = new Form3();
                seyahat.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("yanlış girdiniz tekrar deneyin");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
