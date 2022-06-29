Main();

void Main()
{
    // Menu Options
    List<string> menuOptions = new List<string>
    {
        "(1) Rock",
        "(2) Paper",
        "(3) Scissors"
    };

    // Game Art
    List<string> gameArt = new List<string>
    {
        $@"

        [ R O C K ]
                _______
            ---'   ____)
                  (_____)
                  (_____)
                  (____)
            ---.__(___) 
            
        ",
        $@"
            [ P A P E R ]
                 _______
            ---'    ____)____
                       ______)
                     _______)
                    _______)
            ---.__________)
            
        ",
        $@"
            [ S C I S S O R S ]
                 _______
            ---'    ____)____
                       ______)
                   __________)
                  (____)
            ---.__(___)
                        
        "
    };

    gameMenu(menuOptions);

    // -------- find index of player inputs -------- //
    int p1ArtIndex = playerOneInput() - 1;
    int p2ArtIndex = playerTwoInput(gameArt.Count) - 1;

    // -------- runs gamePlay if user input is integer and exists in gameArt list -------- //
    if(p1ArtIndex >= 0 && p1ArtIndex < 3 )
    {
        gamePlay(gameArt[p1ArtIndex], gameArt[p2ArtIndex]);
    }
    else
    {
        Console.WriteLine(errorMessage());
    }

}

// -------- displays game menu -------- //
void gameMenu(List<string> playOptions)
{

    Console.WriteLine(
    $@"
    [ R O C K , P A P E R , S C I S S O R S ]

    What would you like to throw?
    "
    );
    playOptions.ForEach(option => Console.WriteLine($"      {option}"));
}

// -------- displays game play -------- //
void gamePlay(string p1, string p2)
{
            Console.WriteLine($@"
            
            { p1 }

            ---- v. ----

            { p2 }
            
            ");
}



// --------- Unfinished code for displaying the game score --------- //
// void gameScore(int p1Score, int p2Score)
// {

//     switch(
//         case(p1:)
//     )
//     Console.WriteLine($@"

//     ----------------------------
//     | Player: {p1Score} | Computer: {p2Score} |
//     ----------------------------
    
//     ");
// }




// --------- Returns selection for player 1  ---------- //
static int playerOneInput()
{
    var p1Input = Console.ReadLine();

    int.TryParse(p1Input, out int p1InputToInt);

    return p1InputToInt;
}

// --------- Returns selection for player 2  ---------- //
static int playerTwoInput(int artCount)
{
    Random randomInt = new Random();
    int p2Random = randomInt.Next(1, artCount);

    return p2Random;
}

// --------- Returns error message string ---------- //
static string errorMessage()
{
    return "Please input a number 1-3.";
}