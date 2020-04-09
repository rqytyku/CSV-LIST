using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_LIST
{
    class Country
    {
        public string name { get; }
        public string code { get; }
        public string region { get; }
        public int population { get; }



        public Country(string name, string code, string region, int population)
        {
            this.name = name;
            this.code = code;
            this.region = region;
            this.population = population;
        }
    }
}
