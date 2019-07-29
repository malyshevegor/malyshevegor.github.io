using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Kat : Form
    {
        public Kat()
        {
            InitializeComponent();
        }

        public void Kat_Load(object sender, EventArgs e)
        {
            label9.Text = Auto1.name;
            label1.Text = "Цвет: " + Auto1.color; 
            label2.Text = "Наличие: " + Auto1.price.ToString();

            label10.Text = Auto2.name;
            label3.Text = "Цвет: " + Auto2.colorr; 
            label4.Text = "Наличие: " + Auto2.pricee.ToString();

            label11.Text = Auto3.name;
            label5.Text = "Цвет: " + Auto3.color;
            label6.Text = "Наличие: " + Auto3.price.ToString();

            label12.Text = Auto4.name;
            label7.Text = "Цвет: " + Auto4.color;
            label8.Text = "Наличие: " + Auto4.price.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
