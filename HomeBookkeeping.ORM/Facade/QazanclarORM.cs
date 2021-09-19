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
   public class QazanclarORM:ORMBase<Qazanclar>
    {
        public DataTable Select(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Qazanclar_Select", Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", i.ID);
            da.Fill(dt);
            return dt;
        }
        public DataTable SelectSum(Istifadeci i)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_Qazanclar_Sum_Select", Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            da.Fill(dt);
            return dt;
        }
        public Nullable<DateTime> qazancTarixStart { get; set; }
        public Nullable<DateTime> qazancTarixEnd { get; set; }
        //  public Nullable<int> qazancKateqoriyaid { get; set; }
        //public Nullable<int> hesabid { get; set; }
        public DataTable All_Search(Istifadeci i, Qazanclar q, QazancKateqoriya qk, Hesablar h, string CommandText)
        {
            SqlDataAdapter da = new SqlDataAdapter(CommandText, Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", i.ID);
            da.SelectCommand.Parameters.AddWithValue("@qazancTarixStart", qazancTarixStart);
            da.SelectCommand.Parameters.AddWithValue("@qazancTarixEnd", qazancTarixEnd);
            //da.SelectCommand.Parameters.AddWithValue("@qazancKateqoriyaid", qazancKateqoriyaid);
            da.SelectCommand.Parameters.AddWithValue("@qazancKateqoriyaAdi", qk.qazancKateqoriyaAdi);
            //da.SelectCommand.Parameters.AddWithValue("@hesabid", hesabid);
            da.SelectCommand.Parameters.AddWithValue("@hesabAdi", h.hesabAdi);
            da.Fill(dt);
            return dt;
        }
        public DataTable IncomeSum(Hesablar h, string CommandTextPeriod)
        {
            SqlDataAdapter da = new SqlDataAdapter(string.Format("prc_Qazanclar_Sum_{0}", CommandTextPeriod), Tools.Baglanti);
            DataTable dt = new DataTable();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", h.istifadeciid);
            da.Fill(dt);
            return dt;
        }
    }
}
