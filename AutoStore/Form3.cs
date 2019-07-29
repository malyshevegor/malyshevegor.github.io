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

namespace Auto
{
    public partial class Form3 : Form
    {
        Form formtoopen;
        public Form3(Form1 form)
        {
            InitializeComponent();
            formtoopen = form;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            formtoopen.Show();//Открывает Form
            this.Close();//Form3 закрывает
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Не введен пароль и/или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string text = "";

                using (StreamWriter sw = new StreamWriter("logandpass.txt", false, Encoding.GetEncoding(1251)))//Открывает файл для перезаписи

                {

                    text += textBox2.Text + ";" + int.Parse(textBox1.Text);//Добавляет логин, разделитель и пароль

                    sw.WriteLine(text);//Записывает в файл

                }

                MessageBox.Show("Новые данные записаны.");//Оповещает, что данные записаны 
                formtoopen.Show();
                this.Close();
            }
        }

    }
}