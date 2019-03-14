using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetClassExample
{
    class SpaceShip
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public SpaceShip(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void GetShipName()
        {
            Console.WriteLine($"Ship name is: {Name}");
        }
    }
}
