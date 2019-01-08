using System;
using System.Collections.Generic;
using System.Text;

namespace AllergiesWithDictionary
{

    public class Allergies
    {
        public Dictionary<string, int> allergens = new Dictionary<string, int>()
        {{"eggs", 1},
         { "peanuts", 2},
         { "shelfish", 4},
         { "strawberries", 8},
         { "tomatoes", 16},
         { "chocolate", 32},
         { "pollen", 64},
         { "cats", 128}};

        private string name;
        private int score;
        public string Name
        {
            get { return this.name; }
        }

        public Allergies(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public void GetAllergens()
        {
            int indice = this.score;
            if (this.score >= 256)
            {
                Console.WriteLine($" {this.Name} is alergic to eggs.");
            }
            else
            {
                Console.WriteLine(this.Name + " is alergic to: ");
                while (indice >= 1)
                {
                    int min = 0;
                    string wanted = "";
                    foreach (var pair in allergens)
                    {
                    //Console.WriteLine("val:  " + pair.Value + "minim: " + min + "indice: " + indice);
                        if (pair.Value > min && pair.Value <= indice)
                        {
                            wanted = pair.Key;
                            min = pair.Value;
                        }
                    }
                    Console.Write(wanted + " ");
                    indice -= min;
                }
            }
        }
    }
}

