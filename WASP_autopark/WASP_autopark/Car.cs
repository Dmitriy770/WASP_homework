using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_autopark
{   
    internal class Car
    {
        protected String Brand { get; set; }
        protected int Power { get; set; }
        protected int Year { get; set; }

        public Car(string brand, int power, int year)
        {
            Brand = brand;
            Power = power;
            Year = year;
        }

        public override string ToString()
        {
            return $"Модель: {Brand}, мощность: {Power}, год выпуска: {Year}";
        }
    }
}
