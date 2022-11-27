using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_autopark
{
    internal class Autopark
    {
        protected string Name {  get; set; }
        protected List<Car> Cars { get; set; }
        public Autopark(string name, List<Car> cars) 
        {
            this.Name = name;
            this.Cars = cars;
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (var car in Cars)
            {
                str+=car + "\n";
            }
            return str;
        }
    }
}
