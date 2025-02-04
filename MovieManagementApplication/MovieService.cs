using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieManagementApplication
{
    public class MovieService
    {
        SortedDictionary<int, Movie> movies = null;
        public string filePath = "Movie.json";

        public MovieService()
        {
            movies = new SortedDictionary<int, Movie>();
            movies = Load();
        }
        public bool Add(Movie movie)
        {
            if (movies.ContainsKey(movie.MovieId))
                return false;
            movies.Add(movie.MovieId, movie);
            return Save();
        }
        public bool Delete(int MovieId)
        {
            if (movies.ContainsKey(MovieId))
            {
                movies.Remove(MovieId);
                return Save();
            }
            return false;
        }
        public bool Update(Movie movie)
        {
            if (!movies.ContainsKey(movie.MovieId))
                return false;
            movies[movie.MovieId] = movie;
            return Save();

        }
        public bool Save()
        {
            if (movies.Count == 0) return false;
            try
            {
                string json = JsonConvert.SerializeObject(movies, Formatting.Indented);
                File.WriteAllText(filePath, json);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving movies: {ex.Message}");
                return false;
            }
        }
        public SortedDictionary<int, Movie> Load()
        {
            SortedDictionary<int, Movie> movieList = new SortedDictionary<int, Movie>();
            if (File.Exists(filePath))
            {
                try

                {
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON into SortedDictionary<int, Movie>

                    movieList = JsonConvert.DeserializeObject<SortedDictionary<int, Movie>>(json) ?? new SortedDictionary<int, Movie>();
                    movies.Clear();  // Ensure existing movies are cleared
                    foreach (var kvp in movieList)
                    {
                        movies[kvp.Key] = kvp.Value;
                    }
                }

                catch (Exception ex)

                {
                    Console.WriteLine("Error loading movies: " + ex.Message);

                }

            }

            return movieList;

        }
        public Movie First()
        {
            if (movies.Count == 0) return null;

            Movie firstMovie = null;
            foreach (var movie in movies.Values)
            {
                if (firstMovie == null || movie.MovieId < firstMovie.MovieId)
                {
                    firstMovie = movie;
                }
            }
            return firstMovie;
        }
        public Movie Last()
        {
            if (movies.Count == 0) return null;

            Movie lastMovie = null;
            foreach (var movie in movies.Values)
            {
                if (lastMovie == null || movie.MovieId > lastMovie.MovieId)
                {
                    lastMovie = movie;
                }
            }
            return lastMovie;
        }
    }
}
