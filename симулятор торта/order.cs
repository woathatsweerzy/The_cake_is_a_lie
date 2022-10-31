using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace ТортЭтоЛожь
{
    internal class order
    {
        public string[] name = new string[5];
        public int[] cost = new int[5];
        public static void full(int sumin, List<string> cake)
        {
            string a = string.Join(", ", cake);
            string path = "C:\\Рабочий стол\\caсke\\Заказ_торта.txt";
            File.AppendAllText(path, "Заказ от: " + DateTime.Today + "\n");
            File.AppendAllText(path, "Ваш торт: " + a + "\n");
            File.AppendAllText(path, "Сумма заказа: " + sumin + "\n" + "\n");
        }
    }
}
