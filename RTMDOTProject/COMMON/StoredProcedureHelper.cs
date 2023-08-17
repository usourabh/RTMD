using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class StoredProcedureHelper
    {
        #region MON Stored Procedure
        public const string spGetDevice_WithPaging = "[dbo].[spGetDevice_WithPaging] '{0}','{1}','{2}','{3}','{4}'";
        public const string spInsertVaccineBoxTransaction = "[dbo].[sp_InsertVaccineBoxTransaction] '{0}','{1}','{2}','{3}'";
        public const string spGetInActiveDevice_WithPaging = "[dbo].[spGetInActiveDevice_WithPaging] '{0}','{1}','{2}',{3},{4}";
        public const string ActiveAlarmDevice_WithPaging = "[dbo].[ActiveAlarmDevice_WithPaging] '{0}','{1}','{2}',{3},{4}";
        public const string spGetActiveDevice_WithPaging = "[dbo].[spGetActiveDevice_WithPaging] '{0}','{1}','{2}',{3},{4}";
        public const string spDashboardNotification = "[dbo].[sp_DashboardNotification] '{0}'";
        public const string spGetDeviceByid = "[dbo].[spGetDeviceByid] '{0}'";
        public const string spGetDeviceRecentTransactionByImei = "[dbo].[spGetDeviceRecentTransactionByImei] '{0}'";
        public const string sp_GetInActiveDevice = "[dbo].[sp_GetInActiveDevice_del] '{0}','{1}','{2}',{3},{4}";
        public const string sp_GetHistrory = "[dbo].[sp_GetHistrory] '{0}','{1}','{2}'";
       // public const string spGetRDMasterData = "[dbo].[spGetRDMasterData] '{0}','{1}','{2}',{3},{4}";
        public const string spGetSurveyTransData = "[dbo].[spGetSurveyTransData] '{0}','{1}','{2}',{3},{4}";
        public const string spGetDeviceTransactionByRange = "[dbo].[spGetDeviceTransactionByRange] '{0}','{1}','{2}',{3}";
       public const string ReportByDuration = "[dbo].[DeviceReportByDurationByDuration] '{0}','{1}','{2}',{3},{4},'{5}','{6}'";
       
        #endregion


        #region UserManagement Stored Procedure
        public const string spGetValidateLogin = "[dbo].[spGetValidateLogin] '{0}','{1}','{2}','{3}'";
        public const string spGetValidateSurveyLogin = "[dbo].[spGetValidateSurveyLogin] '{0}','{1}','{2}','{3}'";
        #endregion

        #region Survey Stored Procedure
        public const string spGetRdByCode = "[dbo].[sp_GetRdByCode] '{0}'";
        public const string spSurveyInsert = "[dbo].[spSurveyInsert] '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}'";
        #endregion


        public const string spQRdetail = "[dbo].[spQRdetail]";
        public const string spQrMasterInsert = "[dbo].[spQrMasterInsert] {0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}'";

        public const string SpGetQrByQrId = "[dbo].[SpGetQrByQrId] '{0}'";
        public const string spInsertGspTransactionAuto = "[dbo].[sp_InsertGspTransactionAuto] '{0}'";
        public const string GetDeviceData = "[dbo].[GetDeviceData] '{0}','{1}','{2}',{3},{4}";



    }
}
