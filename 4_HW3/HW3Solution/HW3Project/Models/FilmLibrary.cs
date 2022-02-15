namespace HW3Project.Models
{
    public class FilmLibrary
    {
        public int movieId { get; set; }
        public string movieTitle { get; set; }
        public string movieGenre { get; set; }
        public string movieLength { get; set; }
        public int quantityInStock { get; set; }

        public FilmLibrary(int id, string Title, string Genre, string Length, int Quantity)
        {
            movieId = id;
            movieTitle = Title;
            movieGenre = Genre;
            movieLength = Length;
            quantityInStock = Quantity;
        }
    }
}