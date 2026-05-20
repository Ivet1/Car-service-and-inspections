using System;

namespace PodgotovkaOOp.Models
{
    public class Car : Vehicle
    {
        public string EngineType { get; set; }

        public Car(string registrationNumber, string brand, string model, decimal baseRepairCost, string engineType)
            : base(registrationNumber, brand, model, baseRepairCost)
        {
            EngineType = engineType;
        }
        public Car() : base("", "", "", 0m)
        {
            EngineType = "";
        }

        public override decimal CalculateModelCost()
        {
            return BaseRepairCost + ((EngineType?.ToLower() == "diesel") ? 100m : 50m);
        }

        public override string GetDetailedInfo()
        {
            return $"Car: {Brand} {Model}\n" +
                   $"Registration Number: {RegistrationNumber}\n" +
                   $"Base Repair Cost: {BaseRepairCost:C}\n" +
                   $"Engine Type: {EngineType}\n" +
                   $"Total Repair Cost: {CalculateModelCost():C}";
        }
    }
}