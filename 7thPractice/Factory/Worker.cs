using Models;
using System;
using System.Collections.Generic;

namespace Factory
{
    public class Worker
    {
        public Worker()
        {
        }

        public CarModel[] MakeAllCars(PlanModel[] plan)
        {
            List<CarModel> carModels = new List<CarModel>();
            foreach(var planItem in plan) {
                for(int i = 0; i < planItem.count; i++) {
                    carModels.Add(new CarModel(planItem.Color));
				}
			}
            return carModels.ToArray();
        }
    }
}
