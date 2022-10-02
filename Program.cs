using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------|--------------------------------------------------
            //--------------------------------------------------Конверторы--------------------------------------------------

            Console.WriteLine("----------Конверторы----------");

            int ka = 15;
            Console.WriteLine(Convert.ToInt32(ka));         //Convertor - конвертит всё что угодно

            string kk = "65";
            ka = int.Parse(kk);                             //Parse - работает только со строками
            Console.WriteLine(ka);
            
            string kt = "1d5";
            int kf;
            bool kb = int.TryParse(kt, out kf);             //TryParse - тоже самое что и парс, но не бросает исключения
            Console.WriteLine(kb);
            Console.WriteLine();

            //--------------------------------------------------Разветления--------------------------------------------------


            /*
            Сравнение на примере If
            == Равно
            != Не равно
            >  Больше
            <  Меньше
            >= Больше или равно
            <= Меньше или равно
            
             */

            Console.WriteLine("----------Разветления----------");
            Console.WriteLine();
            Console.WriteLine("-----If-----");
            int ra = 19;

            if (ra > 18)                                    //If - выполняет действие усли верно условие
            {
                Console.WriteLine("Тебе больше 18 лет");
            }
            if (ra==18)
            {
                Console.WriteLine("Тебе 18 лет");
            }
            if (ra<18)
            {
                Console.WriteLine("Тебе меньше 18 лет");
            }
            else
            {
                Console.WriteLine("Я не знаю сколько тебе лет");
            }

            Console.WriteLine();
            Console.WriteLine("-----Switch-----");

            switch (ra)                                     //Switch - ищет кейс с нужным условием и выполняет его
            {
                case 1:
                    Console.WriteLine("Вы ввели число");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Вы ввели число 3 или 4");
                    break;
                default:
                    Console.WriteLine("Вы ввели другое число");
                    break;
            }
            Console.WriteLine();


            //--------------------------------------------------Инкремент и дикремент--------------------------------------------------


            /*
            Постфиксный - имеет меньший приоретет
            Префиксный - имеет больший приоретет

            a++;    Постфиксный инкримент 
            a--;    Постфиксный дикремент
            ++a;    Префиксный инкримент
            --a;    Префиксный дикремент
            */


            //--------------------------------------------------Логические операторы--------------------------------------------------


            /*
                && Сокращённое И
                || Сокращённое ИЛИ
                &  И
                |  ИЛИ
                !  НЕ (унарный)
            */


            //--------------------------------------------------Операторы--------------------------------------------------


            //Унарный
            int oa = 0;
            oa++;

            //Бинарный
            int ob = 2;
            int oc = 3;
            int od = ob + oc;

            //Тернарный
            bool osave;
            string ostr = "qwe";
            string oword = "AMOGUS";
            osave = ostr == oword ? true : false;


            //--------------------------------------------------Рандом--------------------------------------------------

            Console.WriteLine("----------Рандом----------");

            Random rnr = new Random();
            int rna = rnr.Next(50);
            Console.WriteLine(rna);
            Console.WriteLine();


            //--------------------------------------------------Циклы--------------------------------------------------

            Console.WriteLine("----------Циклы----------");

            int ca = 0, cb = 0;
            int clim = 6;

            Console.WriteLine();
            Console.WriteLine("-----While-----");

            while (clim > ca)                       //While - проверяет условие, а затем выполняет действие, до тех пор пока истино условие
            {
                ca++;
                Console.WriteLine(ca);
            }

            Console.WriteLine();
            Console.WriteLine("-----Do while-----");

            do                                      //Do while - выполняет действие, а затем проверяет условие, до тех пор пока истино условие
            {
                cb++;
                Console.WriteLine(cb);
            } while (clim > cb);

            Console.WriteLine();
            Console.WriteLine("-----For-----");

            for (int c = 0; c < clim; c++)          //For - выполняет действие, а затем проверяет условие, до тех пор пока истино условие
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();


            //--------------------------------------------------Фокусы с write--------------------------------------------------

            Console.WriteLine("----------Фокусы с write----------");
            Console.WriteLine();

            int[] mas = new int[10];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(100);
                Console.WriteLine($"Mas[{i}]= {mas[i]}");
            }
            int index = Array.FindIndex(mas, i => i == mas.Max());
            Console.WriteLine();

            Console.WriteLine("Max Mas[" + index + "]= " + mas[index]);
            Console.WriteLine();

            Console.WriteLine("Max Mas[{0}]= {1}", index, mas[index]);
            Console.WriteLine();

            Console.WriteLine($"Max Mas[{index}]= {mas[index]}");
            Console.WriteLine();


            //--------------------------------------------------Массивы--------------------------------------------------


            //                                                Одномерный массив

            /* int[] mas = new int [5] { 5, 7, 3, 4, 7 };               Объявление одномерного массива
             * int[] mas = new int [] { 5, 7, 3, 4, 7 };
             * int[] mas = { 5, 7, 3, 4, 7 };
             * int[] mas = new int[5];
             * 
             * 
             * int[] mas = new int[5];                                  Заполнение одномерного массива
             * Random r = new Random();
             * for (int i = 0; i < mass.Length; i++)
             * {
             *     mass[i] = r.Next(100);
             * }
             * 
             * 
             * Console.WriteLine(mas.Where(i => i % 2 == 0));           Чётное или не чётное (True или False)
             * Console.WriteLine(mas.Where(i => i % 2 == 0).Sum());     Сумма чётных чисел
             * 
             * int res = mas.
             * Sum();                                                   Сумма
             * Min();                                                   Мин
             * Max();                                                   Макс
             * First();                                                 Первое число
             * FirstOrDefault();                                        Первое число или дефолтное значение
             * 
             * int[] mas = Enumerable.Repeat(5, 6).ToArray();           6 раз по 5
             * int[] mas = Enumerable.Range(4,5).ToArray();             от 4 до 8
             * int[] mass = mas.ToArray();                              Копирование из одного массива в другой
             * int[] mass = mas.Distinct().ToArray();                   Уникальные числа в массиве (Убирает повторяющиеся элементы)
             * int[] mass = Array.FindAll(mas, i => i < 70);            Нахождение группы чисел по условию
             * int[] mass = mas.OrderBy(i=>1).ToArray();                Сортировка по возрастанию
             * int[] mass = mas.OrderByDescending(i=>1).ToArray();      По убыванию
             * 
             * int res =
             * Array.Find(mas, i => i < 6);                             Нахождение индекс числа по условию с начала / с конца
             * Array.FindLast(mas, i => i < 6);
             * Array.FindIndex(mas, i => i == 5);                       Поиск индекса определённого числа с начала / с конца
             * Array.FindLastIndex(mas, i => i == 5);
             * 
             * Array.Sort(mas);                                         Сортировка по возрастанию
             * Array.Reverse(mas);                                      Меняется порядок
             */


            //                                                Двумерный массив

            /*
            int[,] masbig = new int [3,5]
            int[,] masbig = new int [,]
            int[,] masbig = 
            {
             { 1, 2, 3, 4,39},
             { 32,42,33,13,23},
             { 87,42,67,88,78}
            };
            */
            Console.WriteLine("-----Двумерный массив-----");
            Console.WriteLine();
            int[,] masbig = new int [3,5];
            int height = masbig.GetLength(0);   //Длина по вертикале
            int width = masbig.GetLength(1);    //Длина по горизонтале
            
            Random ran = new Random();

            for (int y = 0; y < height; y++)    //Заполнение и вывод двумерного массива
            {
                for (int x = 0; x < width; x++)
                {
                    masbig[y, x] = ran.Next(100);
                }
            }
            
            for (int y = 0; y < height; y++) 
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(masbig[y, x] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            //                                                Зубчатый массив

            /*
            
            int[][] mas = new int [3] [];           Объявление зубчатого массива  
            mas[0] = new int [5];
            mas[1] = new int [2];
            mas[2] = new int [3];

            Random r = new Random();                Заполнение зубчатого массива

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = r.Next(10);
                }

            }
            
            */
            Console.WriteLine("-----Трёхмерный массив-----");
            Console.WriteLine();
            int[,,] masbigg = new int[3, 3, 3];

            Random rg = new Random();

            for (int i = 0; i < masbigg.GetLength(0); i++)
            {
                for (int j = 0; j < masbigg.GetLength(1); j++)
                {
                    for (int y = 0; y < masbigg.GetLength(2); y++)
                    {
                        masbigg[i, j, y] = r.Next(10, 50);
                    }
                }
            }

            for (int i = 0; i < masbigg.GetLength(0); i++)
            {
                Console.WriteLine($"Страница {i + 1}");

                for (int j = 0; j < masbigg.GetLength(1); j++)
                {
                    for (int y = 0; y < masbigg.GetLength(2); y++)
                    {
                        Console.Write(masbigg[i, j, y] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("");
            }
            Console.WriteLine();

        }


    }
}
