using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodgotovkaOOp.Models;
using PodgotovkaOOp.Models.Intefrace;

namespace PodgotovkaOOp.Commands
{
    public class UndoCommand :ICommand
    {
        private readonly List<Models.Vehicle> _vehicles;
        private readonly Models.Vehicle _vehicleToUndo;
        public UndoCommand(List<Models.Vehicle> vehicles, Vehicle vehicleToUndo)
        {
            _vehicles = vehicles;
            _vehicleToUndo = vehicleToUndo;
        }
        public void Execute()
        {
            _vehicles.Remove(_vehicleToUndo);
        }
        public void Undo()
        {
            _vehicles.Add(_vehicleToUndo);
        }
        public void Redo()
        {
            Execute();
        }
    }
}
