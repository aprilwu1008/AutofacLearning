using System;

namespace AutofacLearning
{
    public interface IGetLog
    {
        void Info(string msg);
    }

    public class GetLog : IGetLog
    {
        public void Info(string msg)
        {
            throw new NotImplementedException();
        }
    }
}