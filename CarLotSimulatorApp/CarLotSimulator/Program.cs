using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() DONE
            //The methods should take one string parameter: the respective noise property DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car DONE
            Car car1 = new Car();
            car1.Make = "Tesla";
            car1.Model = "CyberTruck";
            car1.Year = 2025;
            car1.isDriveable = true;
            car1.EngineNoise("whoosh");
            car1.HonkNoise("ZAP");

            Car car2 = new Car();
            car2.Make = "Nissan";
            car2.Model = "Skyline";
            car2.Year = 1993;
            car2.isDriveable = false;
            car2.EngineNoise("VROOM VROOM");
            car2.HonkNoise("BEEEEEP");

            Car car3 = new Car();
            car3.Make = "Kia";
            car3.Model = "Sportage";
            car3.Year = 2023;
            car3.isDriveable = true;
            car3.EngineNoise("woom woom");
            car3.HonkNoise("meep meep");

            CarLot carLot = new CarLot();
            carLot.carList.Add(car1);
            carLot.carList.Add(car2);
            carLot.carList.Add(car3);

            for (var i = 0; i < carLot.carList.Count; i++)
            {
                var Year = carLot.carList[i].Year;
                var Make = carLot.carList[i].Make;
                var Model = carLot.carList[i].Model;
                Console.WriteLine($"{Year} {Make} {Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
