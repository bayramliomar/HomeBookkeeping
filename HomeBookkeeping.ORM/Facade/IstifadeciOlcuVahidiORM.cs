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
   public class IstifadeciOlcuVahidiORM:ORMBase<IstifadeciOlcuVahidi>
    {
        public DataTable Select(IstifadeciOlcuVahidi iov)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciOlcuVahidi_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", iov.istifadeciid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool İnsertCategori_Istifadeci_OlcuVahidi(IstifadeciOlcuVahidi iov, OlcuVahidi ov)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_OlcuVahidi_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@olcuVahidAd", ov.olcuVahidAd);
            cmd.Parameters.AddWithValue("@istifadeciid", iov.istifadeciid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool UpdateCategori_Istifadeci_OlcuVahidi(IstifadeciOlcuVahidi iov, OlcuVahidi ov)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_OlcuVahidi_Update", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iov.istifadeciid);
            cmd.Parameters.AddWithValue("@olcuVahidiid", iov.olcuVahidiid);
            cmd.Parameters.AddWithValue("@olcuVahidAd", ov.olcuVahidAd);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool DeleteCategori_Istifadeci_OlcuVahidi(IstifadeciOlcuVahidi iov)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_OlcuVahidi_Delete", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iov.istifadeciid);
            cmd.Parameters.AddWithValue("@olcuVahidiid", iov.olcuVahidiid);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
