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
            // 
            // btn_RentOutMovie
            // 
            this.btn_RentOutMovie.Location = new System.Drawing.Point(574, 362);
            this.btn_RentOutMovie.Name = "btn_RentOutMovie";
            this.btn_RentOutMovie.Size = new System.Drawing.Size(165, 23);
            this.btn_RentOutMovie.TabIndex = 1;
            this.btn_RentOutMovie.Text = "Rent Out Movies";
            this.btn_RentOutMovie.UseVisualStyleBackColor = true;
            this.btn_RentOutMovie.Click += new System.EventHandler(this.Btn_RentOutMovie_Click);
            // 
            // btn_AllMovies
            // 
            this.btn_AllMovies.Location = new System.Drawing.Point(333, 362);
            this.btn_AllMovies.Name = "btn_AllMovies";
            this.btn_AllMovies.Size = new System.Drawing.Size(165, 23);
            this.btn_AllMovies.TabIndex = 2;
            this.btn_AllMovies.Text = "All Movies";
            this.btn_AllMovies.UseVisualStyleBackColor = true;
            // 
            // MovieRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AllMovies);
            this.Controls.Add(this.btn_RentOutMovie);
            this.Controls.Add(this.DGV_RentMovie);
            this.Name = "MovieRent";
            this.Text = "Movie Rent";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RentMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_RentMovie;
        private System.Windows.Forms.Button btn_RentOutMovie;
        private System.Windows.Forms.Button btn_AllMovies;
    }
}

