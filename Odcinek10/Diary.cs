using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne - pola)
        List<float> ratings;
        //Zachowania
        /// <summary>
        /// Dodaje ocene
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Liczy srednia z ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }
        /// <summary>
        /// Pobiera najwyzsza ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        /// <summary>
        /// Pobiera najnizsza ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
