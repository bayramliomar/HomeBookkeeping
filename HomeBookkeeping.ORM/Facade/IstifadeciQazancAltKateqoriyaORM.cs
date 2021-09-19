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
   public class IstifadeciQazancAltKateqoriyaORM:ORMBase<IstifadeciQazancAltKateqoriya>
    {
        public DataTable Select(IstifadeciQazancAltKateqoriya iqak, QazancAltKateqoriya qak)
        {
            SqlDataAdapter da = new SqlDataAdapter("prc_IstifadeciQazancAltKateqoriya_Select", Tools.Baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@istifadeciid", iqak.istifadeciid);
            da.SelectCommand.Parameters.AddWithValue("@qazancKateqoriyaid", qak.qazancKateqoriyaid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool İnsertCategori_Istifadeci_QazancAltKateqoriya(IstifadeciQazancAltKateqoriya iqak, QazancAltKateqoriya qak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancAltKateqoriya_Insert", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@altQazancKateqoriyaAdi", qak.altQazancKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@istifadeciid", iqak.istifadeciid);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaid", qak.qazancKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool UpdateCategori_Istifadeci_QazancAltKateqoriya(IstifadeciQazancAltKateqoriya iqak, QazancAltKateqoriya qak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancAltKateqoriya_Update", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iqak.istifadeciid);
            cmd.Parameters.AddWithValue("@qazancAltKateqoriyaid", iqak.qazancAltKateqoriyaid);
            cmd.Parameters.AddWithValue("@altQazancKateqoriyaAdi", qak.altQazancKateqoriyaAdi);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaid", qak.qazancKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool DeleteCategori_Istifadeci_QazancAltKateqoriya(IstifadeciQazancAltKateqoriya iqak, QazancAltKateqoriya qak)
        {
            SqlCommand cmd = new SqlCommand("prc_Istifadeci_QazancAltKateqoriya_Delete", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@istifadeciid", iqak.istifadeciid);
            cmd.Parameters.AddWithValue("@qazancAltKateqoriyaid", iqak.qazancAltKateqoriyaid);
            cmd.Parameters.AddWithValue("@qazancKateqoriyaid", qak.qazancKateqoriyaid);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
