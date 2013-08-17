using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Command.Business
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Li", 0);

            Console.WriteLine("用户查询余额:{0}", user.checkBalance());
           
            Console.WriteLine("用户存款1000元,查询余额:{0}", user.deposit(1000));

            Console.WriteLine("用户取款300元,查询余额:{0}", user.withDraw(300));

            Console.WriteLine("用户充电100个字,查询余额:{0}", user.charge(100));

            Console.ReadLine();
        }
    }
}
