using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            Count++;
        }
        //Stan (zmienne - pola)
        List<float> ratings;

        public static float MinGrade = 0;
        public static float MaxGrade = 10;
        public static long Count = 0;
        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }



        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}

       
