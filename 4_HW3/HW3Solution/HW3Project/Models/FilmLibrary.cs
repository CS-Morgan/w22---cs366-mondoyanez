namespace HW3Project.Models
{
    public class FilmLibrary
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public string MovieLength { get; set; }
        public int QuantityInStock { get; set; }

        public FilmLibrary(int id, string Title, string Genre, string Length, int Quantity)
        {
            MovieId = id;
            MovieTitle = Title;
            MovieGenre = Genre;
            MovieLength = Length;
            QuantityInStock = Quantity;
        }
    }
}