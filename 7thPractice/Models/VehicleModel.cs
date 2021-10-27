
namespace Models
{
    public abstract class VehicleModel
    {
        protected abstract int WheelCount { get; set; }
        public Colors Color { get; protected set; }
        public string ColorName { get; set; }

        public VehicleModel(Colors color)
        {
            Color = color;
        }
    }
}
