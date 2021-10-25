using System;
using System.Collections.Generic;
using MainEntities;

namespace Task1
{
	class Program
	{ 
		static void Main(string[] args)
		{
			List<Nail> nailList = new List<Nail>() { new Nail(), new Nail() };
			Nail[] nails = new Nail[new Random().Next(0, 10) + 1];
			for(int i = 0; i < nails.Length; i++) {
				nails[i] = new Nail();
			}
			Hammer magicHammer = new Hammer();
			Worker worker = new Worker(magicHammer, nails);
			worker.HammerAllNails();
		}
	}
}
