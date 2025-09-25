// See https://aka.ms/new-console-template for more information

//Set up variable choices//
int firstDecisionW = 1;
int firstDecisionR = 2;

int secondDecisionR = 3;
int secondDecisionW = 4;

int thirdDecisionR = 5;
int thirdDecisionW = 6;

int fourthDecisionR = 7;
int fourthDecisionW = 8;


//Tell player that their alein friend is trapped at Area 51//

Console.WriteLine("Welcome to save the Alien!");
Console.WriteLine("Please enter your name.");
string playerName = Console.ReadLine();

Console.WriteLine("What is your alien friend's name?");
string alienName = Console.ReadLine();

Console.WriteLine($"Oh no,{playerName}! Your alien friend, {alienName}, was kidnapped and brought to Area 51!" +
    "Go rescue them, but be cautious. Choose your options wisely so that you BOTH make it out safely.");

//First obstacle user interacts with//

Console.WriteLine("There are two guards standing at the front door. How will you get pass? Type 1 to - Pretend to be a Staff member" +
    "Type 2 to - Use your tranquilizer");
string firstOption = Console.ReadLine();

