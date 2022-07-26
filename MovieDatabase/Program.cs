//we would instantiate 10 movie objects based on the Movie class
//we would put all those movies in a list
//we take user input to loop through that list and return a list of movies based on genre
using MovieDatabase;

Movie movieOne = new Movie("Star Wars", MovieGenre.SciFi);
Movie movieTwo = new Movie("IT", MovieGenre.Horror);
Movie movieThree = new Movie("Spirited Away", MovieGenre.Animated);
Movie movieFour = new Movie("Kramer vs. Kramer", MovieGenre.Drama);
Movie movieFive = new Movie("2001: A Space Odissey", MovieGenre.SciFi);
Movie movieSix = new Movie("Nightmare on Elm Street", MovieGenre.Horror);
Movie movieSeven = new Movie("Fantasia", MovieGenre.Animated);
Movie movieEight = new Movie("Forrest Gump", MovieGenre.Drama);
Movie movieNine = new Movie("E.T", MovieGenre.SciFi);
Movie movieTen = new Movie("The Blair Witch Project", MovieGenre.Horror);

List<Movie> movieList = new List<Movie>() { movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven, movieEight, movieNine, movieTen};