using System;
namespace Zdarzenia
{
    class TestowanieZdarzen
    {
        public int value;
        // Deklaracja delegata
        public delegate void NumberManipulationHandler();
        // Deklaracja zdarzenia
        public event NumberManipulationHandler ChangeNumber;
        // Metoda aktwyująca zdarzenie
        protected virtual void OnNumberChanged()
        {
            if (ChangeNumber != null)
                ChangeNumber();
            else
                Console.WriteLine("Zdarzenie!");
        }
        public TestowanieZdarzen(int i)
        {
            SetValue(i);
        }
        // Ustawianie wartości dla liczb
        // Jeżeli podana liczba jest różna od liczby aktualnej
        // wywołujemy metodę związaną ze zmianą liczby
        public void SetValue(int i)
        {
            if (value != i)
            {
                value = i;
                OnNumberChanged();
            }
        }
        static void Main(string[] args)
        {
            TestowanieZdarzen tz = new TestowanieZdarzen(5);
            tz.SetValue(8);
            tz.SetValue(16);
            Console.ReadKey();
            // Wynik działania programu
            // Zdarzenie!
            // Zdarzenie!
            // Zdarzenie!
        }
    }
}