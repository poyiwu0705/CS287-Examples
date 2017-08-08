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
            int nationalNo = 001;
            string Type = "GRASS,POISON";
            string Species = "Seed Pokémon";
            string Height = "2′4″ (0.71m)";
            string Weight = "15.2 lbs (6.9 kg)";
            string Abilities = "Overgrow, Chlorophyll(hidden ability)";
            string LocalNo = @"001 (Red/Blue/Yellow/FireRed/LeafGreen)
         226 (Gold/Silver/Crystal)
         231 (HeartGold/SoulSilver)
         080 (X/Y)";
            string Japanese = "Fushigidane";

            Console.WriteLine("Pokemon Name: {0}", name);
            Console.WriteLine("National No: {0}", nationalNo);
            Console.WriteLine("Type {0}", Type);
            Console.WriteLine("Species: {0}", Species);
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Weight: {0}", Weight);
            Console.WriteLine("Abilities: {0}", Abilities);
            Console.WriteLine("LocalNo: {0}", LocalNo);
            Console.WriteLine("Japanese: {0}", Japanese);
        }
    }
}