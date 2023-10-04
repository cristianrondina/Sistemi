using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioniDecimalePuntato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] DecimalePuntato = new int[4];
            bool[] bin;
            for (int i = 0; i < DecimalePuntato.Length; i++)
            {
                Console.WriteLine("Inserisci cifra:");
                DecimalePuntato[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n1° Metodo:");
            bin = Convert_Dp_To_Bin(DecimalePuntato);
            for (int i = 0; i < bin.Length; i++)
            {
                Console.Write(Convert.ToInt32(bin[i]));
            }
            Console.WriteLine("\n1° Metodo:");
            Console.WriteLine(Convert_Dp_To_Intero(DecimalePuntato));
            Console.ReadLine();

        }
        static bool[] Convert_Dp_To_Bin(int[] DecimalePuntato)//Metodo n°1
        {
            bool[] bin = new bool[32];
            int x = bin.Length - 1;

            for (int i = 0; i < DecimalePuntato.Length; i++)
            {
                int num = DecimalePuntato[i];
                for (int y = 0; y < 8; y++)
                {
                    bin[x] = num % 2 == 1;
                    num = num / 2;
                    x--;
                }
            }
            return bin;
        }
        static int Convert_Dp_To_Intero(int[] DecimalePuntato) //Metodo n°2
        {
            int x = 3;
            int num = 0;

            for (int i = 0; i < DecimalePuntato.Length;i++)
            {
                num = num + DecimalePuntato[i] * (int)Math.Pow(256, x--);
            }
            return num;
        }
    }
}
