using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }
        public bool AddChar_Se(Session S)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Session(Name,Duration,Donation,TaxiDate) VALUES(@name,@duration,@donation,@taxidate)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", S.Name);
                cmd.Parameters.AddWithValue("@duration", S.Duration);
                cmd.Parameters.AddWithValue("@donation", S.Donation);
                cmd.Parameters.AddWithValue("@taxidate", S.TaxiDate);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {
                string ExcMessage = Ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public int GetID(DateTime dateTime)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Session WHERE TaxiDate = @taxidate";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@taxidate", dateTime);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Session S = new Session();
                while (reader.Read())
                {
                    S.ID = reader.GetInt32(0);
                    S.Name = reader.GetString(1);
                    S.Duration = reader.GetInt32(2);
                    S.Donation = reader.GetDecimal(3);
                    S.TaxiDate = reader.GetDateTime(4);
                }
                return S.ID;
            }
            catch (Exception Ex)
            {
                string mesaj = Ex.Message;
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddChar_To(Session S)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Total(Name,Duration,Donation,TaxiDate) VALUES(@name,@duration,@donation,@taxidate)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", S.Name);
                cmd.Parameters.AddWithValue("@duration", S.Duration);
                cmd.Parameters.AddWithValue("@donation", S.Donation);
                cmd.Parameters.AddWithValue("@taxidate", S.TaxiDate);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UpdateParam(int dura, decimal dona, int ID)
        {
            try
            {
                cmd.CommandText = "UPDATE Session SET Duration=@duration, Donation=@donation WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@duration", dura);
                cmd.Parameters.AddWithValue("@donation", dona);
                cmd.Parameters.AddWithValue("@id", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Total> ListChar_To()
        {
            List<Total> Chars_To = new List<Total>();
            try
            {
                cmd.CommandText = "SELECT * FROM Total";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Total To = new Total();
                    To.ID = reader.GetInt32(0);
                    To.Name = reader.GetString(1);
                    To.Duration = reader.GetInt32(2);
                    To.Donation = reader.GetDecimal(3);
                    To.TaxiDate = reader.GetDateTime(4);
                    Chars_To.Add(To);
                }
                return Chars_To;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
