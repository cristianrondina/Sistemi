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
            for (int i = 0; i < DecimalePuntato.Length; i++) //for che fa inserire il numero decimale puntato
            {
                Console.WriteLine("Inserisci cifra:");
                DecimalePuntato[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n1° Metodo:"); // Metodo 1
            bin = Convert_Dp_To_Bin(DecimalePuntato);//Invoco primo metodo
            for (int i = 0; i < bin.Length; i++)
            {
                Console.Write(Convert.ToInt32(bin[i]));
            }

            Console.WriteLine("\n\n2° Metodo:");//Metodo 2
            Console.WriteLine(Convert_Dp_To_Intero(DecimalePuntato));//Invoco secondo metodo

            Console.WriteLine("\n3° Metodo:");//Metodo 3
            Console.WriteLine(Convert_Bin_To_Intero(bin));//Invoco terzo metodo

            Console.WriteLine("\n4° Metodo:");//Metodo 4
            Console.WriteLine(ConvertBinToDec(bin));//Invoco quarto metodo

            Console.ReadLine();

        }
        static bool[] Convert_Dp_To_Bin(int[] DecimalePuntato)//Metodo n°1 (Converte da decimale puntato a binario)
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
        static int Convert_Dp_To_Intero(int[] DecimalePuntato) //Metodo n°2 (Converte da decimale puntato a intero)
        {
            int x = 3;
            int num = 0;

            for (int i = 0; i < DecimalePuntato.Length; i++)
            {
                num = num + DecimalePuntato[i] * (int)Math.Pow(256, x--);
            }
            return num;
        }
        static int Convert_Bin_To_Intero(bool[] bin) //Metodo 3 (Converte da binario a intero)
        {
            int x = bin.Length - 1;
            int intero = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i])
                {
                    intero += (int)Math.Pow(2, x);
                }
                x--;
            }
            return intero;
        }
        static int ConvertBinToDec(bool[] bin) //Metodo 4 (Converte da binario a intero)
        {
            int decimale = 0;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i])
                {
                    decimale += (int)Math.Pow(2, bin.Length - 1 - i);
                }
            }
            return decimale;
        }
    }
}
