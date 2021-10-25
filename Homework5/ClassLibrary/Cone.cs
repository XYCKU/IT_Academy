using System;

namespace ClassLibrary
{
	public class Cone
	{
		const float PI = 3.14f;
		float radius, height, length;
		public Cone(float radius = 0f, float height = 0f)
		{
			this.radius = radius;
			this.height = height;
			length = (float)Math.Sqrt((double)(radius * radius + height * height));
		}
		public float GetBasementSquare()
		{
			return radius * radius * PI;
		}
		public float GetFullSquare()
		{
			return GetBasementSquare() + PI * radius * length;
		}
	}
}
