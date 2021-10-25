using System;

namespace MainEntities
{
	public class Hammer
	{
		public void Hit(Nail nail)
		{
			nail.TakeHit();
		} 
	}
}
