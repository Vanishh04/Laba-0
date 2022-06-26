using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            var i = new Random();
            int n = i.Next(-100, 100);

            if (n > 0) 
            {
                button2.BackColor = Color.DarkCyan;
                label9.BackColor = Color.DarkCyan;
                label10.BackColor = Color.DarkCyan;
                label11.BackColor = Color.DarkCyan;
            }
            else 
            {
                button2.BackColor = Color.DarkBlue;
                label9.BackColor = Color.DarkBlue;
                label10.BackColor = Color.DarkBlue;
                label11.BackColor = Color.DarkBlue;
            }




            try
            {


                string x = textBox1.Text;
                string b = textBox2.Text;
                string c = textBox3.Text;

                var x1 = Convert.ToDouble(x); ;
                var b1 = Convert.ToDouble(b);
                var c1 = Convert.ToDouble(c);

                if (x1 == b1)
                {
                    string rez = " Ошибка ОДЗ!!! Параметр х равняется параметру b";
                    textBox5.Text = rez.ToString();
                    string rez1 = " --- ";
                    textBox4.Text = rez1.ToString();
                }
                else if (x1 < b1)
                {
                    string rez = " Ошибка ОДЗ!!! Параметр х меньше параметра b";
                    textBox5.Text = rez.ToString();
                    string rez1 = " --- ";
                    textBox4.Text = rez1.ToString();
                }
                else if(x1<=0 && b1 >= 0) 
                {
                    string rez = " Ошибка ОДЗ!!! Параметр х и b меньше 0, недопустимо для корня";
                    textBox5.Text = rez.ToString();
                    string rez1 = " --- ";
                    textBox4.Text = rez1.ToString();
                }
                else if(x1<0 && b1<0 && x1 < b1) 
                {
                    string rez = " Ошибка ОДЗ!!! Минусовое значение под корнем";
                    textBox5.Text = rez.ToString();
                    string rez1 = " --- ";
                    textBox4.Text = rez1.ToString();
                }
                else
                {
                    double y1;
                    y1 = ((2 * x1 - c1) / (Math.Sqrt(x1 - b1))) + Math.Abs(x1 - c1);
                    textBox4.Text = y1.ToString();
                    string rez1 = " --- ";
                    textBox5.Text = rez1.ToString();
                }

            }
            catch
            {

                MessageBox.Show("Ошибка ввода символов.", "Произошла ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();


                button1.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label6.BackColor = Color.Green;
                label7.BackColor = Color.Green;

                button2.BackColor = Color.Yellow;
                label9.BackColor = Color.Yellow;
                label10.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;



            }



           
           

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = new Random();
            int n = i.Next(-100, 100);

            if (n >= 0)
            {
                button1.BackColor = Color.DarkCyan;
                label4.BackColor = Color.DarkCyan;
                label5.BackColor = Color.DarkCyan;
                label6.BackColor = Color.DarkCyan;
                label7.BackColor = Color.DarkCyan;
            }
            else
            {
                button1.BackColor = Color.DarkBlue;
                label4.BackColor = Color.DarkBlue;
                label5.BackColor = Color.DarkBlue;
                label6.BackColor = Color.DarkBlue;
                label7.BackColor = Color.DarkBlue;
            }






            try
            {


                string x = textBox7.Text;
                string z = textBox8.Text;

                var x2 = Convert.ToDouble(x);
                var z1 = Convert.ToDouble(z);
                double y2;

                if(x2==0 && z1 == 0) 
                {
                    string rez = " Ошибка ОДЗ!!! Параметр х равняется параметру z ";
                    textBox6.Text = rez.ToString();
                    string rez1 = " --- ";
                    textBox9.Text = rez1.ToString();

                }
                else
                {
                    y2 = Math.Log(Math.Abs((z1 - Math.Sqrt(Math.Abs(x2))))) / Math.Log(4);
                    textBox9.Text = y2.ToString();
                    string rez1 = " --- ";
                    textBox6.Text = rez1.ToString();

                }

                


            
            }
            catch
            {
                MessageBox.Show("Ошибка ввода символов.", "Произошла ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox6.Clear();

                button2.BackColor = Color.Yellow;
                label9.BackColor = Color.Yellow;
                label10.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;

                button1.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label6.BackColor = Color.Green;
                label7.BackColor = Color.Green;

                button2.BackColor = Color.Yellow;
                label9.BackColor = Color.Yellow;
                label10.BackColor = Color.Yellow;
                label11.BackColor = Color.Yellow;
            }
       }   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult exzt = MessageBox.Show("Желаете выйти из приложения?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(exzt == DialogResult.Yes) 
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            button1.BackColor = Color.Green;
            label4.BackColor = Color.Green;
            label5.BackColor = Color.Green;
            label6.BackColor = Color.Green;
            label7.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox6.Clear();

            button2.BackColor = Color.Yellow;
            label9.BackColor = Color.Yellow;
            label10.BackColor = Color.Yellow;
            label11.BackColor = Color.Yellow;

            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
