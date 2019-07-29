using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursovaya
{
    class Square
    {
        public int X { get; set; } // get - считывание свойста, а set - изменеие свойства или присвоение нового значения
        public int Y { get; set; }

        public Square() //задаем размеры обьекта
        {
            X = 1;
            Y = 1;
        }
    }
}
