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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            
            
                listBox7.Items.Add(button4.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }

                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }
                if (radioButton2.Text == "Bayan" && radioButton2.Checked != false)
                {
                    button4.BackColor = Color.Pink;
                }

                if (radioButton1.Text == "Bay" && radioButton1.Checked != false)
                {
                    button4.BackColor = Color.Blue;
                }
                button4.Enabled = false;
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                listBox7.Items.Add(button3.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }
                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }
                if (radioButton2.Text == "Bayan" && radioButton2.Checked != false)
                {
                    button3.BackColor = Color.Pink;
                }
                if (radioButton1.Text == "Bay" && radioButton1.Checked != false)
                {
                    button3.BackColor = Color.Blue;
                }
                button3.Enabled = false;
            
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
                listBox7.Items.Add(button2.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }
                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }

                if (radioButton2.Text == "Bayan" && radioButton2.Checked != false)
                {
                    button2.BackColor = Color.Pink;
                }
                if (radioButton1.Text == "Bay" && radioButton1.Checked != false)
                {
                    button2.BackColor = Color.Blue;
                }
                button2.Enabled = false;
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                listBox7.Items.Add(button7.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }
                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }

                if (radioButton2.Text == "Bayan" && radioButton2.Checked != false)
                {
                    button7.BackColor = Color.Pink;
                }
                if (radioButton1.Text == "Bay" && radioButton1.Checked != false)
                {
                    button7.BackColor = Color.Blue;
                }

                button7.Enabled = false;
            }
            else
            {
                MessageBox.Show("ad ve soyad boş olamaz");
            }
        }

        private void button6_Click(object sender, EventArgs e)

        {
            
                listBox7.Items.Add(button6.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }
                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }

                if (radioButton2.Text == "Bayan" && radioButton2.Checked != false)
                {
                    button6.BackColor = Color.Pink;
                }
                if (radioButton1.Text == "Bay" && radioButton1.Checked != false)
                {
                    button6.BackColor = Color.Blue;
                }

                button6.Enabled = false;
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
                listBox7.Items.Add(button5.Text);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                listBox6.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {

                    listBox5.Items.Add(radioButton1.Text);

                }
                if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton2.Text);
                }

                if (radioButton2.Text == "Bayan" && radioButton2.Checked!=false )
                {
                    button5.BackColor = Color.Pink;
                }

                if (radioButton1.Text =="Bay" && radioButton1.Checked!= false)
                {
                    button5.BackColor = Color.Blue;
                }
                button5.Enabled = false;
           
        }



        private void button8_Click(object sender, EventArgs e)

        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            button1.Enabled = false;
            button1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 geri = new Form3();
            geri.Show();
            this.Hide();

        }

        private void button_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

            button1.BackColor = Color.MediumSpringGreen;
            button2.BackColor = Color.MediumSpringGreen;

            button4.BackColor = Color.MediumSpringGreen;
            button3.BackColor = Color.MediumSpringGreen;

            button5.BackColor = Color.MediumSpringGreen;
            button6.BackColor = Color.MediumSpringGreen;
            button7.BackColor = Color.MediumSpringGreen;




        }
    }
}
