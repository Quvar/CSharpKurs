using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            diary.NameChanged += OnNameChange;
            diary.NameChanged += OnNameChange2;
            diary.NameChanged += OnNameChange3;
            diary.NameChanged += OnNameChange4;

            diary.Name = "dziennik marcina";
            diary.Name = "jacek hej";

            Console.WriteLine(diary.Name);

            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //DiaryStatistics stats = diary.ComputeStatistics();

            //Console.WriteLine("Srednia ocena to: " + stats.AverageGrade);
            //Console.WriteLine("Najwyzsza ocena to: " + stats.MaxGrade);
            //Console.WriteLine("Najnizsza ocena to: " + stats.MinGrade);

            //Diary diary2 = new Diary();

            //diary2.AddRating(5);
            //diary2.AddRating(2.5f);
            //diary2.AddRating(4.7f);
            //diary2.AddRating(6);
            //diary2.AddRating(2);
            //diary2.AddRating(7.7f);


            //stats = diary2.ComputeStatistics();

            //Console.WriteLine("Srednia ocena to: " + stats.AverageGrade);
            //Console.WriteLine("Najwyzsza ocena to: " + stats.MaxGrade);
            //Console.WriteLine("Najnizsza ocena to: " + stats.MinGrade);

            //SpeechSynthesizer synt = new SpeechSynthesizer();
            //synt.Speak("Najnizsza ocena to: " + stats.MinGrade);


            Console.ReadKey();
        }

        private static void OnNameChange(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }
        private static void OnNameChange2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***************");
        }
        private static void OnNameChange3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Hello");
        }
        private static void OnNameChange4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("+++++++++++++++++");
        }
    }
}
