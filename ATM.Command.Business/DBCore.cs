using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ATM.Command.Business
{
    public class DBCore
    {
        private static DBCore dbCore;
        private List<UserInfo> userInfoList = new List<UserInfo>();

        private DBCore()
        {
            userInfoList.Add(new UserInfo("Li",0,0));
        }

        public static DBCore getInstance()
        {
            if (dbCore==null)
            {
                dbCore = new DBCore();
            }
            return dbCore;
        }

        public double checkBalance(string name)
        {
            UserInfo userInfo = getUserInfoByName(name);

            return userInfo.Balance;
        }

        private UserInfo getUserInfoByName(string name)
        {
            UserInfo resultUserInfo = userInfoList.Find(
                delegate(UserInfo userInfo)
                {
                    return userInfo.Name.Equals(name);
                });
            return resultUserInfo;
        }

        public double deposit(string name,double money)
        {
            UserInfo userInfo = getUserInfoByName(name);

            userInfo.Balance += money;

            userInfoList[userInfoList.IndexOf(userInfo)] = userInfo;

            return userInfo.Balance;
        }

        public double withdraw(string name, double money)
        {
            UserInfo userInfo = getUserInfoByName(name);

            userInfo.Balance -= money;

            userInfoList[userInfoList.IndexOf(userInfo)] = userInfo;

            return userInfo.Balance;
        }

        public double charge(string name, int digit)
        {
            UserInfo userInfo = getUserInfoByName(name);

            userInfo.Balance -= digit * 2;

            userInfoList[userInfoList.IndexOf(userInfo)] = userInfo;

            return userInfo.Balance;

        }

    }
}
