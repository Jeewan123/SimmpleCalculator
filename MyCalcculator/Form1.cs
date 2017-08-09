using System;
using System.Windows.Forms;

namespace MyCalcculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

         float num, result;
         int count;

        public void turnOff()
        {
            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            

        }

        public void turnOn()
        {
            textBox1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
           textBox1.Text = Convert.ToString(textBox1.Text + ".");
        }

        private void button1_Click(object sender, EventArgs e)//off
        {
            turnOff();
        }

        private void button2_Click(object sender, EventArgs e)//on
        {
            turnOn();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            count = 1;
            
            num = Convert.ToSingle(textBox1.Text);
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
          //  textBox1.Text = (num + Convert.ToSingle(textBox1.Text)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = Convert.ToSingle(textBox1.Text);
            textBox1.Clear();
            count = 2;
        
        }

        private void button18_Click(object sender, EventArgs e)
        {
          num = Convert.ToSingle(textBox1.Text);
            textBox1.Clear();
            count = 3;


        }

        private void button20_Click(object sender, EventArgs e)
        {
            num = Convert.ToSingle(textBox1.Text);
            textBox1.Clear();
            count = 4;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;

            string text1 = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < length; i++)
            {
                textBox1.Text =textBox1.Text + text1[i];
            }
        }

        public void calculate()
        {
            switch (count)
            {
                case 1:
                    result = num + Convert.ToSingle((textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;


                case 2:
                    result = num - Convert.ToSingle((textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;

                case 3:
                    result = num * Convert.ToSingle((textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;

                case 4:
                    result = num / Convert.ToSingle((textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;


                default:
                    break;
            }
        }
    }
}
