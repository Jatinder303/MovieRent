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

    }
}
