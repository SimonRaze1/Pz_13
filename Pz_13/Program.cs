using System.ComponentModel.Design;

namespace PZ_13
{
    internal class Program
    {

        static void Main(string[] args)// Задание номер 1
        {
            /*
                Console.WriteLine("Введите порядковый номер числа: ");
                double n = Convert.ToDouble(Console.ReadLine());
                double a = 3.3
                double b = 0.3
                double result = Regress(n, a, b);
                Console.WriteLine($"{n} член прогрессия равен {a}");


            static double Regress(double n, double a, double b) 
            {
                if (n == 1) 
                {
                    Console.WriteLine($"{n} Член прогресси равен {a}");
                }
                else
                {
                    a += b;
                }
                return Regress(n - 1, a, b);
            }


                Console.WriteLine("Введите порядковый номер числа: ");
                double n = Convert.ToDouble(Console.ReadLine());
                double b = 1
                double q = 2
                double result = RegressDel(n, b, q);
                Console.WriteLine($"{n} Член прогрессии равен {result}");
            

            int a = 88
            int b =  -100
            if (a < b)
            {
                RegressSum(a, b);
            }
            else
            {
                RegressSum1(a, b);
            }
            */


        }
        static double RegressDel(double n, double b, double q)
        {
            if (n == 1)
            {
                Console.WriteLine($"{n} Член прогрессии равен {b}");
            }
            else
            {
                b /= q;
            }
            return RegressDel(n - 1, b, q);
        }

        static void RegressSum(double a, double b)
        {
            if (a < b)
            {

                Console.WriteLine(a);
                a++;
                RegressSum(a, b);
            }
        }

        static void RegressSum1(double a, double b)
        {
            if (a > b)
            {
                a--;
                Console.WriteLine(a);
                RegressSum1(a, b);
            }
        }













    }
}