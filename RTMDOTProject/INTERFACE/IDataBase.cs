using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.INTERFACE
{
    public interface IDataBase<T1>
    {
        string ExcuteRowSqlCommand(string spQuery, object[] Param);
        string ExcuteSingleRowSqlCommand(string spQuery, object[] Param);
        string ExcuteDataTableRowSqlCommand(string spQuery, SqlParameter[] Param);
    }
}
