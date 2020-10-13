using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных + инициализация + ввод и вывод на консоль
            bool _bool = true;
            Console.WriteLine($"Переменная типа {_bool.GetType()} Исходное значение {_bool} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_bool.GetType()}");
            //_bool = Convert.ToBoolean(Console.ReadLine());
            byte _byte = 0xFF;
            Console.WriteLine($"Переменная типа {_byte.GetType()} Исходное значение 0x{_byte:X2} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_byte.GetType()}");
            //_byte = Convert.ToByte(Console.ReadLine());
            sbyte _sbyte = -127;
            char _char = 'S';
            Console.WriteLine($"Переменная типа {_char.GetType()} Исходное значение {_char} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_char.GetType()}");
            //_char = Convert.ToChar(Console.ReadLine());
            decimal _decimal = 123.5M;
            Console.WriteLine($"Переменная типа {_decimal.GetType()} Исходное значение {_decimal} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_decimal.GetType()}");
            //_decimal = Convert.ToDecimal(Console.ReadLine());
            double _doule = 123.5;
            float _float = 165.554F;
            int _int = -2000020;
            Console.WriteLine($"Переменная типа {_int.GetType()} Исходное значение {_int} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_int.GetType()}");
            //_int = int.Parse(Console.ReadLine());
            uint _uint = 2225552;
            long _long = 65465321684523135;
            ulong _ulong = 6543524;
            short _short = 32767;
            ushort _ushort = 65535;
            object _object = _int;
            string _string = "Hello World";
            Console.WriteLine($"Переменная типа {_string.GetType()} Исходное значение {_string} ");
            Console.WriteLine($"Введите новое значение для переменной типа {_string.GetType()}");
            //_string = Console.ReadLine();
            dynamic _dynamic = _char + _string;

            //Вывод введеных значений
            Console.WriteLine($"Переменная типа {_bool.GetType()} Новое значение {_bool} ");
            Console.WriteLine($"Переменная типа {_byte.GetType()} Новое значение 0x{_byte:X2} ");
            Console.WriteLine($"Переменная типа {_sbyte.GetType()} Новое значение 0x{_sbyte:X2} ");
            Console.WriteLine($"Переменная типа {_char.GetType()} Новое значение {_char} ");
            Console.WriteLine($"Переменная типа {_decimal.GetType()} Новое значение {_decimal} ");
            Console.WriteLine($"Переменная типа {_doule.GetType()} Новое значение {_doule} ");
            Console.WriteLine($"Переменная типа {_float.GetType()} Новое значение {_float} ");
            Console.WriteLine($"Переменная типа {_int.GetType()} Новое значение {_int} ");
            Console.WriteLine($"Переменная типа {_uint.GetType()} Новое значение {_uint} ");
            Console.WriteLine($"Переменная типа {_long.GetType()} Новое значение {_long} ");
            Console.WriteLine($"Переменная типа {_ulong.GetType()} Новое значение {_ulong} ");
            Console.WriteLine($"Переменная типа {_short.GetType()} Новое значение {_short} ");
            Console.WriteLine($"Переменная типа {_ushort.GetType()} Новое значение {_ushort} ");
            Console.WriteLine($"Переменная типа {_object.GetType()} Новое значение {_object} ");
            Console.WriteLine($"Переменная типа {_string.GetType()} Новое значение {_string} ");
            Console.WriteLine($"Переменная типа {_dynamic.GetType()} Новое значение {_dynamic} ");


            Console.WriteLine("\n\n\n\n\n -------------------------------------------------------");
            //Boxing/ unboxing
            int i = 54;
            object j = i;
            var q = (int)j;
            Console.WriteLine($"Переменная типа {i.GetType()}  {i} ");
            Console.WriteLine($"Переменная типа {j.GetType()} УПАКОВАНАЯ {j} ");
            Console.WriteLine($"Переменная типа {q.GetType()} РАСПАКОВНВЯ {q} ");

            //работа со строками
            string s1 = "Всем привет ";
            string s2 = "Сегодня хорошая погода";
            string s3 = "До свидания";

            //Конкатенация

            var s4 = String.Concat(s1, s2);

            Console.WriteLine(s4);
            s4 = string.Join("!!!", s1, s2);
            Console.WriteLine(s4);

            //Сравнение строк

            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }

            //Поиск в строке

            char ch = 'д';
            int index_number = s3.IndexOf(ch);
            Console.WriteLine($"Индекс буквы {ch} в Строке \"{s3}\" равен {index_number}");
            string subString = "рош";
            int index_number2 = s2.IndexOf(subString);
            Console.WriteLine($"Индекс букв {subString} в Строке \"{s2}\" равен {index_number2}");

            // Разделение
            string[] words = s2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //обрезка
            s4 = s1.Trim();
            Console.WriteLine(s4);

            s4 = s1.Trim(new char[] { 'В', 'т' });
            Console.WriteLine(s4);
            
            //вставка
            s4 = s2.Insert(s2.Length, s3);
            Console.WriteLine(s4);

            //удаление
            s4 = s4.Remove(s4.Length - 3);
            Console.WriteLine(s4);

            s4 = s4.Remove(0, 8);
            Console.WriteLine(s4);

            //замена
            s4 = s4.Replace("хорошая", "плохая");
            Console.WriteLine(s4);
            //смена регистра
            s4 = s4.ToUpper();
            Console.WriteLine(s4);
            s4 = s4.ToLower();
            Console.WriteLine(s4);

            Console.ReadLine();
        }
    }
}
