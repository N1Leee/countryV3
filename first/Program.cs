using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("1", "1", 1f);
        }

        public class Country
        {
            public string Name { get; set; }
            public string FormOfGovernment { get; set; }
            public float Square { get; set; }

            public Country(string name, string formOfGovernment, float square)
            {
                Name = name;
                FormOfGovernment = formOfGovernment;
                Square = square;
            }
        }
    }
}
