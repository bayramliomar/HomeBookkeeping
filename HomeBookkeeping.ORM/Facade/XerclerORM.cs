using HomeBookkeeping.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Facade
{
  public  class XerclerORM:ORMBase<Xercler>
    {
        public DataTable Select(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Xercler_Select", Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            da.Fill(dt);
            return dt;
        }
        public DataTable SelectSum(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Xercler_Sum_Select", Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            da.Fill(dt);
            return dt;
        }
        public Nullable<DateTime> xercTarixStart { get; set; }
        public Nullable<DateTime> xercTarixEnd { get; set; }
      //  public Nullable<int> xercKateqoriyaid { get; set; }
        //public Nullable<int> hesabid { get; set; }
        public DataTable All_Search(Istifadeci i, Xercler x, XercKateqoriya xk, Hesablar h,string CommandText )
        {
            SqlDataAdapter da = new SqlDataAdapter(CommandText, Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            da.SelectCommand.Parameters.AddWithValue("@xercTarixStart", xercTarixStart);
            da.SelectCommand.Parameters.AddWithValue("@xercTarixEnd", xercTarixEnd);
            //da.SelectCommand.Parameters.AddWithValue("@xercKateqoriyaid", xercKateqoriyaid);
            da.SelectCommand.Parameters.AddWithValue("@xercKateqoriyaAdi", xk.xercKateqoriyaAdi);
            //da.SelectCommand.Parameters.AddWithValue("@hesabid", hesabid);
            da.SelectCommand.Parameters.AddWithValue("@hesabAdi", h.hesabAdi);
            da.Fill(dt);
            return dt;
        }

        public DataTable ExpenseSum(Hesablar h,string CommandTextPeriod)
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("prc_Xercler_Sum_{0}",CommandTextPeriod), Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", h.istifadeciid);
            da.Fill(dt);
            return dt;
        }
    }
}
