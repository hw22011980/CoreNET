using System;
using System.Linq;
using System.Text;
using CoreNET.Common.BO;

namespace CoreNET.Common.Base
{
  public class BaseDataControlSIPD : BaseDataControlExt, IDataControlUIEntry, IExtLoadCsv, IHasJSScript
  {
    public BaseDataControlSIPD()
    {
      ConnectionString = GetConnectionString();
      ModeDB = SQLDataSource.MODE_DB_OPERATIONAL;
    }

    public static string GetConnectionString()
    {
      string SQLInstance = GlobalAsp.GetDataSource();
      string user = SQLDataSource.GetUserDB();
      string pwd = SQLDataSource.GetPwdDB();
      string ConnectionString = string.Format("data source={0};initial catalog=SIPD01DM;user id={1};password={2};Asynchronous Processing=true",
        SQLInstance, user, pwd);
      return ConnectionString;
    }
  }
}
