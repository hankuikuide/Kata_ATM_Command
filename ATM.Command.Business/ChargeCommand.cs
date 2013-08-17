using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public class ChargeCommand : ICommand
    {
        public ChargeCommand(DBCore dbCore)
            : base(dbCore)
        {

        }

        public override double execute(User user)
        {
            return base.dbCore.charge(user.Name, user.Digit);
        }
    }
}
