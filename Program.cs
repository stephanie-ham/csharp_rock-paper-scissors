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

    int gameArtIndex = gameArt.Count - 1;
    int p1ArtIndex = playerOneInput() - 1;
    int p2ArtIndex = playerTwoInput(gameArtIndex);

    gamePlay(gameArt[p1ArtIndex], gameArt[p2ArtIndex]);

}

// -------- displays game menu in terminal -------- //
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


// -------- old solution for playerOne input -------- //
// static string playerOne(List<string> gameArt)
// {
//     var p1Input = Console.ReadLine();
    
//     if ((int.TryParse(p1Input, out int p1Num)) && (p1Num > 0 && p1Num <= 3)) 
//     {
//         string p1 = new string(gameArt[p1Num - 1]);
        
//         return p1;

//     }
//     else
//     {
//         return null;
//     }

// }



// -------- displays game play in terminal -------- //
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



// --------- Potential solution for error message ---------- //
// static string errorMessage()
// {
//     return "Please input a number 1-3.";
// }
// static string playerOneInput(int artIndex, string errorMsg)
// {
//     var p1Input = Console.ReadLine();

//     int.TryParse(p1Input, out int p1InputToInt);

//     if(p1InputToInt >= 0 && p1InputToInt <= artIndex){
        
//         string p1 = new string(p1Input);
        
//         return p1;
//     }
//     else
//     {
//         return errorMsg;
//     }
// }




static int playerOneInput()
{
    var p1Input = Console.ReadLine();

    int.TryParse(p1Input, out int p1InputToInt);

    return p1InputToInt;
}

static int playerTwoInput(int artIndex)
{
    Random randomInt = new Random();
    int p2Random = randomInt.Next(0, artIndex + 1);

    return p2Random;
}

// static string inputCheck(int p1Input, int artIndex)
// {

//     if(p1Input >= 0 && p1Input <= artIndex){
        
//         string p1 = new string(p1Input);
        
//         return p1;
//     }
//     else
//     {
//         return "Please input a number 1-3.";
//     }
// }