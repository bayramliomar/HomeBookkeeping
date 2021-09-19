using HomeBookkeeping.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HomeBookkeeping.ORM.Facade
{
   public class IstifadeciQazancKateqoriyaORM:ORMBase<IstifadeciQazancKateqoriya>
    {
        public DataTable Select(IstifadeciQazancKateqoriya iqk)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciQazancKateqoriya_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", iqk.istifadeciid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool İnsertCategori_Istifadeci_QazancKateqoriya(IstifadeciQazancKateqoriya iqk, QazancKateqoriya qk)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancKateqoriya_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@qazancKateqoriyaAdi", qk.qazancKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@istifadeciid", iqk.istifadeciid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool UpdateCategori_Istifadeci_QazancKateqoriya(IstifadeciQazancKateqoriya iqk, QazancKateqoriya qk)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancKateqoriya_Update", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iqk.istifadeciid);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaid", iqk.qazancKateqoriyaid);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaAdi", qk.qazancKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@i", 1);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool DeleteCategori_Istifadeci_QazancKateqoriya(IstifadeciQazancKateqoriya iqk)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancKateqoriya_Delete", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iqk.istifadeciid);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaid", iqk.qazancKateqoriyaid);
            cmd.Parameters.AddWithValue("@i", 1);
            cmd.Parameters.AddWithValue("@j", 1);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
