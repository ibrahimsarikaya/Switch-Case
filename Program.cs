using System;

namespace Switch_Case // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız.");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayındasınız.");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                break;
            }
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                 Console.WriteLine("İlkbahardasınız");
                 break;
                default:
                break;
            }
        }
    }
}