Main();

void Main()
{
    List<string> menuOptions = new List<string>
    {
        "(1) Rock",
        "(2) Paper",
        "(3) Scissors"
    };

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
    gamePlay(playerOne(gameArt), playerTwo(gameArt));
}


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

static string playerOne(List<string> gameArt)
{
    var p1Input = Console.ReadLine();
    
    if ((int.TryParse(p1Input, out int p1Num)) && (p1Num > 0 && p1Num <= 3)) 
    {
        string p1 = new string(gameArt[p1Num - 1]);
        
        return p1;

    }
    else
    {
        return null;
    }

}

static string playerTwo(List<string> gameArt)
{
    Random randomInt = new Random();
    int p2Random = randomInt.Next(0, gameArt.Count() - 1);
    string p2 = new string(gameArt[p2Random]);

    return p2;
}

void gamePlay(string p1, string p2)
{
    if(p1 == null)
    {
       Console.WriteLine("Please input a number 1-3.");
    } else
    {
        Console.WriteLine($@"
        
        { p1 }

        ---- v. ----

        { p2 }
        
        ");
    }
}