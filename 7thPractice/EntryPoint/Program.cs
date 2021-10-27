using Factory;
using Models;
using Helpers;
using System;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            
            // создать план на 5 красных, 7 синих и 3 черных машин
            PlanModel[] planModels = new PlanModel[] { new PlanModel(5, Colors.Red), 
                                                        new PlanModel(7, Colors.Blue), 
                                                        new PlanModel(3, Colors.Black)};

            // угрожать worker и заставить его выполнить план
            CarModel[] carModels = worker.MakeAllCars(planModels);

            // осмотреть все машины и заполнить поле ColorName через метод расширения ColorExtension.BuildColorLongName(). Расширяем тип Colors
            // передавайте в него текст "Mega cool -". Результат должен быть записан в одну строку
            foreach(var carModel in carModels) {
                carModel.ColorName = carModel.Color.BuildColorLongName("Mega cool - ");
			}

            // начальство решило, что 7 синих это слишком и нужно 2 из них перекрасить в зеленые при помощи статического метода в статическом типе PaintingHelper.RepaintCar()
            for(int i = 0, toPaint = 2; i < carModels.Length && toPaint > 0; i++) {
                if (carModels[i].Color == Colors.Blue) {
                    PaintingHelper.RepaintCar(carModels[i], Colors.Green);
                    carModels[i].ColorName = carModels[i].Color.BuildColorLongName("Mega cool - ");
                    toPaint--;
				}
			}

            // вывести на консоль все машины так -> "Цвет машины -> ColorName". ColorName это переменная, так что вставляем ее значение
            foreach(var car in carModels) {
                Console.WriteLine($"Цвет машины -> {car.ColorName}");
			}
        }
    }
}
