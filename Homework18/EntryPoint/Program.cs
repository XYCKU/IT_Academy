using System;
using System.Collections.Generic;
using System.Linq;

namespace EntryPoint
{
    internal class Program
    {
        public enum Ranks
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        public enum Suits {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public struct Card
        {
            public Suits suit;
            public Ranks rank;
        }
        static string Task1(string str, char c)
        {
            var query = str.Split(' ').Where(x => x.EndsWith(c)).ToArray();
            return (query.Length <= 1)? (query.Length == 1)? query[0] : null : throw new Exception("Multiple words");
        }
        static void Task2(IEnumerable<int> collection)
        {
            var newCollection = collection.Where(x => x > 0);
            int sum = newCollection.Sum();
            int amount = newCollection.Count();
            Console.WriteLine($"Amount: {amount}, Average: {(double)sum / amount}");
        }
        static string Task3(string str)
        {
            return new string(str.Where(x => x != 'о').ToArray());
        }
        /*Дана колода карт, разделить ее пополам и найти карты с одинаковой мастью в двух колодах, 
         вернуть в виде: $"{Suit} ({Rank1}, {Rank2})"*/
        static void Task4(IEnumerable<Card> deck)
        {
            int amount = deck.Count() / 2;
            var top = deck.Take(amount);
            var bottom = deck.Skip(amount / 2);
            var result = from card in top
                         join card2 in bottom
                         on card.suit equals card2.suit
                         select new { Suit = card.suit, Rank1 = card.rank, Rank2 = card2.rank };
            
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Suit} ({item.Rank1}, {item.Rank2})");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Task1("I'm just a random string", 't'));
            Task2(new int[]{ 5, 8, 0, -1, 6, 4, -1, -3 });
            Console.WriteLine(Task3("Женя скоро будет свободен, а у вас все только начинается"));

        }
    }
}
