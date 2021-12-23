using System;
using System.Collections.Generic;
using System.Linq;
using EntryPoint.Enums;

namespace EntryPoint
{
    internal class Program
    {
        
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
        /*Дана колода карт, разделить ее пополам и найти карты с одинаковой значимостью в двух колодах, 
         вернуть в виде: $"{Rank} ({Suit1}, {Suit2})"*/
        static void Task4(IEnumerable<Card> deck)
        {
            int amount = deck.Count() / 2;
            var top = deck.Take(amount);
            var bottom = deck.Skip(amount);

            var result = from card in top.GroupBy(x => x.rank)
                         join card2 in bottom
                         on card.Key equals card2.rank
                         select new { Rank = card.First().rank, Suit1 = card.First().suit, Suit2 = card2.suit};
            
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Rank} ({item.Suit1}, {item.Suit2})");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Task1("I'm just a random string", 't'));
            Console.WriteLine();
            Task2(new int[]{ 5, 8, 0, -1, 6, 4, -1, -3 });
            Console.WriteLine();
            Console.WriteLine(Task3("Женя скоро будет свободен, а у вас все только начинается"));
            Console.WriteLine();
            Task4(Generator.Generate());
        }
    }
}
