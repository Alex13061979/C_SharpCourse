Console.WriteLine("Enter the day's number from 1 to 7");
string dayNumb = Console.ReadLine();
Console.Clear();

switch (dayNumb)
{
    case "1":
        Console.WriteLine("It's Monday");
        break;
    case "2":
        Console.WriteLine("It's Tuesday");
        break;
    case "3":
        Console.WriteLine("It's Wednsday");
        break;
    case "4":
        Console.WriteLine("It's Thursday");
        break;
    case "5":
        Console.WriteLine("It's Friday");
        break;
    case "6":
        Console.WriteLine("It's Saturday");
        break;
    case "7":
        Console.WriteLine("It's Sunday");
        break;
    default:
        Console.WriteLine("You've entered the wrong number!");
        break;
}
