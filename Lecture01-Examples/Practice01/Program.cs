using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Bulbasaur";
            int nationalNo = 1;
            string Species = "Seed Pokémon";
            double Height = 0.71;
            double Weight = 6.9;
            string Abilities = "Overgrow Chlorophyll(hidden ability)";
            string LocalNO = "001 (Red/Blue/Yellow/FireRed/LeafGreen)";
            string Japanese = "Fushigidane";

            float Height = 0.71f;

            Console.WriteLine("Pokemon Name: {0}", name);
            Console.WriteLine("National No: {0}", nationalNo);
            Console.WriteLine("Species: {0}", Species);
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Weight: {0}", Weight);
            Console.WriteLine("Abilities: {0}", Abilities);
            Console.WriteLine("Local №: {0}", LocalNO);
            Console.WriteLine("Japanese: {0}", Japanese);
        }
    }
}