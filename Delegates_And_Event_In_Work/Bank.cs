using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_And_Event_In_Work
{
    class Account
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;
        public delegate void AccountHandler(string mess);
        public event AccountHandler Notify;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }


        int sum;
        public Account(int sum)
        {
            this.sum = sum;
        }
        public int CurrentSum
        {
            get => sum;
        }

        public void Put(int sum)
        {
            this.sum += sum;
            //_del($"Summ {sum} add in account");
            Notify?.Invoke($"На рахунок додалося : {sum}");
        }
        public void Withdraw(int sum)
        {
            if(this.sum <= sum)
            {
                this.sum -= sum;
                if (_del != null)
                    //_del($"Summ {sum} withdraw with account!");
                    Notify?.Invoke($"З рахунку знято : {sum}");
            }
            else
            {
                if(_del != null)
                {
                    //_del("No money!");
                    Notify?.Invoke("Недостатньо грошей!");
                }
            }
        }
        
    }
}
