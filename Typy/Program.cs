using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void GiveName(Diary diary)
        {
            diary = new Diary();
            diary.Name = "nowy dzienniczek marcina";
        }

        static int IncrementNumber(int number)
        {
            number += 1;
            return number;
        }
        static void Main(string[] args)
        {
            //PassByValueAndRef();

            //Immutable();

            Arrays();

        }

        private static void Arrays()
        {
            float[] ratings;
            ratings = new float[4];

            AddRatings(ratings);

            foreach (var rating in ratings)
            {
                Console.WriteLine(rating);
            }

        }

        private static void AddRatings(float[] ratings)
        {
            if (ratings.Length >= 4) 
            {
                ratings[0] = 4.2f;
                ratings[1] = 6.7f;
                ratings[2] = 3;
                ratings[3] = 8.5f;
            }
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(45);

            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(d2);

            Console.WriteLine(d2.Name);

            int x1 = 4;
            x1 = IncrementNumber(x1);

            Console.WriteLine(x1);
        }
    }
}
