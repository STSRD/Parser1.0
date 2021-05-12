using System;
using System.Collections.Generic;
using System.Text;

namespace Практика
{
    class Races
    {
        string name;
        List<Building> buildings = new List<Building>();

        public Races(string name, List<Building> buildings) {
            this.name = name;
            this.buildings = buildings;
        }

        public void viv() {
            Console.WriteLine(name);
            foreach (var item in buildings)
            {
                item.viv();
                Console.WriteLine();
            }
        }
    }
}
