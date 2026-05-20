using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodgotovkaOOp.Models.Intefrace;
namespace PodgotovkaOOp
{
    public class AddVehicleCommand :ICommand
    {
        private readonly List<Models.Vehicle> _targetList;
        private readonly Models.Vehicle _vehicleToProcess;
        public AddVehicleCommand(List<Models.Vehicle> targetList, Models.Vehicle vehicleToProcess)
        {
            _targetList = targetList;
            _vehicleToProcess = vehicleToProcess;
        }
        public void Execute()
        {
            _targetList.Add(_vehicleToProcess);
        }
        public void Undo()
        {
            _targetList.Remove(_vehicleToProcess);
        }
        public void Redo()
        {
            Execute();
        }
    }
}
