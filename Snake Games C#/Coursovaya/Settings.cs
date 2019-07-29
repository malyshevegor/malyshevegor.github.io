using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursovaya
{
    public enum Direction // обьявление перечисления 
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; } // get - считывание свойста, а set - изменеие свойства или присвоение нового значения
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; } // изменение значения элемента

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 15;
            Score = 0;
            Points = 1;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
