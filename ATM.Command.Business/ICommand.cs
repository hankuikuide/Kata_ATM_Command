using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    public abstract class ICommand
    {
        protected DBCore dbCore;

        public ICommand( DBCore dbCore)
        {
            this.dbCore = dbCore;
        }

        public ATMInvoke ATMInvoke
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract double execute(User user); 
    }
}
