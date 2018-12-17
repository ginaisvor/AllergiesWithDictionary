using System;
using System.Collections.Generic;

namespace AllergiesWithDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Allergies obj = new Allergies("Gina", 31);
            obj.GetAllergens();
        }
    }
}
