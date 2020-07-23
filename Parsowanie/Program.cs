using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Parsowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int ops1;
            ChooseIterations(out result, out ops1);

            if (result == true)
            {
                for (int i = 0; i <= ops1; i++)
                {
                    string[] numbers = TakeNumbers();

                    int[] num = new int[2];

                    ParseIntNumbers(numbers, num);

                    for (int i1 = 0; i1 < 5; i1++)
                    {
                        Console.WriteLine("Jesli chcesz: dodawac - nacisnij 1, odejmowac - nacisnij 2, mnozyc - nacisnij 3, dzielić - 4");
                        string action = Console.ReadLine();

                        if (action == "1" || action == "2" || action == "3" || action == "4")
                        {
                            if (action == "1")
                            {
                                int addition = num.Sum();
                                Console.WriteLine("suma podanych liczb to: " + addition);
                                Console.ReadKey();
                                break;
                            }
                            if (action == "2")
                            {
                                int subtracition = num[0] - num[1];
                                Console.WriteLine("roznica podanych liczb to: " + subtracition);
                                Console.ReadKey();
                                break;
                            }
                            if (action == "3")
                            {
                                int multiplication = num[0] * num[1];
                                Console.WriteLine("iloczyn podanych liczb to: " + multiplication);
                                Console.ReadKey();
                                break;
                            }
                            if (action == "4")
                            {
                                float[] numf = new float[2];
                                for (int i2 = 0; i2 < 2; ++i2)
                                {
                                    numf[i2] = (float)num[i2];
                                }
                                float division = numf[0] / numf[1];
                                Console.WriteLine("iloraz podanych liczb to: " + division);
                                Console.ReadKey();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("taka opcja nie isnieje, sprobój jeszcze raz");
                            Console.ReadKey();
                        }
                    }
                    //Console.ReadKey();
                    //Console.Clear();
                }
            }
            else
            {

            }

        }

        private static void ParseIntNumbers(string[] numbers, int[] num)
        {
            bool result1 = int.TryParse(numbers[0], out num[0]);
            int.TryParse(numbers[1], out num[1]);
        }

        private static string[] TakeNumbers()
        {
            Console.WriteLine("wprowadź 2 liczby całkowite");

            string[] numbers = new string[2];

            numbers[0] = Console.ReadLine();
            numbers[1] = Console.ReadLine();
            return numbers;
        }

        private static void ChooseIterations(out bool result, out int ops1)
        {
            Console.WriteLine("ile operacji chcesz wykonac");
            string ops = Console.ReadLine();
            result = int.TryParse(ops, out ops1);
        }
    }
}
