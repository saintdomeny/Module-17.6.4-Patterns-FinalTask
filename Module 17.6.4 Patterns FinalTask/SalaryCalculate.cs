using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17._6._4_Patterns_FinalTask
{
    public class SalaryCalculate : ICalculate
    {
        public void Calculate(Account account)
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
