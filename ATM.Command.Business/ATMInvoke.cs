using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public class ATMInvoke
    {
        private CheckBalanceCommand checkBalanceCommand;
        private DepositCommand depositCommand;
        private WithDrawCommand withDrawCommand;
        private ChargeCommand chargeCommand;

        public ATMInvoke(CheckBalanceCommand checkBalanceCommand, DepositCommand depositCommand, 
            WithDrawCommand withDrawCommand, ChargeCommand chargeCommand)
        {
            this.checkBalanceCommand = checkBalanceCommand;
            this.depositCommand = depositCommand;
            this.withDrawCommand = withDrawCommand;
            this.chargeCommand = chargeCommand;
        }
        
        public double checkBalance(User user)
        {
            return this.checkBalanceCommand.execute(user);
        }

        public double deposit(User user)
        {

            return this.depositCommand.execute(user);
        }

        internal double withDraw(User user)
        {

            return this.withDrawCommand.execute(user);

        }

        internal double charge(User user)
        {
            return this.chargeCommand.execute(user);
        }
    }
}
