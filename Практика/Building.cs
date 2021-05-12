using System;
using System.Collections.Generic;
using System.Text;

namespace Практика
{
    class Building
    {
        object Image;
        string Name;
        //int Lvl_to_build;
        string Rarity;
        bool Mythical;
        //int Lvl;
        List<Characteristic> сharacteristic;

        public Building(object Image,
        string Name,
        string Rarity,
        bool Mythical,
        //int Lvl,
        List<Characteristic> сharacteristic
            ) {
            this.Image = Image;
            this.Name = Name;
            this.Rarity = Rarity;
            this.Mythical = Mythical;
            //this.Lvl = Lvl;
            this.сharacteristic = сharacteristic;
        }

        public void viv()
        {
            Console.WriteLine("image");
            Console.WriteLine(Name);
            Console.WriteLine(Rarity);
            Console.WriteLine(Mythical);

        }
    }
}
