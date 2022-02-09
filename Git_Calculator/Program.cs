using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány db számot szeretnél összeadni?");

            int N = int.Parse(Console.ReadLine());

            int[] szamtomb = new int[N];

            int sum = 0;
            int kulonbseg = 0;

            for (int i = 0; i < N; i++)
            {
                szamtomb[i] = int.Parse(Console.ReadLine());
                sum += szamtomb[i];
                kulonbseg -= szamtomb[i];
            }

            Console.WriteLine("A számok összege "+sum+"");
            Console.WriteLine($" A számok különbsége: {kulonbseg}");
        }
    }
}
