using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaOOp.Models
{
    public class Inspection
    {
        public string InspectorName { get; set; }
        public DateTime InspectionDate { get; set; }
        public bool Passed { get; set; }
        public int MileageAtInspection { get; set; }
        public int EcoGroup { get; set; }
        public bool GasLeakChecked { get; set; }
        public decimal ParkingBrakeEfficiency { get; set; }
        public decimal BrakeEfficiency { get; set; }
        public bool LightsChecked { get; set; }
        public bool TireConditionChecked { get; set; }
        public string InspectionNotes { get; set; }

        // ====================================================================
        // ADDED: Parameterless constructor required for XML loading/creation
        // ====================================================================
        public Inspection()
        {
            InspectorName = "";
            InspectionDate = DateTime.Now;
            Passed = false;
            MileageAtInspection = 0;
            EcoGroup = 1;
            GasLeakChecked = false;
            ParkingBrakeEfficiency = 0m;
            BrakeEfficiency = 0m;
            LightsChecked = false;
            TireConditionChecked = false;
            InspectionNotes = "";
        }

        public Inspection(string inspectorName, DateTime inspectionDate, bool passed, int mileageAtInspection,
            int ecogroup, bool gasLeakChecked, decimal parkingBrakeEfficiency,
            decimal brakeEfficiency, bool lightsChecked, bool tireConditionChecked, string inspectionNotes)
        {
            InspectorName = inspectorName;
            InspectionDate = inspectionDate;
            Passed = passed;
            MileageAtInspection = mileageAtInspection;
            EcoGroup = ecogroup;
            GasLeakChecked = gasLeakChecked;
            ParkingBrakeEfficiency = parkingBrakeEfficiency;
            BrakeEfficiency = brakeEfficiency;
            LightsChecked = lightsChecked;
            TireConditionChecked = tireConditionChecked;
            InspectionNotes = inspectionNotes;
        }

        public override string ToString()
        {
            return $"Inspection by {InspectorName} on {InspectionDate:d}: " +
                   $"{(Passed ? "Passed" : "Failed")}, Mileage: {MileageAtInspection}, " +
                   $"Eco Group: {EcoGroup}, Gas Leak Checked: {GasLeakChecked}, " +
                   $"Parking Brake Efficiency: {ParkingBrakeEfficiency}%, Brake Efficiency: {BrakeEfficiency}%, " +
                   $"Lights Checked: {LightsChecked}, Tire Condition Checked: {TireConditionChecked}";
        }
    }
}