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
            string ConnString = @"Data Source=DPKASTG-05\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
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

    }
}
