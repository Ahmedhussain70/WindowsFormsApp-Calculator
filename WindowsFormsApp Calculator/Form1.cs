using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double x;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string strname = "\t Ahmed";
            MessageBox.Show("Welocome Ahmed");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text + "" + c;
            textBox1.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            label1.Text = c;
            textBox1.Clear();

        }
        private void button19_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            label1.Text = c;
            textBox1.Clear();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            label1.Text = c;
            textBox1.Clear();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            c = b.Text;
            label1.Text = c;
            textBox1.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            switch (c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;
                case "×":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;

                case "Sin":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Math.Sin(a).ToString();
                        label1.Text = "";

                    }
                    break;
                case "Cos":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Math.Cos(a).ToString();
                        label1.Text = "";

                    }
                    break;
                case "Tan":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Math.Tan(a).ToString();
                        label1.Text = "";
                    }
                    break;
            }
        }
    }
}
                //case "Log10":
                //    {
                //        double y = Convert.ToDouble(textBox1.Text);
                //        textBox1.Text = Math.Log10(a).ToString();
                //        label1.Text = "";


            //        class m
            // {
            //static void main(string[]args)
            //{
            //  if ((num,"cos"&&)
            

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            string strname="hello";
//            MessageBox.Show("hello" + strname);
//        }
//    }
//}

     
        

        
    



        







