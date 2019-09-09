namespace MovieRent
{
    partial class MovieRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_RentMovie = new System.Windows.Forms.DataGridView();
            this.btn_RentOutMovie = new System.Windows.Forms.Button();
            this.btn_AllMovies = new System.Windows.Forms.Button();
            this.btn_CustomerWithMostVideos = new System.Windows.Forms.Button();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.txt_Rating = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_RentalCost = new System.Windows.Forms.TextBox();
            this.txt_Copies = new System.Windows.Forms.TextBox();
            this.txt_Plot = new System.Windows.Forms.TextBox();
            this.lbl_MovieID = new System.Windows.Forms.Label();
            this.txt_Genre = new System.Windows.Forms.TextBox();
            this.lbl_Rating = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_RentalCost = new System.Windows.Forms.Label();
            this.lbl_Copies = new System.Windows.Forms.Label();
            this.lbl_Plot = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.btn_UpdateMovie = new System.Windows.Forms.Button();
            this.btn_DeleteMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RentMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_RentMovie
            // 
            this.DGV_RentMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RentMovie.Location = new System.Drawing.Point(12, 12);
            this.DGV_RentMovie.Name = "DGV_RentMovie";
            this.DGV_RentMovie.Size = new System.Drawing.Size(448, 251);
            this.DGV_RentMovie.TabIndex = 0;
            this.DGV_RentMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SelectedRow);
            // 
            // btn_RentOutMovie
            // 
            this.btn_RentOutMovie.Location = new System.Drawing.Point(12, 393);
            this.btn_RentOutMovie.Name = "btn_RentOutMovie";
            this.btn_RentOutMovie.Size = new System.Drawing.Size(165, 23);
            this.btn_RentOutMovie.TabIndex = 1;
            this.btn_RentOutMovie.Text = "Rent Out Movies";
            this.btn_RentOutMovie.UseVisualStyleBackColor = true;
            this.btn_RentOutMovie.Click += new System.EventHandler(this.Btn_RentOutMovie_Click);
            // 
            // btn_AllMovies
            // 
            this.btn_AllMovies.Location = new System.Drawing.Point(12, 351);
            this.btn_AllMovies.Name = "btn_AllMovies";
            this.btn_AllMovies.Size = new System.Drawing.Size(165, 23);
            this.btn_AllMovies.TabIndex = 2;
            this.btn_AllMovies.Text = "All Movies";
            this.btn_AllMovies.UseVisualStyleBackColor = true;
            this.btn_AllMovies.Click += new System.EventHandler(this.Btn_AllMovies_Click);
            // 
            // btn_CustomerWithMostVideos
            // 
            this.btn_CustomerWithMostVideos.Location = new System.Drawing.Point(12, 311);
            this.btn_CustomerWithMostVideos.Name = "btn_CustomerWithMostVideos";
            this.btn_CustomerWithMostVideos.Size = new System.Drawing.Size(165, 23);
            this.btn_CustomerWithMostVideos.TabIndex = 3;
            this.btn_CustomerWithMostVideos.Text = "Customer With Most Videos";
            this.btn_CustomerWithMostVideos.UseVisualStyleBackColor = true;
            this.btn_CustomerWithMostVideos.Click += new System.EventHandler(this.Btn_CustomerWithMostVideos_Click);
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Enabled = false;
            this.txt_MovieID.Location = new System.Drawing.Point(644, 25);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(100, 20);
            this.txt_MovieID.TabIndex = 4;
            // 
            // txt_Rating
            // 
            this.txt_Rating.Location = new System.Drawing.Point(644, 71);
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.Size = new System.Drawing.Size(100, 20);
            this.txt_Rating.TabIndex = 5;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(644, 114);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(100, 20);
            this.txt_Title.TabIndex = 6;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(644, 157);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 20);
            this.txt_Year.TabIndex = 7;
            // 
            // txt_RentalCost
            // 
            this.txt_RentalCost.Location = new System.Drawing.Point(644, 202);
            this.txt_RentalCost.Name = "txt_RentalCost";
            this.txt_RentalCost.Size = new System.Drawing.Size(100, 20);
            this.txt_RentalCost.TabIndex = 8;
            // 
            // txt_Copies
            // 
            this.txt_Copies.Location = new System.Drawing.Point(644, 243);
            this.txt_Copies.Name = "txt_Copies";
            this.txt_Copies.Size = new System.Drawing.Size(100, 20);
            this.txt_Copies.TabIndex = 9;
            // 
            // txt_Plot
            // 
            this.txt_Plot.Location = new System.Drawing.Point(644, 287);
            this.txt_Plot.Name = "txt_Plot";
            this.txt_Plot.Size = new System.Drawing.Size(100, 20);
            this.txt_Plot.TabIndex = 10;
            // 
            // lbl_MovieID
            // 
            this.lbl_MovieID.AutoSize = true;
            this.lbl_MovieID.Location = new System.Drawing.Point(536, 25);
            this.lbl_MovieID.Name = "lbl_MovieID";
            this.lbl_MovieID.Size = new System.Drawing.Size(50, 13);
            this.lbl_MovieID.TabIndex = 11;
            this.lbl_MovieID.Text = "Movie ID";
            // 
            // txt_Genre
            // 
            this.txt_Genre.Location = new System.Drawing.Point(644, 330);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(100, 20);
            this.txt_Genre.TabIndex = 12;
            // 
            // lbl_Rating
            // 
            this.lbl_Rating.AutoSize = true;
            this.lbl_Rating.Location = new System.Drawing.Point(536, 71);
            this.lbl_Rating.Name = "lbl_Rating";
            this.lbl_Rating.Size = new System.Drawing.Size(38, 13);
            this.lbl_Rating.TabIndex = 13;
            this.lbl_Rating.Text = "Rating";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(536, 114);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 14;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(536, 164);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(29, 13);
            this.lbl_Year.TabIndex = 15;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_RentalCost
            // 
            this.lbl_RentalCost.AutoSize = true;
            this.lbl_RentalCost.Location = new System.Drawing.Point(536, 205);
            this.lbl_RentalCost.Name = "lbl_RentalCost";
            this.lbl_RentalCost.Size = new System.Drawing.Size(62, 13);
            this.lbl_RentalCost.TabIndex = 16;
            this.lbl_RentalCost.Text = "Rental Cost";
            // 
            // lbl_Copies
            // 
            this.lbl_Copies.AutoSize = true;
            this.lbl_Copies.Location = new System.Drawing.Point(536, 243);
            this.lbl_Copies.Name = "lbl_Copies";
            this.lbl_Copies.Size = new System.Drawing.Size(39, 13);
            this.lbl_Copies.TabIndex = 17;
            this.lbl_Copies.Text = "Copies";
            // 
            // lbl_Plot
            // 
            this.lbl_Plot.AutoSize = true;
            this.lbl_Plot.Location = new System.Drawing.Point(536, 287);
            this.lbl_Plot.Name = "lbl_Plot";
            this.lbl_Plot.Size = new System.Drawing.Size(25, 13);
            this.lbl_Plot.TabIndex = 18;
            this.lbl_Plot.Text = "Plot";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Location = new System.Drawing.Point(536, 330);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre.TabIndex = 19;
            this.lbl_Genre.Text = "Genre";
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.Location = new System.Drawing.Point(402, 379);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_AddMovie.TabIndex = 20;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.UseVisualStyleBackColor = true;
            this.btn_AddMovie.Click += new System.EventHandler(this.Btn_AddMovie_Click);
            // 
            // btn_UpdateMovie
            // 
            this.btn_UpdateMovie.Location = new System.Drawing.Point(539, 379);
            this.btn_UpdateMovie.Name = "btn_UpdateMovie";
            this.btn_UpdateMovie.Size = new System.Drawing.Size(91, 23);
            this.btn_UpdateMovie.TabIndex = 21;
            this.btn_UpdateMovie.Text = "Update Movie";
            this.btn_UpdateMovie.UseVisualStyleBackColor = true;
            this.btn_UpdateMovie.Click += new System.EventHandler(this.btn_UpdateMovie_Click);
            // 
            // btn_DeleteMovie
            // 
            this.btn_DeleteMovie.Location = new System.Drawing.Point(679, 379);
            this.btn_DeleteMovie.Name = "btn_DeleteMovie";
            this.btn_DeleteMovie.Size = new System.Drawing.Size(94, 23);
            this.btn_DeleteMovie.TabIndex = 22;
            this.btn_DeleteMovie.Text = "Delete Movie";
            this.btn_DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // MovieRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DeleteMovie);
            this.Controls.Add(this.btn_UpdateMovie);
            this.Controls.Add(this.btn_AddMovie);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Plot);
            this.Controls.Add(this.lbl_Copies);
            this.Controls.Add(this.lbl_RentalCost);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Rating);
            this.Controls.Add(this.txt_Genre);
            this.Controls.Add(this.lbl_MovieID);
            this.Controls.Add(this.txt_Plot);
            this.Controls.Add(this.txt_Copies);
            this.Controls.Add(this.txt_RentalCost);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.txt_Rating);
            this.Controls.Add(this.txt_MovieID);
            this.Controls.Add(this.btn_CustomerWithMostVideos);
            this.Controls.Add(this.btn_AllMovies);
            this.Controls.Add(this.btn_RentOutMovie);
            this.Controls.Add(this.DGV_RentMovie);
            this.Name = "MovieRent";
            this.Text = "Movie Rent";
            this.Load += new System.EventHandler(this.MovieRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RentMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_RentMovie;
        private System.Windows.Forms.Button btn_RentOutMovie;
        private System.Windows.Forms.Button btn_AllMovies;
        private System.Windows.Forms.Button btn_CustomerWithMostVideos;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.TextBox txt_Rating;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_RentalCost;
        private System.Windows.Forms.TextBox txt_Copies;
        private System.Windows.Forms.TextBox txt_Plot;
        private System.Windows.Forms.Label lbl_MovieID;
        private System.Windows.Forms.TextBox txt_Genre;
        private System.Windows.Forms.Label lbl_Rating;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_RentalCost;
        private System.Windows.Forms.Label lbl_Copies;
        private System.Windows.Forms.Label lbl_Plot;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.Button btn_UpdateMovie;
        private System.Windows.Forms.Button btn_DeleteMovie;
    }
}

