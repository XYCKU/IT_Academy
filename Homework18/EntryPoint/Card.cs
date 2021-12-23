using System;
using EntryPoint.Enums;

namespace EntryPoint
{
    public struct Card
    {
        public Suits suit;
        public Ranks rank;
        public static bool operator==(Card lhs, Card rhs)
        {
            return lhs.suit == rhs.suit && lhs.rank == rhs.rank;
        }
        public static bool operator!=(Card lhs, Card rhs)
        {
            return !(lhs == rhs);
        }
        public override string ToString() => $"{suit} {rank}";
    }
}
