using System;
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

        private void MovieRent_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            DGV_RentMovie.DataSource = null;
            try
            {
                string queryObj = "Select * from Movies";
                DGV_RentMovie.DataSource = Obj_Database.FillDGV(queryObj);
                DGV_RentMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_SelectedRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_RentMovie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                txt_MovieID.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Rating.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Title.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Year.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_RentalCost.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Copies.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_Plot.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_Genre.Text = DGV_RentMovie.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
        private void Btn_AddMovie_Click(object sender, EventArgs e)
        {
            if (txt_Rating.Text != "" && txt_Title.Text != "" && txt_Year.Text != "" && txt_RentalCost.Text != "" && txt_Copies.Text != "" && txt_Plot.Text != "" && txt_Genre.Text != "")
            {
                string message = Obj_Database.MovieInsert(txt_Rating.Text, txt_Title.Text, txt_Year.Text, txt_RentalCost.Text, txt_Copies.Text, txt_Plot.Text, txt_Genre.Text);
                MessageBox.Show(message);
                txt_MovieID.Text = "";
                txt_Rating.Text = "";
                txt_Title.Text = "";
                txt_Year.Text = "";
                txt_RentalCost.Text = "";
                txt_Copies.Text = "";
                txt_Plot.Text = "";
                txt_Genre.Text = "";
                load();
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to movie");
            }
        }

        private void btn_UpdateMovie_Click(object sender, EventArgs e)
        {
            string message = Obj_Database.MovieUpdate(Convert.ToInt32(txt_MovieID.Text), txt_Rating.Text, txt_Title.Text, txt_Year.Text, txt_RentalCost.Text, txt_Copies.Text, txt_Plot.Text, txt_Genre.Text);
            MessageBox.Show(message);
            txt_MovieID.Text = "";
            txt_Rating.Text = "";
            txt_Title.Text = "";
            txt_Year.Text = "";
            txt_RentalCost.Text = "";
            txt_Copies.Text = "";
            txt_Plot.Text = "";
            txt_Genre.Text = "";
            load();
        }

        private void btn_DeleteMovie_Click(object sender, EventArgs e)
        {
            string message = Obj_Database.MovieDelete(Convert.ToInt32(txt_MovieID.Text));
            MessageBox.Show(message);
            txt_MovieID.Text = "";
            txt_Rating.Text = "";
            txt_Title.Text = "";
            txt_Year.Text = "";
            txt_RentalCost.Text = "";
            txt_Copies.Text = "";
            txt_Plot.Text = "";
            txt_Genre.Text = "";
            load();
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


    }
}
