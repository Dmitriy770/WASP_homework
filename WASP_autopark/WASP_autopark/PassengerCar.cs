using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WASP_autopark
{
    internal class PassengerCar : Car
    {
        protected int PassengerAmount { get; set; }

        protected Dictionary<String, int> RepairBook { get; set; }
        public PassengerCar(string brand, int power, int year, int passengerAmount) : base(brand, power, year)
        {
            PassengerAmount = passengerAmount;
            RepairBook = new Dictionary<string, int> ();
        }
        public PassengerCar(string brand, int power, int year, int passengerAmount, Dictionary<string, int> repairBook) : base(brand, power, year)
        {
            PassengerAmount = passengerAmount;
            RepairBook = repairBook;
        }

        protected void addRecordToRepairBook(String parts, int year)
        {
            RepairBook[parts] = year;
        }

        protected int getYearFromReoairBook(String parts)
        {
            return RepairBook[parts];
        }

        protected void printRepiarBook()
        {
            foreach (var part in RepairBook)
            {
                Console.WriteLine($"Деталь: {part.Key}, год замены: {part.Value}");
            }
        }

        public override string ToString()
        {
            return $"Модель: {Brand}, мощность: {Power}, год выпуска: {Year}, вместимость: {PassengerAmount}";
        }
    }
}
