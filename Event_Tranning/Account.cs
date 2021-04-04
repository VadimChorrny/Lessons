using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Tranning
{
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify; // використовуємо делегат в якості метода
        public decimal Sum { get; set; }
        public void Add(decimal sum)
        {
            if(Sum <= 5000 && Sum > 10)
            {
            Sum += sum;
            Notify?.Invoke($"In card put {sum}$\n Current balance {Sum}"); // в invoke() передається те шо в делегаті
            }
            else
            {
                Notify?.Invoke("You can put in cart from 10$ to 5000$");
            }
        }
        public void Minus(decimal sum)
        {
            if(sum >= 0)
            {
            Sum -= sum;
            Notify?.Invoke($"In card take {sum}$\n Current balance {Sum}"); // в invoke() передається те шо в делегаті
            }
            else
            {
                Notify?.Invoke($"Error with take in card!");
            }
        }


    }
}
