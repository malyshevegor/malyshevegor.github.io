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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            namecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;//Пользователь может выбрать данные из выпадающего списка
            typecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            quanitycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                   

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if ((namecombo.Text == "") || (typecombo.Text == "") || (quanitycombo.Text == ""))//Условия, когда поля пустые
            {
                MessageBox.Show("Необходимо ввести данные во все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Вывод ошибка
            }
            else//Далее идет выбор через условие
            {
                if (namecombo.SelectedItem.ToString() == "Lada Largus")
                {
                    if (typecombo.SelectedItem.ToString() == "Серый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 300).ToString();//Подсчитывавется цена выбранных данных
                    }
                    if (typecombo.SelectedItem.ToString() == "Черный")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 350).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Темно-синий")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) *  150).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Белый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 20).ToString();
                    }

                    Random r = new Random();//Вызов генератора
                    int x = r.Next(100000000, 999999999); //Генерируется случайный ID для клиента          
                    idtext.Text = x.ToString();//Переменная добавляется в строку                                    

                    dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);//Все данные заносятся в DataGridView
                }
                if (namecombo.SelectedItem.ToString() == "Mazda CX6")
                {
                    if (typecombo.SelectedItem.ToString() == "Серый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 150).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Черный")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 120).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Темно-синий")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 100).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Белый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 100).ToString();
                    }

                    Random r = new Random();
                    int x = r.Next(100000000, 999999999);
                    idtext.Text = x.ToString();

                    dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
                }
                if (namecombo.SelectedItem.ToString() == "Mersedes E-cype")
                {
                    if (typecombo.SelectedItem.ToString() == "Серый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 200).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Черный")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 170).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Темно-синий")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 190).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Белый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 100).ToString();
                    }

                    Random r = new Random();
                    int x = r.Next(100000000, 999999999);
                    idtext.Text = x.ToString();

                    dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
                }
                if (namecombo.SelectedItem.ToString() == "Ford Focus")
                {
                    if (typecombo.SelectedItem.ToString() == "Серый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 180).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Черный")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 150).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Темно-синий")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 120).ToString();
                    }
                    if (typecombo.SelectedItem.ToString() == "Белый")
                    {
                        paytext.Text = (float.Parse(quanitycombo.Text) * 120).ToString();
                    }

                    Random r = new Random();
                    int x = r.Next(100000000, 999999999);
                    idtext.Text = x.ToString();

                    dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
                }

               /* StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\AutoStore\\AutoStore\\price.txt");//Открывает файл для чтения
                string line = "";
                while ((line = sr.ReadLine()) != null)//Пока в файле есть данный считывает их
                {
                    string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);// Отделяет Логин и Пароль
                    dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quanitycombo.Text, paytext.Text);

                    /*idtext.Text.Add(components[0]);//Заносит Логин в массив пользователей
                    namecombo.Text.Add(components[1]);
                    typecombo.Text.Add(components[2]);
                    quanitycombo.Text.Add(components[3]);
                    paytext.Text.Add(components[4]);*/



               // }
                //sr.Close();//Закрывает файл для чтения 

                string text = "";

                using (StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\AutoStore\\AutoStore\\price.txt", true, Encoding.GetEncoding(1251)))//Открывает файл для перезаписи

                {

                    text += idtext.Text + " " + namecombo.Text + " " + typecombo.Text + " " + quanitycombo.Text + " " + paytext.Text + " ";//Добавляет логин, разделитель и пароль

                    sw.WriteLine(text);//Записывает в файл

                }

            }
        }   
            private void Button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";//Очищает поле
            namecombo.SelectedIndex = -1;//Очищает поле, посредством выбора несуществующего индекса
            quanitycombo.SelectedIndex = -1;     
            typecombo.SelectedIndex = -1;
            paytext.ResetText();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();//Закрывает приложение
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try//Если находит соответсвующую строчку, то удаляет её
            {
                int dd = dataGridView1.SelectedCells.Count;
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            }
            catch
            {
                MessageBox.Show("Данные для удаления отсутствуют.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//Иначе выводит ошибку
            }              
        }   
        

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.Show();//Показывает Form3
            Hide();//Скрывает данную форму
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quanitycombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kat form = new Kat();
            form.Show();//Показывает Form3
            
        }
    }
}
