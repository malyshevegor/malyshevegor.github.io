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
    public partial class Form1 : Form
    {
        private List<Square> Snake = new List<Square>();
        private Square food = new Square();


        public Form1()
        {
            InitializeComponent();

            //Установка настройки по умолчанию
            new Settings();

            //Установка скорости игры и запуск таймера
            gameTimer.Interval = 1200 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Начало Новой игры
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false; // по умолчанию лейбл скрыт

            //Установить настройки по умолчанию
            new Settings();

            //Создать новый объект, добавить змейку на поле
            Snake.Clear(); //сброс значений
            Square head = new Square { X = 10, Y = 5 };
            Snake.Add(head);

            label2.Text = Data.Text;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();

        }

        //Поместить случайный фрукт
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Square { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            // Проверка на окончание игры
            if (Settings.GameOver)
            {
                //Проверьте, нажата ли Enter
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate(); // перерисовывает обьект 

        }



        public void Form1_Load(object sender, EventArgs e)
        {
                   
        }

        public void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; //предоставляет методы для рисования обьекта
            if (!Settings.GameOver)
            {
                //Установка цвета змеи

                //Рисование змеи
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour; // заливка обьекта цветом
                    if (i == 0)
                        snakeColour = Brushes.Green;     //Нарисовать голову
                    else
                        snakeColour = Brushes.Green;    //Остальная часть тела
                    //Нарисовать змею
                    canvas.FillRectangle(snakeColour, // рисование змеи 
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));
                    //Нарисовать еду
                    canvas.FillEllipse(Brushes.Yellow,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Конец игры!\nИгрок: " + Data.Text + "\nТвой финальный счет: " + Data.Sco + "\nНажми Enter, чтобы начать заново.";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true; // высвечивание лейбла когда игра закончиться
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Движение головы
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Задание максимума X и Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Обнаружение столкновения с игровыми границами
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Обнаружение столкновения с телом
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Обнаружение столкновения с куском пищи
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Движение тела
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        public void Eat()
        {
            //Добавить круг к телу
            Square circle = new Square
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Обновление очков           
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();
            Data.Sco = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;

            string text = "";

            using (StreamWriter sw = new StreamWriter(@"C:\Users\admin\source\repos\Coursovaya\gamers.txt", true, Encoding.GetEncoding(1251)))
            {               
                text += Data.Text + " " + Data.Sco;
                sw.WriteLine(text); //запись строки в файл               
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true); // изменение состояния/позиции
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false); // изменение состояния/позиции
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table t = new Table();

            t.Show();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Founder f = new Founder();

            f.Show();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rules r = new Rules();

           r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forma fu = new Forma();

            fu.Show();
            
        }

        private void вМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void вToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}

