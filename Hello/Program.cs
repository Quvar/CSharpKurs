using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zależny od wieku użytkownika
        /// </summary>
        private static void Age()
        {
            Console.Write("Ile masz lat? ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni i możesz napić się piwa");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś nieprawidłowy wiek!!");
            }
            else
            {
                Console.WriteLine("Przykro nam, możemy zaoferować ci tylko mleko");
            }
        }
        /// <summary>
        /// Witamy użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
