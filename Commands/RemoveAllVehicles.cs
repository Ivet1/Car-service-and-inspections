using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodgotovkaOOp.Models;
using PodgotovkaOOp.Models.Intefrace;

namespace PodgotovkaOOp.Commands
{
    public class RemoveAllVehicles : ICommand
    {
        private readonly List<Models.Vehicle> _targetList;
        private readonly List<Models.Vehicle> _oldVehicles;
        public RemoveAllVehicles(List<Vehicle> mainList)
        {
            _targetList = mainList;

            // Правим нов списък и прехвърляме в него стрелките на текущите коли.
            // Така, дори ако изчистим главния списък, нашето "сейфче" ще си ги пази!
            _oldVehicles = new List<Vehicle>(mainList);
        }
public void Execute()
        {
            _targetList.Clear();
        }
        public void Undo()
        {
            _targetList.AddRange(_oldVehicles);
        }
        public void Redo()
        {
            Execute();
        }
    }
}
