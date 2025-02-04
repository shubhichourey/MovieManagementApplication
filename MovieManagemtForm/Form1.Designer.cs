namespace Epam.MovieManagement
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
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.TxtLoad = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMovieId
            // 
            this.lblMovieId.BackColor = System.Drawing.Color.Linen;
            this.lblMovieId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMovieId.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblMovieId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMovieId.Location = new System.Drawing.Point(70, 64);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(170, 42);
            this.lblMovieId.TabIndex = 0;
            this.lblMovieId.Text = "Movie Id";
            this.lblMovieId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMovieId.Click += new System.EventHandler(this.lblMovieId_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Linen;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(70, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.Linen;
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenre.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenre.Location = new System.Drawing.Point(70, 241);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(170, 41);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.BackColor = System.Drawing.Color.Linen;
            this.lblReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReleaseYear.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblReleaseYear.Location = new System.Drawing.Point(70, 409);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(170, 42);
            this.lblReleaseYear.TabIndex = 3;
            this.lblReleaseYear.Text = "Release Year";
            this.lblReleaseYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReleaseYear.Click += new System.EventHandler(this.lblReleaseYear_Click);
            // 
            // lblDirector
            // 
            this.lblDirector.BackColor = System.Drawing.Color.Linen;
            this.lblDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirector.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(70, 490);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(170, 43);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director";
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDirector.Click += new System.EventHandler(this.lblDirector_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(273, 152);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(590, 42);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(273, 241);
            this.txtGenre.Multiline = true;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(590, 41);
            this.txtGenre.TabIndex = 7;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(273, 409);
            this.txtReleaseYear.Multiline = true;
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(590, 42);
            this.txtReleaseYear.TabIndex = 8;
            this.txtReleaseYear.TextChanged += new System.EventHandler(this.txtRelease_TextChanged);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(273, 492);
            this.txtDirector.Multiline = true;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(590, 43);
            this.txtDirector.TabIndex = 9;
            this.txtDirector.TextChanged += new System.EventHandler(this.txtDirector_TextChanged);
            // 
            // TxtLoad
            // 
            this.TxtLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtLoad.Location = new System.Drawing.Point(966, 95);
            this.TxtLoad.Multiline = true;
            this.TxtLoad.Name = "TxtLoad";
            this.TxtLoad.ReadOnly = true;
            this.TxtLoad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLoad.Size = new System.Drawing.Size(364, 377);
            this.TxtLoad.TabIndex = 10;
            this.TxtLoad.TextChanged += new System.EventHandler(this.TxtLoad_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Linen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(288, 553);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 67);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Linen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(492, 553);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 67);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Linen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(701, 552);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 68);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Linen;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(966, 490);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(122, 49);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Linen;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1206, 492);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(124, 50);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1083, 553);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 49);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.BackColor = System.Drawing.Color.Linen;
            this.btnLoadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAll.Location = new System.Drawing.Point(1074, 42);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(151, 47);
            this.btnLoadAll.TabIndex = 18;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = false;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(273, 64);
            this.txtMovieId.Multiline = true;
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(590, 41);
            this.txtMovieId.TabIndex = 19;
            this.txtMovieId.TextChanged += new System.EventHandler(this.txtMovieId_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 42);
            this.textBox1.TabIndex = 21;
            // 
            // lblCast
            // 
            this.lblCast.BackColor = System.Drawing.Color.Linen;
            this.lblCast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCast.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.lblCast.Location = new System.Drawing.Point(70, 325);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(170, 41);
            this.lblCast.TabIndex = 22;
            this.lblCast.Text = "Cast";
            this.lblCast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(273, 324);
            this.txtCast.Multiline = true;
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(590, 42);
            this.txtCast.TabIndex = 20;
            this.txtCast.TextChanged += new System.EventHandler(this.txtCast_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1539, 668);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtLoad);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMovieId);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox TxtLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.TextBox textBox1;


    }

}












