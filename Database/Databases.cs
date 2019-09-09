using System;
using System.Data;
using System.Data.SqlClient;

namespace MovieRent.Database
{
    class Databases
    {
        private SqlConnection Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;


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

        public string MovieInsert(string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            //This method is used to insert data into movie table
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Conn;

                QueryString = "Insert into Movies(Rating, Title, Year, Rental_Cost, Plot, Genre,Copies) Values( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre, @copies)";

                Cmd.Parameters.AddWithValue("@Rating", Rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Plot", Plot);
                Cmd.Parameters.AddWithValue("@Genre", Genre);
                Cmd.Parameters.AddWithValue("@copies", Copies);
                Cmd.CommandText = QueryString;

                //connection opened
                Conn.Open();

                // Executed query
                Cmd.ExecuteNonQuery();

                return "Movie is inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Conn != null)
                {
                    Conn.Close();
                }
            }
        }
        public string MovieUpdate(int MovieID, string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {//this method is used to update the movie 
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Conn;
                QueryString = "Update Movies Set Rating = @Rating, Title = @Title, Year = @Year,Rental_Cost = @RentalCost,  Plot = @Plot, Genre = @Genre, copies = @copies where MovieID like @MovieID";

                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.Parameters.AddWithValue("@Rating", Rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@Plot", Plot);
                Cmd.Parameters.AddWithValue("@Genre", Genre);
                Cmd.Parameters.AddWithValue("@copies", Copies);
                Cmd.Parameters.AddWithValue("@RentalCost", Rental_Cost);

                Cmd.CommandText = QueryString;

                //connection opened
                Conn.Open();

                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie is Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Conn != null)
                {
                    Conn.Close();
                }
            }
        }

    }
}
