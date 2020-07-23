using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan (zmienne - pola)
        List<float> ratings;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }


                    _name = value;
                }
            }
        }
        // Zdarzenie

        public event NameChangedDelegate NameChanged;


        //Zachowania
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
            
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

       
