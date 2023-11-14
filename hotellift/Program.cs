using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace hotellift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lift> lifts = new List<Lift>();

            StreamReader sr = new StreamReader("lift.txt");

            while (!sr.EndOfStream)
            {
                Lift lift = new Lift(sr.ReadLine());
                lifts.Add(lift);
            }

            sr.Close();

            Console.WriteLine($"3. feladat: Összes lifthasználat: {lifts.Count()}");
            Console.WriteLine($"4. feladat: Időszak: {lifts.Min(x => x.Usage).Date} - {lifts.Max(x => x.Usage).Date}");
            Console.WriteLine($"5. feladat: Célszint max: {lifts.Max(x => x.EndNumber)}");
            Console.WriteLine("6. feladat:");
            int cardNumber;
            int endNumber;
            try
            {
                Console.Write("\tKártya száma: ");
                cardNumber = int.Parse(Console.ReadLine());
                Console.Write("\tCélszint száma: ");
                endNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                cardNumber = 5;
                endNumber = 5;
            }

            Console.WriteLine($"A(z) {lifts.Where(x => x.CardNumber == cardNumber).First().CardNumber}. kártyával nem utaztak a {lifts.Where(x => x.EndNumber == endNumber).First().EndNumber}. emeletre!");

            Console.WriteLine("8. feladat: Statisztika");
            lifts.GroupBy(x => x.Usage).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}x"));

        }
    }
}
