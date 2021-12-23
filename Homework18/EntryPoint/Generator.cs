using System;
using System.Collections.Generic;
using System.Linq;
using EntryPoint.Enums;

namespace EntryPoint
{
    public static class Generator
    {
        private static readonly int amount = 36;
        public static IEnumerable<Card> Generate()
        {
            var cards = from suit in (Suits[])Enum.GetValues(typeof(Suits))
                        from rank in (Ranks[])Enum.GetValues(typeof(Ranks))
                        select new Card { suit = suit, rank = rank };
            return cards.OrderBy(x => Guid.NewGuid()).ToArray();
        }
    }
}
