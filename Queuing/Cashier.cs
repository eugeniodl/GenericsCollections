using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuing
{
    internal class Cashier
    {
        private int _count = 0;
        public static string getNumberInQueue = "";
        public static Queue<string> cashierQueue;

        public Cashier()
        {
            _count = 10000;
            cashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string cashierNumber)
        {
            _count++;
            cashierNumber += _count.ToString();
            return cashierNumber;
        }
    }
}
