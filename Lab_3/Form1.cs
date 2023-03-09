using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Circle c=new Circle(Convert.ToDouble(textBox5.Text), 
                Convert.ToDouble(textBox1.Text), 
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text), 
                Convert.ToDouble(textBox4.Text));
            label4.Text = "Площа кола: "+(c.Area()).ToString();
            label5.Text = "Довжина круга: "+(c.Circumference()).ToString();
            label6.Text = c.Check();
        }
    }
}