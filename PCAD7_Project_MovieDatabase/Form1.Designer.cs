namespace PCAD7_Project_MovieDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movieGrid = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.btn1Star = new System.Windows.Forms.RadioButton();
            this.btn5Star = new System.Windows.Forms.RadioButton();
            this.btn4Star = new System.Windows.Forms.RadioButton();
            this.btn3Star = new System.Windows.Forms.RadioButton();
            this.btn2Star = new System.Windows.Forms.RadioButton();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRateMovie = new System.Windows.Forms.Button();
            this.btnRecommendMovie = new System.Windows.Forms.Button();
            this.txtNameToRecommend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRateMovie = new System.Windows.Forms.GroupBox();
            this.lblRateMovie = new System.Windows.Forms.Label();
            this.groupRecommendations = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupUpdateRating = new System.Windows.Forms.GroupBox();
            this.btnUpdate1Star = new System.Windows.Forms.RadioButton();
            this.btnUpdate5Star = new System.Windows.Forms.RadioButton();
            this.btnUpdate4Star = new System.Windows.Forms.RadioButton();
            this.btnUpdate2Star = new System.Windows.Forms.RadioButton();
            this.btnUpdate3Star = new System.Windows.Forms.RadioButton();
            this.btnUpdateRating = new System.Windows.Forms.Button();
            this.btnDeleteRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).BeginInit();
            this.groupRateMovie.SuspendLayout();
            this.groupRecommendations.SuspendLayout();
            this.groupUpdateRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieGrid
            // 
            this.movieGrid.AllowUserToOrderColumns = true;
            this.movieGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieGrid.BackgroundColor = System.Drawing.Color.Ivory;
            this.movieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.movieGrid.Location = new System.Drawing.Point(62, 50);
            this.movieGrid.Name = "movieGrid";
            this.movieGrid.RowHeadersWidth = 82;
            this.movieGrid.RowTemplate.Height = 33;
            this.movieGrid.Size = new System.Drawing.Size(1617, 387);
            this.movieGrid.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bodoni MT Condensed", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(34, 185);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(143, 27);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "Movie Title:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(34, 243);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(90, 27);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(34, 304);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(90, 27);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating:";
            // 
            // btn1Star
            // 
            this.btn1Star.AutoSize = true;
            this.btn1Star.Location = new System.Drawing.Point(178, 300);
            this.btn1Star.Name = "btn1Star";
            this.btn1Star.Size = new System.Drawing.Size(105, 31);
            this.btn1Star.TabIndex = 4;
            this.btn1Star.TabStop = true;
            this.btn1Star.Text = "1 Star";
            this.btn1Star.UseVisualStyleBackColor = true;
            // 
            // btn5Star
            // 
            this.btn5Star.AutoSize = true;
            this.btn5Star.Location = new System.Drawing.Point(674, 300);
            this.btn5Star.Name = "btn5Star";
            this.btn5Star.Size = new System.Drawing.Size(105, 31);
            this.btn5Star.TabIndex = 8;
            this.btn5Star.TabStop = true;
            this.btn5Star.Text = "5 Star";
            this.btn5Star.UseVisualStyleBackColor = true;
            // 
            // btn4Star
            // 
            this.btn4Star.AutoSize = true;
            this.btn4Star.Location = new System.Drawing.Point(548, 300);
            this.btn4Star.Name = "btn4Star";
            this.btn4Star.Size = new System.Drawing.Size(105, 31);
            this.btn4Star.TabIndex = 7;
            this.btn4Star.TabStop = true;
            this.btn4Star.Text = "4 Star";
            this.btn4Star.UseVisualStyleBackColor = true;
            // 
            // btn3Star
            // 
            this.btn3Star.AutoSize = true;
            this.btn3Star.Location = new System.Drawing.Point(425, 300);
            this.btn3Star.Name = "btn3Star";
            this.btn3Star.Size = new System.Drawing.Size(105, 31);
            this.btn3Star.TabIndex = 6;
            this.btn3Star.TabStop = true;
            this.btn3Star.Text = "3 Star";
            this.btn3Star.UseVisualStyleBackColor = true;
            // 
            // btn2Star
            // 
            this.btn2Star.AutoSize = true;
            this.btn2Star.Location = new System.Drawing.Point(302, 300);
            this.btn2Star.Name = "btn2Star";
            this.btn2Star.Size = new System.Drawing.Size(105, 31);
            this.btn2Star.TabIndex = 5;
            this.btn2Star.TabStop = true;
            this.btn2Star.Text = "2 Star";
            this.btn2Star.UseVisualStyleBackColor = true;
            // 
            // comboGenre
            // 
            this.comboGenre.BackColor = System.Drawing.Color.Ivory;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(180, 235);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(581, 35);
            this.comboGenre.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Ivory;
            this.txtTitle.Location = new System.Drawing.Point(180, 176);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(581, 36);
            this.txtTitle.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Ivory;
            this.txtName.Location = new System.Drawing.Point(180, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(581, 36);
            this.txtName.TabIndex = 1;
            // 
            // btnRateMovie
            // 
            this.btnRateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnRateMovie.ForeColor = System.Drawing.Color.Black;
            this.btnRateMovie.Location = new System.Drawing.Point(236, 373);
            this.btnRateMovie.Name = "btnRateMovie";
            this.btnRateMovie.Size = new System.Drawing.Size(323, 77);
            this.btnRateMovie.TabIndex = 9;
            this.btnRateMovie.Text = "Rate Movie";
            this.btnRateMovie.UseVisualStyleBackColor = false;
            this.btnRateMovie.Click += new System.EventHandler(this.btnRateMovie_Click);
            // 
            // btnRecommendMovie
            // 
            this.btnRecommendMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnRecommendMovie.ForeColor = System.Drawing.Color.Black;
            this.btnRecommendMovie.Location = new System.Drawing.Point(217, 163);
            this.btnRecommendMovie.Name = "btnRecommendMovie";
            this.btnRecommendMovie.Size = new System.Drawing.Size(365, 65);
            this.btnRecommendMovie.TabIndex = 11;
            this.btnRecommendMovie.Text = "Get Movie Recommendations";
            this.btnRecommendMovie.UseVisualStyleBackColor = false;
            this.btnRecommendMovie.Click += new System.EventHandler(this.btnRecommendMovie_Click);
            // 
            // txtNameToRecommend
            // 
            this.txtNameToRecommend.BackColor = System.Drawing.Color.Ivory;
            this.txtNameToRecommend.Location = new System.Drawing.Point(159, 117);
            this.txtNameToRecommend.Name = "txtNameToRecommend";
            this.txtNameToRecommend.Size = new System.Drawing.Size(519, 31);
            this.txtNameToRecommend.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(73, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // groupRateMovie
            // 
            this.groupRateMovie.BackColor = System.Drawing.Color.Transparent;
            this.groupRateMovie.Controls.Add(this.txtName);
            this.groupRateMovie.Controls.Add(this.lblRateMovie);
            this.groupRateMovie.Controls.Add(this.btnRateMovie);
            this.groupRateMovie.Controls.Add(this.lblName);
            this.groupRateMovie.Controls.Add(this.lblMovieTitle);
            this.groupRateMovie.Controls.Add(this.lblGenre);
            this.groupRateMovie.Controls.Add(this.lblRating);
            this.groupRateMovie.Controls.Add(this.btn1Star);
            this.groupRateMovie.Controls.Add(this.txtTitle);
            this.groupRateMovie.Controls.Add(this.btn5Star);
            this.groupRateMovie.Controls.Add(this.comboGenre);
            this.groupRateMovie.Controls.Add(this.btn4Star);
            this.groupRateMovie.Controls.Add(this.btn2Star);
            this.groupRateMovie.Controls.Add(this.btn3Star);
            this.groupRateMovie.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRateMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.groupRateMovie.Location = new System.Drawing.Point(62, 471);
            this.groupRateMovie.Name = "groupRateMovie";
            this.groupRateMovie.Size = new System.Drawing.Size(802, 489);
            this.groupRateMovie.TabIndex = 17;
            this.groupRateMovie.TabStop = false;
            // 
            // lblRateMovie
            // 
            this.lblRateMovie.AutoSize = true;
            this.lblRateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateMovie.Location = new System.Drawing.Point(273, 39);
            this.lblRateMovie.Name = "lblRateMovie";
            this.lblRateMovie.Size = new System.Drawing.Size(231, 46);
            this.lblRateMovie.TabIndex = 14;
            this.lblRateMovie.Text = "Rate Movie";
            // 
            // groupRecommendations
            // 
            this.groupRecommendations.BackColor = System.Drawing.Color.Transparent;
            this.groupRecommendations.Controls.Add(this.label2);
            this.groupRecommendations.Controls.Add(this.txtNameToRecommend);
            this.groupRecommendations.Controls.Add(this.btnRecommendMovie);
            this.groupRecommendations.Controls.Add(this.label1);
            this.groupRecommendations.ForeColor = System.Drawing.Color.Coral;
            this.groupRecommendations.Location = new System.Drawing.Point(931, 471);
            this.groupRecommendations.Name = "groupRecommendations";
            this.groupRecommendations.Size = new System.Drawing.Size(748, 251);
            this.groupRecommendations.TabIndex = 18;
            this.groupRecommendations.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(140, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Movie Recommendations";
            // 
            // groupUpdateRating
            // 
            this.groupUpdateRating.BackColor = System.Drawing.Color.Transparent;
            this.groupUpdateRating.Controls.Add(this.btnUpdate1Star);
            this.groupUpdateRating.Controls.Add(this.btnUpdate5Star);
            this.groupUpdateRating.Controls.Add(this.btnUpdate4Star);
            this.groupUpdateRating.Controls.Add(this.btnUpdate2Star);
            this.groupUpdateRating.Controls.Add(this.btnUpdate3Star);
            this.groupUpdateRating.Controls.Add(this.btnUpdateRating);
            this.groupUpdateRating.Controls.Add(this.btnDeleteRating);
            this.groupUpdateRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.groupUpdateRating.Location = new System.Drawing.Point(931, 728);
            this.groupUpdateRating.Name = "groupUpdateRating";
            this.groupUpdateRating.Size = new System.Drawing.Size(748, 232);
            this.groupUpdateRating.TabIndex = 19;
            this.groupUpdateRating.TabStop = false;
            // 
            // btnUpdate1Star
            // 
            this.btnUpdate1Star.AutoSize = true;
            this.btnUpdate1Star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdate1Star.Location = new System.Drawing.Point(131, 42);
            this.btnUpdate1Star.Name = "btnUpdate1Star";
            this.btnUpdate1Star.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate1Star.TabIndex = 12;
            this.btnUpdate1Star.TabStop = true;
            this.btnUpdate1Star.Text = "1 Star";
            this.btnUpdate1Star.UseVisualStyleBackColor = true;
            // 
            // btnUpdate5Star
            // 
            this.btnUpdate5Star.AutoSize = true;
            this.btnUpdate5Star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdate5Star.Location = new System.Drawing.Point(555, 42);
            this.btnUpdate5Star.Name = "btnUpdate5Star";
            this.btnUpdate5Star.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate5Star.TabIndex = 16;
            this.btnUpdate5Star.TabStop = true;
            this.btnUpdate5Star.Text = "5 Star";
            this.btnUpdate5Star.UseVisualStyleBackColor = true;
            // 
            // btnUpdate4Star
            // 
            this.btnUpdate4Star.AutoSize = true;
            this.btnUpdate4Star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdate4Star.Location = new System.Drawing.Point(449, 42);
            this.btnUpdate4Star.Name = "btnUpdate4Star";
            this.btnUpdate4Star.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate4Star.TabIndex = 15;
            this.btnUpdate4Star.TabStop = true;
            this.btnUpdate4Star.Text = "4 Star";
            this.btnUpdate4Star.UseVisualStyleBackColor = true;
            // 
            // btnUpdate2Star
            // 
            this.btnUpdate2Star.AutoSize = true;
            this.btnUpdate2Star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdate2Star.Location = new System.Drawing.Point(237, 42);
            this.btnUpdate2Star.Name = "btnUpdate2Star";
            this.btnUpdate2Star.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate2Star.TabIndex = 13;
            this.btnUpdate2Star.TabStop = true;
            this.btnUpdate2Star.Text = "2 Star";
            this.btnUpdate2Star.UseVisualStyleBackColor = true;
            // 
            // btnUpdate3Star
            // 
            this.btnUpdate3Star.AutoSize = true;
            this.btnUpdate3Star.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdate3Star.Location = new System.Drawing.Point(343, 42);
            this.btnUpdate3Star.Name = "btnUpdate3Star";
            this.btnUpdate3Star.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate3Star.TabIndex = 14;
            this.btnUpdate3Star.TabStop = true;
            this.btnUpdate3Star.Text = "3 Star";
            this.btnUpdate3Star.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRating
            // 
            this.btnUpdateRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(15)))));
            this.btnUpdateRating.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateRating.Location = new System.Drawing.Point(276, 90);
            this.btnUpdateRating.Name = "btnUpdateRating";
            this.btnUpdateRating.Size = new System.Drawing.Size(202, 53);
            this.btnUpdateRating.TabIndex = 17;
            this.btnUpdateRating.Text = "Update Rating";
            this.btnUpdateRating.UseVisualStyleBackColor = false;
            this.btnUpdateRating.Click += new System.EventHandler(this.btnUpdateRating_Click);
            // 
            // btnDeleteRating
            // 
            this.btnDeleteRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnDeleteRating.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRating.Location = new System.Drawing.Point(276, 149);
            this.btnDeleteRating.Name = "btnDeleteRating";
            this.btnDeleteRating.Size = new System.Drawing.Size(202, 53);
            this.btnDeleteRating.TabIndex = 18;
            this.btnDeleteRating.Text = "Delete Rating";
            this.btnDeleteRating.UseVisualStyleBackColor = false;
            this.btnDeleteRating.Click += new System.EventHandler(this.btnDeleteRating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PCAD7_Project_MovieDatabase.Properties.Resources.istockphoto_950306336_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1884, 1137);
            this.Controls.Add(this.groupUpdateRating);
            this.Controls.Add(this.groupRecommendations);
            this.Controls.Add(this.groupRateMovie);
            this.Controls.Add(this.movieGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sit back, relax, and enjoy!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieGrid)).EndInit();
            this.groupRateMovie.ResumeLayout(false);
            this.groupRateMovie.PerformLayout();
            this.groupRecommendations.ResumeLayout(false);
            this.groupRecommendations.PerformLayout();
            this.groupUpdateRating.ResumeLayout(false);
            this.groupUpdateRating.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView movieGrid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.RadioButton btn1Star;
        private System.Windows.Forms.RadioButton btn5Star;
        private System.Windows.Forms.RadioButton btn4Star;
        private System.Windows.Forms.RadioButton btn3Star;
        private System.Windows.Forms.RadioButton btn2Star;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRateMovie;
        private System.Windows.Forms.Button btnRecommendMovie;
        private System.Windows.Forms.TextBox txtNameToRecommend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupRateMovie;
        private System.Windows.Forms.Label lblRateMovie;
        private System.Windows.Forms.GroupBox groupRecommendations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupUpdateRating;
        private System.Windows.Forms.RadioButton btnUpdate1Star;
        private System.Windows.Forms.RadioButton btnUpdate5Star;
        private System.Windows.Forms.RadioButton btnUpdate4Star;
        private System.Windows.Forms.RadioButton btnUpdate2Star;
        private System.Windows.Forms.RadioButton btnUpdate3Star;
        private System.Windows.Forms.Button btnUpdateRating;
        private System.Windows.Forms.Button btnDeleteRating;
    }
}

