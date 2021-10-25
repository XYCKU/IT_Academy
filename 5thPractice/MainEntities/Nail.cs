using System;

namespace MainEntities
{
	public class Nail
	{
		private static Random random = new Random();
		public int HitsToNail { get; private set; }
		public Nail(int minHits = 1, int maxHits = 6)
		{
			HitsToNail = random.Next(minHits, maxHits);
		}
		public void TakeHit()
		{
			HitsToNail--;
		}
	}
}
