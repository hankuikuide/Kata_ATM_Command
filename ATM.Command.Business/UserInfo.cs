using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    class UserInfo
    {
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance;}
            set { balance = value; }
        }

        private int digit;

        public int Digit
        {
            get { return digit; }
            set { digit = value; }
        }

        public UserInfo(string name,double balance,int digit)
        {
            this.name = name;
            this.balance = balance;
            this.digit = digit;

        }
    }
}
