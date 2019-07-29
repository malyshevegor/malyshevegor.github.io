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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();//Создает лист пользователей
        List<string> pass = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("logandpass.txt");//Открывает файл для чтения
            string line = "";
            while ((line = sr.ReadLine()) != null)//Пока в файле есть данный считывает их
            {
                string[] components = line.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);// Отделяет Логин и Пароль
                users.Add(components[0]);//Заносит Логин в массив пользователей
                pass.Add(components[1]);
            }
            sr.Close();//Закрывает файл для чтения

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(users.Contains(logintxt.Text) && pass.Contains(passtxt.Text) && Array.IndexOf(users.ToArray(), logintxt.Text) == Array.IndexOf(pass.ToArray(), passtxt.Text))//Проверка введенных данных с данными в файле
            {
                Form1 s = new Form1();
                s.Show();
                this.Hide();
            }
            else if(logintxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Не введен пароль и/или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Неправильный логин и/или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}