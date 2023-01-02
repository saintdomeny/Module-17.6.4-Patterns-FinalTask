using Module_17._6._4_Patterns_FinalTask.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17._6._4_Patterns_FinalTask
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(Account account)
        {
            var calculateComputer = new CalculateComputer();

            if (account.Type == "Обычный")
            {
                calculateComputer.PerformCalculation(new CommonCalculateMode(), account);
                /*var commonCalculate = new CommonCalculate();
                commonCalculate.Calculate(account);*/
            }
            else if (account.Type == "Зарплатный")
            {
                calculateComputer.PerformCalculation(new SalaryCalculateMode(), account);
                /*var salaryCalculate = new SalaryCalculate();
                salaryCalculate.Calculate(account);*/
            }
        }
    }
}
