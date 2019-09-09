using System.Data;
using System.Data.SqlClient;

namespace MovieRent.Database
{
    class Databases
    {
        private SqlConnection Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

      
        public Databases()
        {
            string ConnString = @"Data Source=WT135-826LSW\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            Conn.ConnectionString = ConnString;
            Cmd.Connection = Conn;
        }

        public DataTable FillDGV(string querySelect)
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter(querySelect, Conn))
            {
                Conn.Open();
                da.Fill(dt);
                Conn.Close();
            }
            return dt;
        }

        public void MovieInsert(string queryInsertUpdateDelete)
        {
            string queryInsert = "Insert into Movies (Rating, Title, Year, Rental_Cost, Copies,Plot, Genre) Values (txt_Rating.Text)";


            Cmd.CommandText = queryInsertUpdateDelete;
            Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
        }

    }
}
