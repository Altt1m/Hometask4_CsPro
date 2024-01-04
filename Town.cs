using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    internal class Town
    {
        public string Name { get; set; }
        private int Population { get; set; }

        public Town(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static Town operator +(Town town, int amount)
        {
            town.Population += amount;
            return town;
        }

        public static Town operator -(Town town, int amount)
        {
            town.Population -= amount;
            return town;
        }

        public static bool operator ==(Town town1, Town town2)
        {
            return town1.Population == town2.Population;
        }

        public static bool operator !=(Town town1, Town town2)
        {
            return !(town1 == town2);
        }

        public static bool operator <(Town town1, Town town2)
        {
            return town1.Population < town2.Population;
        }

        public static bool operator >(Town town1, Town town2)
        {
            return town1.Population > town2.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj is Town)
            {
                Town other = (Town)obj;
                return Population == other.Population;
            }
            return false;
        }
    }
}
