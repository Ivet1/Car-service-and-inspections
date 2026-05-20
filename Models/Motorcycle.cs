using System;

namespace PodgotovkaOOp.Models
{
    public class Motorcycle : Vehicle
    {
        private decimal _engineDisplacement;
        public bool IsTwoStroke { get; set; }

        public decimal EngineDisplacement
        {
            get { return _engineDisplacement; }
            set { _engineDisplacement = value; }
        }

        public Motorcycle(string registrationNumber, string brand, string model,
            decimal baseRepairCost, decimal engineDisplacement, bool isTwoStroke)
            : base(registrationNumber, brand, model,baseRepairCost)
        {
            EngineDisplacement = engineDisplacement;
            IsTwoStroke = isTwoStroke;
        }

        public Motorcycle() : base("", "", "", 0)
        {
            EngineDisplacement = 0m;
            IsTwoStroke = false;
        }

        public override decimal CalculateModelCost()
        {
            decimal finalCost = (decimal)BaseRepairCost;

            if (EngineDisplacement > 600)
            {
                finalCost += 150m;
            }
            if (this.IsTwoStroke)
            {
                finalCost += 50m;
            }
            return finalCost;
        }

        public override string GetDetailedInfo()
        {
            string strokeInfo = IsTwoStroke ? "Yes" : "No";
            return $"Motorcycle: {Brand} {Model}\n" +
                   $"Registration Number: {RegistrationNumber}\n" +
                   $"Base Repair Cost: {BaseRepairCost:C}\n" +
                   $"Engine Displacement: {EngineDisplacement} cc\n" +
                   $"Two-Stroke: {strokeInfo}\n" +
                   $"Total Repair Cost: {CalculateModelCost():C}";
        }
    }
}