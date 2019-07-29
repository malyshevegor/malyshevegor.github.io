using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace Coursovaya
{
    internal class Input
    {
        //Загрузить список доступных кнопок клавиатуры
        private static Hashtable keyTable = new Hashtable(); //обьединение в список элементов

        //Выполните проверку, чтобы увидеть, нажата ли конкретная кнопка.
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Определить, нажата ли кнопка клавиатуры
        public static void ChangeState(Keys key, bool state) // изменение состояния/позиции
        {
            keyTable[key] = state;
        }
    }
}
