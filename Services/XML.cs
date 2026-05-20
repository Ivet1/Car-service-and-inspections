using PodgotovkaOOp.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace PodgotovkaOOp.Services
{
    public class XML
    {

        public void Save(string filepath, List<Vehicle> vehicles)
        {
            if (vehicles == null || string.IsNullOrEmpty(filepath))
                return;

            var root = new XElement("Vehicles",
                vehicles.Select(v =>
                {
                    if (v is Car c)
                    {
                        return new XElement("Car",
                            new XAttribute("Brand", c.Brand ?? ""),
                            new XAttribute("Model", c.Model ?? ""),
                            new XAttribute("RegistrationNumber", c.RegistrationNumber ?? ""),
                            new XAttribute("BaseRepairCost", c.BaseRepairCost),
                            new XAttribute("EngineType", c.EngineType ?? ""),
                            new XAttribute("TotalRepairCost", c.CalculateModelCost())
                        );
                    }
                    if (v is Truck t)
                    {
                        return new XElement("Truck",
                            new XAttribute("Brand", t.Brand ?? ""),
                            new XAttribute("Model", t.Model ?? ""),
                            new XAttribute("RegistrationNumber", t.RegistrationNumber ?? ""),
                            new XAttribute("BaseRepairCost", t.BaseRepairCost),
                            new XAttribute("LoadCapacity", t.LoadCapacity),
                            new XAttribute("TotalRepairCost", t.CalculateModelCost())
                        );
                    }
                    if (v is Motorcycle m)
                    {
                        return new XElement("Motorcycle",
                            new XAttribute("Brand", m.Brand ?? ""),
                            new XAttribute("Model", m.Model ?? ""),
                            new XAttribute("RegistrationNumber", m.RegistrationNumber ?? ""),
                            new XAttribute("BaseRepairCost", m.BaseRepairCost),
                            new XAttribute("EngineDisplacement", m.EngineDisplacement),
                            new XAttribute("IsTwoStroke", m.IsTwoStroke),
                            new XAttribute("TotalRepairCost", m.CalculateModelCost())
                        );
                    }

                    return new XElement("Vehicle",
                        new XAttribute("Brand", v.Brand ?? ""),
                        new XAttribute("Model", v.Model ?? ""),
                        new XAttribute("RegistrationNumber", v.RegistrationNumber ?? ""),
                        new XAttribute("BaseRepairCost", v.BaseRepairCost)
                    );
                })
            );

            root.Save(filepath);
        }

        public List<Vehicle> LoadVehicles(string filepath)
        {
            if (!File.Exists(filepath)) return new List<Vehicle>();

            var doc = XDocument.Load(filepath);
            var list = new List<Vehicle>();

            foreach (var element in doc.Root.Elements())
            {
                if (element.Name == "Car")
                {
                    var car = new Car();
                    car.Brand = element.Attribute("Brand")?.Value;
                    car.Model = element.Attribute("Model")?.Value;
                    car.RegistrationNumber = element.Attribute("RegistrationNumber")?.Value;
                    car.BaseRepairCost = decimal.Parse(element.Attribute("BaseRepairCost")?.Value ?? "0");
                    car.EngineType = element.Attribute("EngineType")?.Value;

                    list.Add(car);
                }
                else if (element.Name == "Truck")
                {
                    var truck = new Truck();
                    truck.Brand = element.Attribute("Brand")?.Value;
                    truck.Model = element.Attribute("Model")?.Value;
                    truck.RegistrationNumber = element.Attribute("RegistrationNumber")?.Value;
                    truck.BaseRepairCost = decimal.Parse(element.Attribute("BaseRepairCost")?.Value ?? "0");
                    truck.LoadCapacity = decimal.Parse(element.Attribute("LoadCapacity")?.Value ?? "0");

                    list.Add(truck);
                }
                else if (element.Name == "Motorcycle")
                {
                    var motorcycle = new Motorcycle();
                    motorcycle.Brand = element.Attribute("Brand")?.Value;
                    motorcycle.Model = element.Attribute("Model")?.Value;
                    motorcycle.RegistrationNumber = element.Attribute("RegistrationNumber")?.Value;
                    motorcycle.BaseRepairCost = decimal.Parse(element.Attribute("BaseRepairCost")?.Value ?? "0");
                    motorcycle.EngineDisplacement = decimal.Parse(element.Attribute("EngineDisplacement")?.Value ?? "0");
                    motorcycle.IsTwoStroke = bool.Parse(element.Attribute("IsTwoStroke")?.Value ?? "false");

                    list.Add(motorcycle);
                }
            }

            return list;
        }

        public void Save(string filepath, List<Inspection> inspections)
        {
            if (inspections == null || string.IsNullOrEmpty(filepath))
                return;

            var root = new XElement("Inspections",
                inspections.Select(i => new XElement("Inspection",
                    new XAttribute("InspectorName", i.InspectorName ?? ""),
                    new XAttribute("InspectionDate", i.InspectionDate.ToString("yyyy-MM-dd")),
                    new XAttribute("Passed", i.Passed),
                    new XAttribute("MileageAtInspection", i.MileageAtInspection),
                    new XAttribute("EcoGroup", i.EcoGroup),
                    new XAttribute("GasLeakChecked", i.GasLeakChecked),
                    new XAttribute("ParkingBrakeEfficiency", i.ParkingBrakeEfficiency),
                    new XAttribute("BrakeEfficiency", i.BrakeEfficiency),
                    new XAttribute("LightsChecked", i.LightsChecked),
                    new XAttribute("TireConditionChecked", i.TireConditionChecked),
                    new XAttribute("InspectionNotes", i.InspectionNotes ?? "")
                ))
            );

            root.Save(filepath);
        }

        public List<Inspection> LoadInspections(string filepath)
        {
            if (!File.Exists(filepath)) return new List<Inspection>();

            var doc = XDocument.Load(filepath);
            var list = new List<Inspection>();

            foreach (var element in doc.Root.Elements("Inspection"))
            {
                var inspection = new Inspection();
                inspection.InspectorName = element.Attribute("InspectorName")?.Value;
                inspection.InspectionDate = DateTime.Parse(element.Attribute("InspectionDate")?.Value ?? DateTime.Now.ToString());
                inspection.Passed = bool.Parse(element.Attribute("Passed")?.Value ?? "false");
                inspection.MileageAtInspection = int.Parse(element.Attribute("MileageAtInspection")?.Value ?? "0");
                inspection.EcoGroup = int.Parse(element.Attribute("EcoGroup")?.Value ?? "1");
                inspection.GasLeakChecked = bool.Parse(element.Attribute("GasLeakChecked")?.Value ?? "false");
                inspection.ParkingBrakeEfficiency = decimal.Parse(element.Attribute("ParkingBrakeEfficiency")?.Value ?? "0");
                inspection.BrakeEfficiency = decimal.Parse(element.Attribute("BrakeEfficiency")?.Value ?? "0");
                inspection.LightsChecked = bool.Parse(element.Attribute("LightsChecked")?.Value ?? "false");
                inspection.TireConditionChecked = bool.Parse(element.Attribute("TireConditionChecked")?.Value ?? "false");
                inspection.InspectionNotes = element.Attribute("InspectionNotes")?.Value;

                list.Add(inspection);
            }

            return list;
        }
    }
}