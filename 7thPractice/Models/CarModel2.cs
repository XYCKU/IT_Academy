using System;

namespace Models
{
	public partial class CarModel : VehicleModel
	{
		protected override int WheelCount { get; set; }
		public CarModel(Colors color) : base(color) { }
		public void SetColor(Colors newColor)
		{
			Color = newColor;
		}
	}
}
