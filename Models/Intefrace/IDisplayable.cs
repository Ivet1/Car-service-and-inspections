using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaOOp.Models.Intefrace
{
    public interface IDisplayable
    {
        string GetSummaryInfo();
        string GetDetailedInfo();
    }
}
