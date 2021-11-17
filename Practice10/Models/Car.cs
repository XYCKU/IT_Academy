using System;

namespace Models
{
	public class Car : IComparable<Car>
	{
		public int Speed { get; set; }
		public int Year { get; set; }
		public string Move()
		{
			return "driving";
		}

		public int CompareTo(Car other)
		{
			int result = Speed.CompareTo(other.Speed);
			if (result == 0) {
				return Year.CompareTo(other.Year);
			}
			return result;
		}

	}
}
