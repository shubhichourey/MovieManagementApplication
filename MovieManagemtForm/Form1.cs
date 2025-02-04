using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epam.MovieManagement;
using Epam.MovieManagement.Application;



namespace Epam.MovieManagement
{
    public partial class Form1 : Form
    {
        MovieService movieService = null;
        public Form1()
        {
            InitializeComponent();
            movieService = new MovieService();
        }
        private void checkAllFields()
        {
            if (txtMovieId.Text == null || txtMovieId.Text == "")
            {
                MessageBox.Show("Movie Id is required");
                return;
            }
            if (txtTitle.Text == null || txtTitle.Text == "")
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            if (txtGenre.Text == null || txtGenre.Text == "")
            {
                MessageBox.Show("Movie Genre is required");
                return;
            }
            if (txtCast.Text == null || txtCast.Text == "")
            {
                MessageBox.Show("Movie Cast is required");
                return;
            }
            if (txtDirector.Text == null || txtDirector.Text == "")
            {
                MessageBox.Show("Movie Director is required");
                return;
            }
            if (txtReleaseYear.Text == null || txtReleaseYear.Text == "")
            {
                MessageBox.Show("Movie Release Year is required");
                return;
            }

        }


        private void lblMovieId_Click(object sender, EventArgs e)
        {

        }

        private void txtMovieId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }

        private void txtCast_TextChanged(object sender, EventArgs e)
        {
            // Add logic if needed
        }


        private void lblReleaseYear_Click(object sender, EventArgs e)
        {

        }

        private void lblDirector_Click(object sender, EventArgs e)
        {

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkAllFields();
            Movie m = new Movie();
            if (int.TryParse(txtMovieId.Text, out int movieid))
            {
                m.MovieId = movieid;
            }
            else
            {
                MessageBox.Show("Movie Id Should be Integer Only");
                return;
            }
            m.Title = txtTitle.Text;
            m.Genre = txtGenre.Text;
            m.Cast = txtCast.Text;
            m.Director = txtDirector.Text;
            if (int.TryParse(txtReleaseYear.Text, out int releasedYear))
            {
                m.ReleasedYear = releasedYear;
            }
            else
            {
                MessageBox.Show("Released Year should be a number");
                return;
            }
            if (movieService.Add(m))
                MessageBox.Show("Movie Added Successfully!");
            else
                MessageBox.Show("Movie Already present please add a new one!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkAllFields();
            Movie m = new Movie();
            if (int.TryParse(txtMovieId.Text, out int movieid))
            {
                m.MovieId = movieid;
            }
            else
            {
                MessageBox.Show("Movie Id Should be Integer Only");
                return;
            }
            m.Title = txtTitle.Text;
            m.Genre = txtGenre.Text;
            m.Cast = txtCast.Text;
            m.Director = txtDirector.Text;
            if (int.TryParse(txtReleaseYear.Text, out int releasedYear))
            {
                m.ReleasedYear = releasedYear;
            }
            else
            {
                MessageBox.Show("Released Year should be a number");
                return;
            }
            if (movieService.Update(m))
                MessageBox.Show("Movie Updated Successfully!");
            else
                MessageBox.Show("Please Enter a valid MovieId");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtMovieId.Text == null)
            {
                MessageBox.Show("Please Enter Movie ID");
                return;
            }
            if (int.TryParse(txtMovieId.Text, out int movieid))
            {
                if (movieService.Delete(movieid))
                    MessageBox.Show("Movie Deleted Successfully!");
                else
                {
                    MessageBox.Show("Please Enter a Valid MovieId!");
                }
            }
            else
            {
                MessageBox.Show("Movie Id Should be Integer Only");
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Movie m = movieService.First();
            StringBuilder sb = new StringBuilder();
            if (m != null)
            {
                sb.AppendLine($"Movie ID - {m.MovieId}");
                sb.AppendLine($"Title - {m.Title}");
                sb.AppendLine($"Genre - {m.Genre}");
                sb.AppendLine($"Cast- {m.Cast}");
                sb.AppendLine($"Released Year - {m.ReleasedYear}");
                sb.AppendLine($"Director - {m.Director}");
                sb.AppendLine();
            }
            TxtLoad.Clear();
            TxtLoad.Text = sb.ToString();

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Movie m = movieService.Last();
            StringBuilder sb = new StringBuilder();
            if (m != null)
            {
                sb.AppendLine($"Movie ID - {m.MovieId}");
                sb.AppendLine($"Title - {m.Title}");
                sb.AppendLine($"Genre - {m.Genre}");
                sb.AppendLine($"Cast- {m.Cast}");
                sb.AppendLine($"Released Year - {m.ReleasedYear}");
                sb.AppendLine($"Director - {m.Director}");
                sb.AppendLine();
            }
            TxtLoad.Clear();
            TxtLoad.Text = sb.ToString();
        }

        private void TxtLoad_TextChanged(object sender, EventArgs e)
        {
            TxtLoad.Multiline = true;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, Movie> movieList = movieService.Load();

            if (movieList != null && movieList.Count > 0)
            {
                StringBuilder sb = new StringBuilder(); // Use StringBuilder to build fresh content

                foreach (var m in movieList.Values)
                {
                    if (m != null)
                    {
                        sb.AppendLine($"Movie ID - {m.MovieId}");
                        sb.AppendLine($"Title - {m.Title}");
                        sb.AppendLine($"Genre - {m.Genre}");
                        sb.AppendLine($"Cast - {m.Cast}");
                        sb.AppendLine($"Released Year - {m.ReleasedYear}");
                        sb.AppendLine($"Director - {m.Director}");
                        sb.AppendLine();
                    }
                }

                TxtLoad.Clear(); TxtLoad.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("No Movies Found");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtLoad.Clear();
        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRelease_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
