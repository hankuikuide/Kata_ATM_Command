using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public class CheckBalanceCommand : ICommand
    {

        public CheckBalanceCommand(DBCore dbCore)
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
            return base.dbCore.checkBalance(user.Name);
        }
    }
}
