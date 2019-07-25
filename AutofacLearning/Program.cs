using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace AutofacLearning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SearchAccount>();
            builder.RegisterType<GetLog>().As<IGetLog>();
            builder.RegisterType<DB>().As<IDB>();

            var container = builder.Build();
            var searchAccount = container.Resolve<SearchAccount>();

            var accountAuth = searchAccount.AccountAuth("April");
            var vaildationResult = searchAccount.GetPassword(accountAuth);
            Console.WriteLine(vaildationResult == "correct password" ? "doing" : "OH NO");
            Console.ReadLine();
        }

        //public class FackSearchAccount : ISearchAccount
        //{
        //    public bool AccountAuth(string accountName)
        //    {
        //        return true;
        //    }

        //    public string GetPassword(bool result)
        //    {
        //        return "correct password";
        //    }
        //}

        //public class FakeDB : IDB
        //{
        //    public bool Account(string accountName)
        //    {
        //        return true;
        //    }
        //}

        //public class FakeGetLog : IGetLog
        //{
        //    public void Info(string msg)
        //    {
        //        Console.WriteLine("fake info");
        //    }
        //}
    }
}