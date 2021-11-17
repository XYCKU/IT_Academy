using System;

namespace Entities
{
	public abstract class Transport : IMove
	{
		public virtual string Move()
		{
			return "abstract moving";
		}
	}
}
