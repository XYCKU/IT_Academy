using Models;
using System;

namespace Helpers
{
    public static class PaintingHelper
    {
        public static void RepaintCar(CarModel car, Colors color)
        {
            car.SetColor(color);
        }
    }
}
