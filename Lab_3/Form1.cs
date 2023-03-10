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
            Point centerPoint = new Point(
                Convert.ToDouble(CenterX.Text),
                Convert.ToDouble(CenterY.Text)
                );
            Point point = new Point(
                Convert.ToDouble(PointX.Text),
                Convert.ToDouble(PointY.Text)
                );
            Circle c = new Circle(Convert.ToDouble(Radius.Text), centerPoint);
            label4.Text = "Площа кола: "+(c.Area()).ToString();
            label5.Text = "Довжина круга: "+(c.Circumference()).ToString();
            if (c.Check(point))
            {
                label6.Text = "Точка в колі";
            }
            else
            {
                label6.Text = "Точка не в колі";
            }
        }
    }
}