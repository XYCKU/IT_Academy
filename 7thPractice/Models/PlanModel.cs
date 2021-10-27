
namespace Models
{
    public class PlanModel
    {
        public readonly int count;
        public Colors Color { get; private set; }

        public PlanModel(int count, Colors color)
        {
            this.count = count;
            Color = color;
        }
    }
}
