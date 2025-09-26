//Tell player that their alein friend is trapped at Area 51//

Console.WriteLine("Welcome to save the Alien!");
Console.WriteLine("Please enter your name.");
string playerName = Console.ReadLine();

Console.WriteLine("What is your alien friend's name?");
string alienName = Console.ReadLine();

Console.WriteLine($"Oh no,{playerName}! Your alien friend, {alienName}, was kidnapped and brought to Area 51! Go rescue them, but be cautious. Choose your options wisely so that you BOTH make it out safely.");

//First obstacle user interacts with//

Console.Write("There are two guards standing at the front door. How will you get pass? ");
Console.Write("Type 1 to - Pretend to be a Staff member");
Console.Write(" Type 2 to - Use your tranquilizer");
string choice1 = Console.ReadLine();
if (choice1 == "1")
{ Console.WriteLine(); }
else if (choice1 == "2")
{ Console.WriteLine(); }
else
{
    Console.WriteLine();
    return}



//Second obstacle user interacts with//
Console.WriteLine($"You found an ID to open one of the 2 doors you think could contain {alienName}. What door will you open?");
Console.WriteLine("Type 3 to - Pick the left door");
Console.WriteLine("Type 4 to pick the right door");


//Third obstacle user interacts with//
Console.WriteLine($"You and {alienName} managed to reunite. You took off the restrians and hed to the exit. {alienName} thinks you both should" +
$"go through the back door but there is also the option of going back the way you came. Becareful though {playerName}, the guards you tranquilized may be waking up");
Console.WriteLine($"Type 5 to - Follow {alienName}");
Console.WriteLine($" Type 6 to - Go back to the front door");

//Forth obstacle user interacts with (new ending)//
Console.WriteLine($"On your way to the front door you ended up being caught by the guards. They know that you were here for {alienName}. They gave you the option to tell them where {alienName} is in exchange for not being arrested. ");
Console.WriteLine($"Type 7 to - Betray {alienName} ");
Console.WriteLine($" Type 8 to - Sacrifice yourself. ");
