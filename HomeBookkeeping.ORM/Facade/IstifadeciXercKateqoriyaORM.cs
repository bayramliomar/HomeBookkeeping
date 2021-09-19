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
   public class IstifadeciXercKateqoriyaORM:ORMBase<IstifadeciXercKateqoriya>
    {
        public DataTable Select(IstifadeciXercKateqoriya ixk)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciXercKateqoriya_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", ixk.istifadeciid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool İnsertStandart()
        {
            SqlCommand cmd = new SqlCommand("prc_Standart_IstifadeciXercKateqoriya_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@i", 1);
            cmd.Parameters.AddWithValue("@j", 1);
            cmd.Parameters.AddWithValue("@k", 1);
            cmd.Parameters.AddWithValue("@n", 1);
            cmd.Parameters.AddWithValue("@m", 1);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool İnsertCategori_Istifadeci_XercKateqoriya(IstifadeciXercKateqoriya ixk,XercKateqoriya xk) 
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercKateqoriya_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@xercKateqoriyaAdi", xk.xercKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@istifadeciid", ixk.istifadeciid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool UpdateCategori_Istifadeci_XercKateqoriya(IstifadeciXercKateqoriya ixk, XercKateqoriya xk)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercKateqoriya_Update", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", ixk.istifadeciid);
            cmd.Parameters.AddWithValue("@xercKateqoriyaid",ixk.xercKateqoriyaid);
            cmd.Parameters.AddWithValue("@xercKateqoriyaAdi", xk.xercKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@i", 1);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool DeleteCategori_Istifadeci_XercKateqoriya(IstifadeciXercKateqoriya ixk)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercKateqoriya_Delete", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", ixk.istifadeciid);
            cmd.Parameters.AddWithValue("@xercKateqoriyaid", ixk.xercKateqoriyaid);
            cmd.Parameters.AddWithValue("@i", 1);
            cmd.Parameters.AddWithValue("@j", 1);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
