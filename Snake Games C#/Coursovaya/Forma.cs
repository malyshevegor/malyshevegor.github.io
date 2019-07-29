using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursovaya
{
    public partial class Forma : Form
    {
        
        public Forma()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
           if(textBox1.Text != ""){
               Form ifrm = new Form1();
               ifrm.Show(); // отображаем Form1
               this.Hide(); // скрываем Forma (this - текущая форма)               
                
           }
            {
                Data.Text = textBox1.Text;
            }
            if (textBox1.Text == "") // проверка на заполнение поля с именем игрока
            {
                label2.Visible = true;
                textBox1.BackColor = Color.Red;   
            }
            {
                Data.Text = textBox1.Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules r = new Rules();

            r.Show();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Founder f = new Founder();

            f.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;  
            textBox1.BackColor = Color.White;
        }
    }
}
