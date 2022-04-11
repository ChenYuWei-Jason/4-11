using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void Hello_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            MessageBox.Show("Hello ,  "+s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            MessageBox.Show("Hi ,  " + s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Green;
            label1.BorderStyle = BorderStyle.Fixed3D;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Click += Button3_Click;   
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
            MessageBox.Show("HELLO");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SystemInformation.ComputerName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //SystemInformation.ComputerName = "xxx";  這是get，唯一值不能get
            string s = SystemInformation.ComputerName;   //這是set，可以讀出來
            MessageBox.Show(s);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // File.Copy("a.txt", "a1.txt");

            FileInfo f = new FileInfo("b.txt");
            f.CopyTo("b1.txt",true);
            MessageBox.Show(f.CreationTime + "\n"+f.FullName+"\n"+f.Extension );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //string s= textBox1.Text;
            //System.Windows.Form1.Text = s;

            //-----------------------------------------------------

            //Form1  f = new Form1();
            //f.Text = textBox1.Text;
            //f.Show();

            //-----------------------------------------------------

            this.Text = "HELLO,  " + this.textBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
