using System;
using System.Collections.Generic;
using System.Linq;

namespace MainEntities
{
	public class Worker
	{
		private Hammer hammer;
		private List<Nail> nails;
		public Worker(Hammer hammer, List<Nail> nails)
		{
			this.hammer = hammer;
			this.nails = nails;
		}
		public Worker(Hammer hammer, Nail[] nails) : this(hammer, nails.ToList()) { }
		public void HammerAllNails()
		{
			while (nails.Count > 0) {
				HammerNail();
			}
			Console.WriteLine("Everything is done!");
		}
		public void HammerNail()
		{
			if (nails.Count == 0) return;
			Nail nail = nails[0];
			while (nail.HitsToNail > 0) {
				hammer.Hit(nails[0]);
				Console.WriteLine("A hit!");
			}
			nails.RemoveAt(0);
			Console.WriteLine("Nailed one!");
		}
	}
}