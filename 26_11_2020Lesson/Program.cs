using System;

namespace _26_11_2020Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5, num2 = 10, num3 = 21; // вывести на экран три числа в столбец
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            int metr;  // Найти число полных метров
            Console.Write("Введите расстояние в см: ");
            metr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + (metr / 100) + " метр");


            int days = 234;  // Прошло 234 дня, найти количество полных недель
            Console.WriteLine("Всего прошло 234 дня а это: " + (days / 7) + " недели");


            // Дано двузначное число
            int numer;            
            Console.Write("Введите двухзначное число: ");
            numer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число единиц: " + int.Parse(Console.ReadLine()) % 10);
            Console.WriteLine("Сумма цифр числа " + numer + " составляет: " + ((numer % 10) + (numer / 10)));


            // Известны сопротивления R(Ом) двух несоединенных друг с другом участков электрической цепи и напряжение U (В) 
            // на каждом из них. По какому участку протекает меньший ток (сила тока I(А)?
            double U1 = 220, U2 = 380;
            double R1 = 7.2, R2 = 6.5;
            double I = U1 / R1, I2 = U2 / R2;
            Console.WriteLine("Сопротивление первой электрической цепи 7,2 Ом, на второй цепи 5,5 Ом ");
            Console.WriteLine("Напряжение первой эл цепи 220 вольт, на второй цепи 380 вольт ");
            if (I < I2)
            {
                Console.WriteLine("На участке первой электрической цепи ток меньший и составляет = " + I);
            }
            else
            {
                Console.WriteLine("На участке второй электрической цепи ток меньший и составляет = " + I2);
            }


            // Даны объемы V и массы M двух тел из разных материалов. Материал какого из тел имеет большую плотность P?
            double V1 = 50, V2 = 80;
            double M1 = 15, M2 = 11;
            double P = V1 / M1, P2 = V2 / M2;
            Console.WriteLine("Объем первого тела 50 см куб, второго 80 см куб");
            Console.WriteLine("Масса первого тела 15 кг, второго 11 кг");
            if (P < P2)
            {
                Console.WriteLine("Плотность первого тела меньше и составляет = " + P);
            }
            else
            {
                Console.WriteLine("Плотность первого тела меньше и составляет = " + P2);
            }




            Console.ReadKey();
        }
    }
}
