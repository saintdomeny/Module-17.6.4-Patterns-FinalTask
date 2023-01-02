using Module_17._6._4_Patterns_FinalTask.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17._6._4_Patterns_FinalTask
{
    class CalculateComputer
    {
        public void PerformCalculation(ICalculateMode calculateMode, Account account)
        {
            calculateMode.Calculate(account);
        }
    }
}
