using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP_autopark
{
    internal class Truck : Car
    {
        protected int LoadCapacity { get; set; }
        protected string Name { get; set; }
        protected Dictionary<string, int> _cargo;


        public Truck(string brand, int power, int year, string name, int lodaCacity) : base(brand, power, year)
        {
            Name = name;
            LoadCapacity = lodaCacity;
        }

        protected void addCargo(String cargo, int weight)
        {
            _cargo[cargo] = weight;
        }

        protected void removeCargo(String cargo)
        {
            _cargo.Remove(cargo);
        }

        protected void printCargo()
        {
            foreach (var part in _cargo)
            {
                Console.WriteLine($"Груз: {part.Key}, вес: {part.Value}");
            }
        }
          
        public override string ToString()
        {
            return $"Модель: {Brand}, мощность: {Power}, год выпуска: {Year}, грузоподьемность: {LoadCapacity}, ФИ водителя: {Name}";
        }
    }
}
