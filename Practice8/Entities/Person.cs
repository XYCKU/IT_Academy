using System;

namespace Entities
{
	public class Person
	{
		Transport vehicle;
		public Person(Transport vehicle)
		{
			this.vehicle = vehicle;
		}
		public string Go()
		{
			return vehicle.Move();
		}
		public void ChangeVehicle(Transport newVehicle)
		{
			vehicle = newVehicle;
		}
	}
}
