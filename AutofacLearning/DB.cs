using System;

namespace AutofacLearning
{
    public interface IDB
    {
        bool Account(string accountName);
    }

    public class DB : IDB
    {
        public bool Account(string accountName)
        {
            throw new NotImplementedException();
        }
    }
}