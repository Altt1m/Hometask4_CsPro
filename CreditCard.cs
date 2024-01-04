using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    internal class CreditCard
    {
        private string CardNumber { get; set; }
        private short CVC { get; set; }
        private decimal Balance { get; set; }

        public CreditCard(string num, short cvc, decimal bal)
        {
            CardNumber = num;
            CVC = cvc;
            Balance = bal;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard other = (CreditCard)obj;
                return Balance == other.Balance;
            }
            return false;
        }
    }
}
