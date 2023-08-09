using RTMDOTProject.COMMON;
using RTMDOTProject.INTERFACE;
using RTMDOTProject.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.SERVICES
{
    public class DatabaseService : IDataBase<GResposnse>
    {
        private IRepository<GResposnse> _masterRepository1;
        public DatabaseService(IRepository<GResposnse> masterRepository1)
        {
            this._masterRepository1 = masterRepository1;
        }
        public string ExcuteRowSqlCommand(string spQuery, object[] Param)
        {
            return _masterRepository1.ExecuteQueryDynamicList(spQuery, Param);
        }
        public string ExcuteSingleRowSqlCommand(string spQuery, object[] Param)
        {
            return _masterRepository1.ExecuteQuerySingleDynamic(spQuery, Param);
        }
        public string ExcuteDataTableRowSqlCommand(string spQuery, SqlParameter[] Param)
        {
            return _masterRepository1.ExecuteQuerySingleDataTableDynamic(spQuery, Param);
        }
    }
}
