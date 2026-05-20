using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodgotovkaOOp.Models.Intefrace;

namespace PodgotovkaOOp.Models
{
    public abstract class Vehicle : IDisplayable
    {
        private string _registrationNumber;
        private string _brand;
        private string _model;
        protected decimal _baseRepairCost;

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public decimal BaseRepairCost
        {
            get { return _baseRepairCost; }
            set { _baseRepairCost = value; }
        }

        // Твоят оригинален конструктор
        public Vehicle(string registrationNumber, string brand, string model, decimal baseRepairCost)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            BaseRepairCost = baseRepairCost;
        }
        public Vehicle()
        {
            RegistrationNumber = "";
            Brand = "";
            Model = "";
            BaseRepairCost = 0m;
        }

        public virtual decimal CalculateBaseRepairCost()
        {
            return BaseRepairCost;
        }

        public abstract decimal CalculateModelCost();

        public virtual string GetSummaryInfo()
        {
            return $"Vehicle:{Brand} {Model}, Reg#:{RegistrationNumber}";
        }

        public abstract string GetDetailedInfo();

        public List<Inspection> Inspections { get; set; } = new List<Inspection>();
    }
}