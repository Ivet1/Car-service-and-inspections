using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodgotovkaOOp.Models.Intefrace;

namespace PodgotovkaOOp.Commands
{
     public class AddInspectionCommand: ICommand
    {
        private readonly List<Models.Inspection> _targetList;
        private readonly Models.Inspection _inspectionToProcess;
        public AddInspectionCommand(List<Models.Inspection> targetList, Models.Inspection inspectionToProcess)
        {
            _targetList = targetList;
            _inspectionToProcess = inspectionToProcess;
        }
        public void Execute()
        {
            _targetList.Add(_inspectionToProcess);
        }
        public void Undo()
        {
            _targetList.Remove(_inspectionToProcess);
        }
        public void Redo()
        {
            Execute();
        }
    }
}
