using System;

namespace PodgotovkaOOp.Models
{
    public class Truck : Vehicle
    {
        private decimal _loadCapacity;
        public decimal LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }

        public Truck(string registrationNumber, string brand, string model, decimal baseRepairCost, decimal loadCapacity)
            : base(registrationNumber, brand, model, baseRepairCost)
        {
            LoadCapacity = loadCapacity;
        }

        public Truck() : base("", "", "", 0m)
        {
            LoadCapacity = 0m;
        }

        public override decimal CalculateModelCost()
        {
            return BaseRepairCost + (LoadCapacity * 10m);
        }

        public override string GetDetailedInfo()
        {
            return $"Truck: {Brand} {Model}\n" +
                   $"Registration Number: {RegistrationNumber}\n" +
                   $"Base Repair Cost: {BaseRepairCost:C}\n" +
                   $"Load Capacity: {LoadCapacity} tons\n" +
                   $"Total Repair Cost: {CalculateModelCost():C}";
        }
    }
}
