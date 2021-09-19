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
   public class IstifadeciXercAltKateqoriyaORM:ORMBase<IstifadeciXercAltKateqoriya>
    {
        public DataTable Select(IstifadeciXercAltKateqoriya ixak, XercAltKateqoriya xak)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciXercAltKateqoriya_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", ixak.istifadeciid);
            da.SelectCommand.Parameters.AddWithValue("@xercKateqoriyaid", xak.xercKateqoriyaid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool İnsertCategori_Istifadeci_XercAltKateqoriya(IstifadeciXercAltKateqoriya ixak, XercAltKateqoriya xak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercAltKateqoriya_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@altXercKateqoriyaAdi", xak.altXercKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@istifadeciid", ixak.istifadeciid);
            cmd.Parameters.AddWithValue("@xercKateqoriyaid", xak.xercKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool UpdateCategori_Istifadeci_XercAltKateqoriya(IstifadeciXercAltKateqoriya ixak, XercAltKateqoriya xak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercAltKateqoriya_Update", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", ixak.istifadeciid);
            cmd.Parameters.AddWithValue("@xercAltKateqoriyaid", ixak.xercAltKateqoriyaid);
            cmd.Parameters.AddWithValue("@altXercKateqoriyaAdi", xak.altXercKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@xercKateqoriyaid", xak.xercKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool DeleteCategori_Istifadeci_XercAltKateqoriya(IstifadeciXercAltKateqoriya ixak, XercAltKateqoriya xak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_XercAltKateqoriya_Delete", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", ixak.istifadeciid);
            cmd.Parameters.AddWithValue("@xercAltKateqoriyaid", ixak.xercAltKateqoriyaid);
            cmd.Parameters.AddWithValue("@xercKateqoriyaid",xak.xercKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
