Console.WriteLine("What is your favorite school subject?(Math,Science,History,Language,P.E)");
string favoriteSubject = Console.ReadLine();
switch (favoriteSubject.ToLower())
{
    case "math":
        Console.WriteLine("Can I copy your homework?");
        break;
    case "science":
        Console.WriteLine("What area in science?");
        break;
    case "history":
        Console.WriteLine("Ewwwww- who cares about the past!");
        break;
    case "Language":
        Console.WriteLine("How many languages do you want to speak before you die?");
        break;
    case "P.E":
        Console.WriteLine("whats your favorite sport");
        break;

    default:
        Console.WriteLine("It's always good to be diff");
        break;
}