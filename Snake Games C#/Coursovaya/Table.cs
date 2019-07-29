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

    public partial class Table : Form
    {
        int c;

        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\Coursovaya\gamers.txt"); //чтение из файла
            DataSet ds = new DataSet(); //организация файла в виде таблицы

            ds.Tables.Add("Score"); //добавление новой таблицы
            string header = sr.ReadLine(); // метод для считывание строки
            string[] col = System.Text.RegularExpressions.Regex.Split(header, " "); //проверка на пробел между словами
            for (int с = 0; c < col.Length; c++)
            {
                ds.Tables[0].Columns.Add(col[c]); //добавление столбцов в таблицу
            }
            string row = sr.ReadLine(); //считывание строки
            while (row != null)
            {
                string[] rvalue = System.Text.RegularExpressions.Regex.Split(row, " ");
                ds.Tables[0].Rows.Add(rvalue); // добавление строки 
                row = sr.ReadLine();
            }

            dataGridView1.DataSource = ds.Tables[0]; // добавление данных любого типа

            this.dataGridView1.Sort(this.dataGridView1.Columns["Score"], ListSortDirection.Ascending); //сортировка данных в колонке Score
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

