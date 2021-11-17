using System;
using Entities;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			TransportRentalService rent = new TransportRentalService();
			Car car = rent.GiveTransport<Car>();
			Boat boat = rent.GiveTransport<Boat>();

			Person p = new Person(car);
			Console.WriteLine(p.Go());
			
			p.ChangeVehicle(boat);
			Console.WriteLine(p.Go());
		}
	}
}