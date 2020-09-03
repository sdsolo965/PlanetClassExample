using System;
using System.Collections.Generic;

namespace PlanetClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceShip ship1 = new SpaceShip("Enterprise", "Flacon Heavy");

            SpaceShip ship2 = new SpaceShip("Apollo", "Falcon Light");

            List<SpaceShip> shipList = new List<SpaceShip>();

            shipList.Add(ship1);
            shipList.Add(ship2);

            foreach (var ship in shipList)
            {
                Console.WriteLine($"Ship name is: {ship.Name}");
                Console.WriteLine($"Ship type is: {ship.Type}");

            }

            ship1.GetShipName();

            ship2.GetShipName();
        }


        public void NewMethod()
        {
            System.Console.WriteLine("Does something cool!");
        }
    }
}
