using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karan_Act2
{
    class Country //base class
    {
        public string Name { get; set; }    
        public string Capital { get; set; }
        public double Population { get; set; }

        //parameterized constructor 

        public Country(string name, string capital, double population)
        {
            Name = name;
            Capital = capital;
            Population = population;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Country Name: {Name}");
            Console.WriteLine($"Capital:  {Capital}");
            Console.WriteLine($"Population: {Population}");
        }
    }

    class Asia : Country //derived class
    {
        public string Weather { get; set; }

        //parameterized constructor 

        public Asia (string name, string capital, double population, string weather) : base (name, capital, population)
        {
            Weather = weather;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n------ Country Details ------"); 
            base.DisplayInfo();
            Console.WriteLine($"Weather: {Weather}");
           
        }
    }

    class Europe : Country //derived class
    {
        string Currency { get; set; }

        //parameterized constructor 

        public Europe(string name, string capital, double population, string currency):base(name,capital,population)
        {
            Currency = currency;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n------  Country Details  ------");
            base.DisplayInfo();
            Console.WriteLine($"Currency: {Currency}");
            
        }
    }
}
