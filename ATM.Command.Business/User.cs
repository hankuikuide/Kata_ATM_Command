using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public class User
    {
        private string name;

        private static DBCore dbCore = DBCore.getInstance();

        private static CheckBalanceCommand checkBalanceCommand = new CheckBalanceCommand(dbCore);
        private static DepositCommand depositCommand = new DepositCommand(dbCore);
        private static WithDrawCommand withDrawCommand = new WithDrawCommand(dbCore);
        private static ChargeCommand chargeCommand = new ChargeCommand(dbCore);

        private ATMInvoke atmInvoke = new ATMInvoke(checkBalanceCommand, depositCommand, withDrawCommand, chargeCommand);
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double money;

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        private int digit;

        public int Digit
        {
            get { return digit; }
            set { digit = value; }
        }

        public User(string name, double money)
        {
            this.name = name;
            this.money = money;
        }
        
        public double checkBalance()
        {
            return atmInvoke.checkBalance(this);
        }
        
        public double deposit(double money)
        {

            this.money = money;

            return atmInvoke.deposit(this);
        }

        public double withDraw(double money)
        {
            this.money = money;

            return atmInvoke.withDraw(this);
        }

        public double charge(int digit)
        {
            this.digit = digit;

            return atmInvoke.charge(this);
        }

    }
}
