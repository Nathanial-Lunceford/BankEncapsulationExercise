using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double dep)
        {
            balance += dep;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
