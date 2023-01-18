using System.Reflection.Metadata.Ecma335;

string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

while(true)
{
    //while (true) { }
    Console.WriteLine("Which student would you like to learn more about? Enter a number 1-" + (names.Length));
    int choice = int.Parse(Console.ReadLine().Trim()) -1; //this -1 fixed the index wrong issue 

    if (choice > 16 || choice < 0)
    {
        Console.WriteLine("Oops!  That number is out of range");
        break;
    }

    while (true)
    {
        Console.WriteLine("Current Student is " + names[choice] + ". What would you like to know? Enter 'hometown' or 'favorite food': ");
        string choice2 = Console.ReadLine().ToLower().Trim();
        if (choice2 == "hometown" || choice2 == "home" || choice2 == "h")
        {
            Console.WriteLine(names[choice] + " is from " + towns[choice]);
            break;
        }
        else if (choice2 == "favorite food" || choice2 == "food" || choice2 == "f")
        {
            Console.WriteLine(names[choice] + " favorite food is " + foods[choice] +". Yum!");
            break;
        }
        else
        {
            Console.WriteLine("Sorry. Please choose 'hometown' or 'favorite food'");
        }
    }
    Console.WriteLine("Would you like to learn more about another student? y/n ");
    string choice3 = Console.ReadLine();
    if(choice3 == "y" || choice3 == "yes")
    {
        continue;
    }
    else if (choice3 == "n" || choice3 == "no")
    {
        Console.WriteLine("It's been a pleasure!");
        break;
    }
}