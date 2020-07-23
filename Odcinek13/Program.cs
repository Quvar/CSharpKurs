using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDiary;

namespace Odcinek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diary.MaxGrade);


            Diary diary = new Diary();
            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();

            Console.WriteLine(Diary.Count);
        }
    }
}
