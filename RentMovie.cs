using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRent
{
    public partial class MovieRent : Form
    {
        Database.Databases Obj_Database = new Database.Databases();
        public MovieRent()
        {
            InitializeComponent();
        }
        private void Btn_RentOutMovie_Click(object sender, System.EventArgs e)
        {
            DGV_RentMovie.DataSource = null;
            try
            {
                string queryObj = "Select * from RentOutMovies";
                DGV_RentMovie.DataSource = Obj_Database.FillDGV(queryObj);
                DGV_RentMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_AllMovies_Click(object sender, EventArgs e)
        {
            DGV_RentMovie.DataSource = null;
            try
            {
                string queryObj = "Select * from AllMovies";
                DGV_RentMovie.DataSource = Obj_Database.FillDGV(queryObj);
                DGV_RentMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_CustomerWithMostVideos_Click(object sender, EventArgs e)
        {
            DGV_RentMovie.DataSource = null;
            try
            {
                string queryObj = "Select * from CustomerWithMostVideos";
                DGV_RentMovie.DataSource = Obj_Database.FillDGV(queryObj);
                DGV_RentMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_AddMovie_Click(object sender, EventArgs e)
        {
            if (txt_Rating.Text != "" && txt_Title.Text != "" && txt_Year.Text != "" && txt_RentalCost.Text != "" && txt_Copies.Text != "" && txt_Plot.Text != "" && txt_Genre.Text != "")
            {


                 Obj_Database.MovieInsert(txt_Rating.Text,txt_Title.Text,txt_Year.Text,txt_RentalCost.Text,txt_Copies.Text,txt_Plot.Text,txt_Genre.Text);

                txt_MovieID.Text = "";
                txt_Rating.Text = "";
                txt_Title.Text = "";
                txt_Year.Text = "";
                txt_RentalCost.Text = "";
                txt_Copies.Text = "";
                txt_Plot.Text = "";
                txt_Genre.Text = "";

            }
        }
    }
}
