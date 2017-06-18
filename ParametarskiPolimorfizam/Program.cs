using System;

namespace ParametarskiPolimorfizam
{
    class MojTip<T>
    {
        public MojTip(T vrijednost)
        {
            this.vrijednost = vrijednost;
        }

        public MojTip<U> Promijeni<U>(Func<T, U> funkcija)
        {
            return new MojTip<U>(funkcija(vrijednost));
        }
        // dodano radi jednostavnijeg ispisa
        public override string ToString()
        {
            return vrijednost.ToString();
        }

        public readonly T vrijednost;
    }

    class Program
    {

        static void Main(string[] args)
        {
            var a = new MojTip<int>(5);
            Console.WriteLine(a);
            var b = a.Promijeni(v => v * 0.5);
            Console.WriteLine(b);
            var c = a.Promijeni(v => Enum.ToObject(typeof(DayOfWeek), v));
            Console.WriteLine(c);
        }
    }
}
