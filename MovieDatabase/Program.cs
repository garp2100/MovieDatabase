using MovieDatabase;
using System.Linq;

//instantiating movie objects from the Movie class
Movie movieOne = new ("Star Wars", "SciFi");
Movie movieTwo = new ("IT", "Horror");
Movie movieThree = new ("Spirited Away", "Animated");
Movie movieFour = new ("Kramer vs. Kramer", "Drama");
Movie movieFive = new ("2001: A Space Odissey", "SciFi");
Movie movieSix = new ("Nightmare on Elm Street", "Horror");
Movie movieSeven = new ("Fantasia", "Animated");
Movie movieEight = new ("Forrest Gump", "Drama");
Movie movieNine = new ("E.T", "SciFi");
Movie movieTen = new ("The Blair Witch Project", "Horror");

//creating a list that will hold all movie objects
List<Movie> movieList = new List<Movie>() { movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven, movieEight, movieNine, movieTen};

while (true)
{
    Console.WriteLine("Welcome to the Movie List Application");
    Console.WriteLine("There are " + movieList.Count + " movies in this list");
    Console.WriteLine("What category are you interested in?");
    string userInput = Console.ReadLine();
    var moviesBasedOnGenre = (from movie in movieList where movie.Category.Equals(userInput) select movie);
    if (userInput == "SciFi" || userInput == "Horror" || userInput == "Animated" || userInput == "Drama" )
    {
        foreach (var movie in moviesBasedOnGenre)
        {
            movie.PrintMovieSelection();
        }
    }
    else
    {
        Console.WriteLine("Sorry we don't have that category. Would you like to continue? y/n");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            continue;
        else
            Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }

    while (true)
    {
        Console.WriteLine("Would you like to restart? y/n.");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            break;
        else
            Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}