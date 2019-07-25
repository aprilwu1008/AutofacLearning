using System.Runtime.Remoting.Messaging;

namespace AutofacLearning
{
    public interface ISearchAccount
    {
        bool AccountAuth(string accountName);

        string GetPassword(bool result);
    }

    public class SearchAccount
    {
        private IDB _db;
        private IGetLog _getLog;

        public SearchAccount(IGetLog getLog, IDB db)
        {
            _getLog = getLog;
            _db = db;
        }

        public bool AccountAuth(string accountName)
        {
            _getLog.Info("what");
            return _db.Account(accountName);
        }

        public string GetPassword(bool result)
        {
            return result ? "correct password" : "Go wrong";
        }
    }
}