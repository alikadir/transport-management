using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Collections;

namespace AKBclass
{
    /// <summary>
    /// Database işlemleri için oluşturulmuştur
    /// </summary>
    public class DBMudahale
    {
        public static SqlConnection Baglanti()
        {

            return new SqlConnection(ConfigurationSettings.AppSettings["GenelConnectionString"].ToString());
             
        }
        /// <summary>
        /// bulamazsa "-1" değeri döndürür
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Sart"></param>
        /// <param name="DonecekFieldAdi"></param>
        /// <returns></returns>
        public static string TekDegerDondur(string TabloAdi, string Sart, string DonecekFieldAdi)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select " + DonecekFieldAdi + " from " + TabloAdi + " " + Sart, Baglanti());
            
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString().TrimEnd();
            }
            catch (Exception e) 
            { 
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-TekDegerDondur-1", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

           
            if (string.IsNullOrEmpty(Donen))
                Donen = "-1";
            
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// bulamazsa "-1" değeri döndürür
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Sart"></param>
        /// <param name="DonecekFieldAdi"></param>
        /// <returns></returns>
        public static string TekDegerDondur(string TabloAdi, string Sart, string DonecekFieldAdi,SqlParameter[] pCollection)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select " + DonecekFieldAdi + " from " + TabloAdi + " " + Sart, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString().TrimEnd();
            }
            catch (Exception e)
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-TekDegerDondur-1", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen))
                Donen = "-1";

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// bulamazsa "-1" değeri döndürür
        /// bu TekDegerDondur INSERT işleminde eklenen kayıdın IDsini @@IDENTITY
        /// </summary>
        /// <param name="TamSorgu"></param>
        /// <returns></returns>
        public static string TekDegerDondur(string TamSorgu,SqlParameter[] pCollection)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString().TrimEnd();
            }
            catch(Exception e)
            { 
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-TekDegerDondur-2", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen))
                Donen = "-1";

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// bulamazsa "-1" değeri döndürür
        /// </summary>
        /// <param name="TamSorgu"></param>
        /// <returns></returns>
        public static string TekDegerDondur(string TamSorgu)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() +" "+ TamSorgu, Baglanti());
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString().TrimEnd();
            }
            catch(Exception e)
            { 
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-TekDegerDondur-3", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen))
                Donen = "-1";
            
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// bulamazsa "-1" değeri döndürür
        /// </summary>
        /// <param name="TamSorgu"></param>
        /// <returns></returns>
        public static string SonEklenenKayitID(string TabloAdi)
        {
            string Donen = "-1";
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select ID from " + TabloAdi + " ORDER BY ID DESC", Baglanti());
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();
            }
            catch(Exception e) 
            { 
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SonEklenenKayitID", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            if (string.IsNullOrEmpty(Donen))
                Donen = "-1";
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// "-1" dönerse işlenen kod hatalı veya hiç kayıt etkilenmedi anlamına gelir
        /// </summary>
        /// <param name="TamSorgu"></param>
        /// <returns></returns>
        public static string SQLIsle(string TamSorgu)
        {

            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteNonQuery().ToString();
            }
            catch(Exception e) 
            { 
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SQLIsle-1", e.Message, "");
            }

            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen) || Donen == "0")
                Donen = "-1";
            
            System.GC.SuppressFinalize(SqlCom);
            return Donen;
        
        
        }
        public static string SQLIsle(string TamSorgu,SqlParameter[] pCollection)
        {

            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteNonQuery().ToString();
            }
            catch(Exception e)
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SQLIsle-2", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen) || Donen == "0")
                Donen = "-1";

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            return Donen;


        }
        public static void SQLIsle(string TamSorgu, SqlParameter[] pCollection, ref string GelenSonuc)
        {

            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();
            }
            catch(Exception e) 
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SQLIsle-3", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();


            if (string.IsNullOrEmpty(Donen) || Donen == "0")
                Donen = "-1";

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            GelenSonuc = Donen;


        }
        /// <summary>
        /// "-1" dönerse Yoktur!
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Sart"></param>
        /// <returns></returns>
        public static string Varmi(string TabloAdi, string Sart)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select Count(ID) as AKB from " + TabloAdi + " " + Sart, Baglanti());
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();
            }
            catch(Exception e) 
            { 
               Donen = "-1";
               // DigerIslemler.HataYaz("AKBclass-Varmi-1", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            
            if (string.IsNullOrEmpty(Donen)||Donen == "0")
                Donen = "-1";
            
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        /// <summary>
        /// "-1" dönerse Yoktur! Parametreleri eklemeyi unutma!
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Sart"></param>
        /// <param name="pCollection"></param>
        /// <returns></returns>
        public static string Varmi(string TabloAdi, string Sart,SqlParameter[] pCollection)
        {
            string Donen;
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select Count(ID) as AKB from " + TabloAdi + " " + Sart, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();
            }
            catch(Exception e)
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-Varmi-2", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            
            if (string.IsNullOrEmpty(Donen)||Donen == "0")
                Donen = "-1";

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            return Donen.TrimEnd();
        }
        public static DataTable TabloDoldur(string TabloAdi, string Sart)
        {

            DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " select * from " + TabloAdi + " " + Sart, Baglanti());
            try
            {
                da.Fill(dt);
            }
            catch(Exception e) 
            { 
            //    dt = null;
                // DigerIslemler.HataYaz("AKBclass-TabloDoldur-1", e.Message, "");
            }
            
            System.GC.SuppressFinalize(da);
            return dt;


        }
        public static DataTable TabloDoldur(string TamSorgu)
        {

            DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
               // dt = null;
                // DigerIslemler.HataYaz("AKBclass-TabloDoldur-2", e.Message, "");
            }
            
            System.GC.SuppressFinalize(da);
            return dt;

        }
        public static DataTable TabloDoldur(string TamSorgu,SqlParameter[] pCollection)
        {

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " " + TamSorgu, Baglanti());
            da.SelectCommand.Parameters.AddRange(pCollection);
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                // dt = null;
                // DigerIslemler.HataYaz("AKBclass-TabloDoldur-2", e.Message, "");
            }
            da.SelectCommand.Parameters.Clear();
            System.GC.SuppressFinalize(da);
            return dt;

        }
        /// <summary>
        /// Parametreleri arasına virgül koyarak doğru Column ismiyle gönder
        /// donen dizi içerisinde parametre ile gönderdiğin colum değerleri gee aynı sıra(index numarası) ile yeralacak
        /// null değer dönerse hata vardır !
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Parametreler"></param>
        /// <param name="Sart"></param>
        /// <returns></returns>
        public static string[] TekKayitDondur(string TabloAdi, string Parametreler, string Sart)
        {
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " SELECT "+Parametreler+" FROM "+TabloAdi+" "+Sart, Baglanti());
            SqlCom.Connection.Open();
            SqlDataReader dr = SqlCom.ExecuteReader(CommandBehavior.CloseConnection);
            string[] Param = Parametreler.Split(',');
            for (int i = 0; i < Param.Length; i++)
            {
                Param[i] = "-1";
            }
            try
            {
                while (dr.Read())
                {
                    for (int i = 0; i<Param.Length; i++)
                    {
                        if (string.IsNullOrEmpty(dr[i].ToString()))
                            Param[i] = "-1";
                        else
                            Param[i] = dr[i].ToString();
                    }
                }
            }
                
            catch(Exception e)
            {
                // DigerIslemler.HataYaz("AKBclass-TekKayitDondur-1", e.Message, "");
              
            }
            dr.Close();

            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            System.GC.SuppressFinalize(SqlCom);
            System.GC.SuppressFinalize(dr);
            return Param;

        }
        /// <summary>
        /// Parametreleri arasına virgül koyarak doğru Column ismiyle gönder
        /// donen dizi içerisinde parametre ile gönderdiğin colum değerleri gee aynı sıra(index numarası) ile yeralacak
        /// null değer dönerse hata vardır !
        /// </summary>
        /// <param name="TabloAdi"></param>
        /// <param name="Parametreler"></param>
        /// <param name="Sart"></param>
        /// <returns></returns>
        public static string[] TekKayitDondur(string TabloAdi, string Parametreler, string Sart, SqlParameter[] pCollection)
        {
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " SELECT " + Parametreler + " FROM " + TabloAdi + " " + Sart, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            SqlCom.Connection.Open();
            SqlDataReader dr = SqlCom.ExecuteReader(CommandBehavior.CloseConnection);
            string[] Param = Parametreler.Split(',');
            try
            {
                while (dr.Read())
                {
                    for (int i = 0; i < Param.Length; i++)
                    {
                        if (string.IsNullOrEmpty(dr[i].ToString()))
                            Param[i] = "-1";
                        else
                            Param[i] = dr[i].ToString();
                    }
                }
            }

            catch (Exception e)
            {
                Param = null;
                // DigerIslemler.HataYaz("AKBclass-TekKayitDondur-2", e.Message, "");

            }
            dr.Close();

            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            System.GC.SuppressFinalize(dr);
            return Param;

        }
        public static Hashtable TekKayitDondurHT(string TabloAdi, string Parametreler, string Sart)
        {
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " SELECT " + Parametreler + " FROM " + TabloAdi + " " + Sart, Baglanti());
            SqlCom.Connection.Open();
            SqlDataReader dr = SqlCom.ExecuteReader(CommandBehavior.CloseConnection);
            string[] Param = Parametreler.Split(',');
            Hashtable ht = new Hashtable();
            
            try
            {
                while (dr.Read())
                {
                    for (int i = 0; i < Param.Length; i++)
                    {
                        if (string.IsNullOrEmpty(dr[i].ToString()))
                            ht[Param[i].ToString()] = "-1";
                        else
                            ht[Param[i].ToString()] = dr[i].ToString();
                    }
                }
            }

            catch (Exception e)
            {
                // DigerIslemler.HataYaz("AKBclass-TekKayitDondurHT-1", e.Message, "");

            }
            dr.Close();

            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();
           
            System.GC.SuppressFinalize(Param);
            System.GC.SuppressFinalize(SqlCom);
            System.GC.SuppressFinalize(dr);
            return ht;

        }
        public static Hashtable TekKayitDondurHT(string TabloAdi, string Parametreler, string Sart, SqlParameter[] pCollection)
        {
            SqlCommand SqlCom = new SqlCommand(ConfigurationSettings.AppSettings["SqlTarihFormat"].ToString() + " SELECT " + Parametreler + " FROM " + TabloAdi + " " + Sart, Baglanti());
            SqlCom.Parameters.AddRange(pCollection);
            SqlCom.Connection.Open();
            SqlDataReader dr = SqlCom.ExecuteReader(CommandBehavior.CloseConnection);
            string[] Param = Parametreler.Split(',');
            Hashtable ht = new Hashtable();
            try
            {
                while (dr.Read())
                {
                    for (int i = 0; i < Param.Length; i++)
                    {
                        if (string.IsNullOrEmpty(dr[i].ToString()))
                            ht[Param[i].ToString()] = "-1";
                        else
                            ht[Param[i].ToString()] = dr[i].ToString();
                    }
                }
            }

            catch (Exception e)
            {
                Param = null;
                // DigerIslemler.HataYaz("AKBclass-TekKayitDondurHT-2", e.Message, "");

            }
            dr.Close();

            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(Param);
            System.GC.SuppressFinalize(SqlCom);
            System.GC.SuppressFinalize(dr);
            return ht;

        }
        public static string Karantina(string IP, string Sebep, bool KarantinaKaldirDevredemi)
        { 
            string Durum = null;
            
            SqlCommand SqlCom = new SqlCommand();
            SqlCom.Connection = Baglanti();
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlCom.CommandText = "Karantina";
           
            #region SPparametreler

            SqlParameter pIP = new SqlParameter("@IP", SqlDbType.NVarChar,15);
            SqlParameter pSebep = new SqlParameter("@Sebep", SqlDbType.NVarChar,200);
            SqlParameter pKarantinaKaldirDevredemi = new SqlParameter("@KarantinaKaldirDevredemi", SqlDbType.Bit);

            SqlCom.Parameters.Add(pIP);
            SqlCom.Parameters.Add(pSebep);
            SqlCom.Parameters.Add(pKarantinaKaldirDevredemi);

            pIP.Value = IP;
            pSebep.Value = Sebep;
            pKarantinaKaldirDevredemi.Value = KarantinaKaldirDevredemi;

            #endregion

            try
            {
                SqlCom.Connection.Open();
                Durum = SqlCom.ExecuteScalar().ToString();
                
            }
             catch(Exception e) 
            {
                // DigerIslemler.HataYaz("AKBclass-Karantina", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            if (!string.IsNullOrEmpty(Durum))
            {
                if (Durum.StartsWith("False"))
                    Durum = "Siteye Giriş İzniniz İptal Edildi";
                else
                    Durum = Durum.Remove(0, Durum.IndexOf("-", 0) + 1);
            }
            else
                Durum = "Yaptığınız İşlem Güvenlik Sorunu Oluşturuyor, Güvelik Katmanı Site İçi Hareketlerinizi Karantinaya Aldı.";
            
            System.GC.SuppressFinalize(SqlCom);
            return Durum;
        }
        /// <summary>
        /// "-1" ise hata var. 
        /// </summary>
        /// <param name="SpAdi"> tetiklemek istediğin sp nin adını yaz.</param>
        /// <param name="parametreler"> sp de gerekli parametreleri gönder.</param>
        /// <returns></returns>
        public static string SpTetikle(string SpAdi)
        {
            string Donen = "0";

            SqlCommand SqlCom = new SqlCommand();
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlCom.CommandText = SpAdi;
            SqlCom.Connection = Baglanti();

            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();

            }
            catch (Exception e)
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SpTetikle Parametresiz", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            System.GC.SuppressFinalize(SqlCom);
            return Donen;
        }
        /// <summary>
        /// "-1" ise hata var. 
        /// </summary>
        /// <param name="SpAdi"> tetiklemek istediğin sp nin adını yaz.</param>
        /// <param name="parametreler"> sp de gerekli parametreleri gönder.</param>
        /// <returns></returns>
        public static DataTable SpTetikleTabloDoldur(string SpAdi, SqlParameter[] pCollection)
        {
            DataTable dt = new DataTable();
            
            SqlCommand SqlCom = new SqlCommand();
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlCom.CommandText = SpAdi;
            SqlCom.Parameters.AddRange(pCollection);
            SqlCom.Connection = Baglanti();

            SqlDataAdapter da = new SqlDataAdapter(SqlCom);
            
            try
            { 
                SqlCom.Connection.Open();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                // dt = null;
                // DigerIslemler.HataYaz("AKBclass-TabloDoldur-2", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
              SqlCom.Connection.Close();

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            System.GC.SuppressFinalize(da);
            return dt;


        }
        public static string SpTetikle(string SpAdi, SqlParameter[] parametreler)
        {
            string Donen = "0";

            SqlCommand SqlCom = new SqlCommand();
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlCom.CommandText = SpAdi;
            SqlCom.Parameters.AddRange(parametreler);
            SqlCom.Connection = Baglanti();

            try
            {
                SqlCom.Connection.Open();
                Donen = SqlCom.ExecuteScalar().ToString();

            }
            catch (Exception e)
            {
                Donen = "-1";
                // DigerIslemler.HataYaz("AKBclass-SpTetikle", e.Message, "");
            }
            if (SqlCom.Connection.State == ConnectionState.Open)
                SqlCom.Connection.Close();

            SqlCom.Parameters.Clear();
            System.GC.SuppressFinalize(SqlCom);
            return Donen;
        }
        /// <summary>
        /// varsayılan value değeri ID dir
        /// </summary>
        /// <param name="C"></param>
        /// <param name="Sorgu"></param>
        /// <param name="IlkDeger"></param>
        /// <param name="ColumAd"></param>
        public static void ComboBoxDoldur(ref DropDownList C, string Sorgu, string IlkDeger,string ColumAd)
        {
            C.Items.Clear();
            C.Items.Add(new ListItem(IlkDeger, "0"));

            try
            {
                DataTable dt = AKBclass.DBMudahale.TabloDoldur(Sorgu);

                for (int i = 0; i < dt.Rows.Count; i++)
                    C.Items.Add(new ListItem(dt.Rows[i][ColumAd].ToString(), dt.Rows[i]["ID"].ToString()));
            }
            catch (Exception e)
            {
                // DigerIslemler.HataYaz("AKBclass-ComboBoxDoldur", e.Message, "");
            }
        }
        public static void ListBoxDoldur(ref ListBox C, string Sorgu, string ColumAd)
        {
            C.Items.Clear();
            try
            {
                DataTable dt = AKBclass.DBMudahale.TabloDoldur(Sorgu);

                for (int i = 0; i < dt.Rows.Count; i++)
                    C.Items.Add(new ListItem(dt.Rows[i][ColumAd].ToString(), dt.Rows[i]["ID"].ToString()));
            }
            catch (Exception e)
            {
                // DigerIslemler.HataYaz("AKBclass-ListBoxDoldur", e.Message, "");
            }
        }
    }
  
}