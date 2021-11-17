using System;

namespace Entities
{
	public class TransportRentalService
	{
		public T GiveTransport<T>() where T : Transport, new()
		{
			return new T();
		}
	}
}
