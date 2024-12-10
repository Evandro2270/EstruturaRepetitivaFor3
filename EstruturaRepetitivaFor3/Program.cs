using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
             
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] line = Console.ReadLine().Split(' ');
                    double a = double.Parse(line[0], CI);   
                    double b = double.Parse(line[1], CI);
                    double c = double.Parse(line[2], CI);

                    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                    Console.WriteLine(media.ToString("F1", CI));
                }


            }
        }
    }
}