namespace HW3Project.Models
{
    public class MovieList
    {
        public FilmLibrary[] films;

        public MovieList()
        {
            films = new FilmLibrary[]
            {
                new FilmLibrary (1, "Harry Potter and the Half-Blood Prince", "Family/Adventure", "2hr 33 min", 12),
                new FilmLibrary(2, "The Hunger Games", "Sci-Fi/Adventure", "2hr 22 min", 8),
                new FilmLibrary(3, "Avengers Endgame", "Action/Adventure/Drama", "3 hr 1 min", 15),
                new FilmLibrary(4, "Spider-Man: No Way Home", "Action/Adventure/Fantasy", "2 hr 28 min", 13),
                new FilmLibrary(5, "One Piece Film: Gold", "Animation/Action/Adventure", "2 hr", 15),
                new FilmLibrary(6, "Scary Movie", "Comedy", "1 hr 28 min", 9),
                new FilmLibrary(7, "The Matrix Resurrections", "Action/Sci-Fi", "2 hr 28 min", 12),
                new FilmLibrary(8, "Paranormal Activity", "Horror/Mystery", "1 hr 26 min", 7),
                new FilmLibrary(9, "Insidious", "Horror/Mystery/Thriller", "1 hr 43 min", 4),
                new FilmLibrary(10, "The Discovery", "Drama/Romance/Sci-Fi", "1 hr 42 min", 18)
            };
        }
    }
}