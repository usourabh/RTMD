using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.Models
{
    public class ChartData
    {
        public int ChartDataId { get; set; }
        public string ChartTimeStamp { get; set; }
        public double ChartValue { get; set; }
            public List<ChartData> GetChartData(string connectionString)
            {
                List<ChartData> chartDataList = new List<ChartData>();
                SqlConnection con = new SqlConnection(connectionString);
                string selectSQL = "SELECT ChartDataId, FORMAT(ChartTimeStamp, 'MM.dd HH:mm') AS ChartTimeStamp, ChartValue FROM CHARTDATA";
                con.Open();
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        ChartData chartData = new ChartData();
                        chartData.ChartDataId = Convert.ToInt32(dr["ChartDataId"]);
                        chartData.ChartTimeStamp = dr["ChartTimeStamp"].ToString();
                        chartData.ChartValue = Convert.ToDouble(dr["ChartValue"]);
                        chartDataList.Add(chartData);
                    }
                }
                return chartDataList;
            }
    }

    public partial class TempSensorChart
    {
        public int Tmpsid { get; set; }
        public string InsertText { get; set; }
        public DateTime Tdate { get; set; }
        public List<TempSensorChart> GetChartData(string ServerConnection)
        {
            List<TempSensorChart> chartDataList = new List<TempSensorChart>();
            SqlConnection con = new SqlConnection(ServerConnection);
            string selectSQL = "SELECT Tmpsid, FORMAT(ChartTimeStamp, 'MM.dd HH:mm') AS ChartTimeStamp, ChartValue FROM CHARTDATA";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ChartData chartData = new ChartData();
                    chartData.ChartDataId = Convert.ToInt32(dr["ChartDataId"]);
                    chartData.ChartTimeStamp = dr["ChartTimeStamp"].ToString();
                    chartData.ChartValue = Convert.ToDouble(dr["ChartValue"]);
                    //chartDataList.Add(chartData);
                }
            }
            return chartDataList;
        }

    }


}

