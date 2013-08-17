using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public class DepositCommand : ICommand
    {

        public DepositCommand(DBCore dbCore)
            : base(dbCore)
        {

        }

        public DBCore DBCore
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override double execute(User user)
        {
            return base.dbCore.deposit(user.Name, user.Money);
        }
    }
}
