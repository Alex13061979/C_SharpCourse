
//Order1

Console.WriteLine("Enter the order's number: ");
int order = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the client's name: ");
string client = Console.ReadLine();

Console.WriteLine("Enter the product's name: ");
string productName = Console.ReadLine();

Console.WriteLine("Enter the product's price: ");
decimal productPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the client's street: ");
string street = Console.ReadLine();

Console.WriteLine("and the nomber of a house: ");
int houseNum = int.Parse(Console.ReadLine());
Console.WriteLine();

//Another order

Console.WriteLine("Enter the order's number: ");
int order2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the client's name: ");
string client2 = Console.ReadLine();

Console.WriteLine("Enter the product's name: ");
string productName2 = Console.ReadLine();

Console.WriteLine("Enter the product's price: ");
decimal productPrice2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the client's street: ");
string street2 = Console.ReadLine();

Console.WriteLine("and the nomber of a house: ");
int houseNum2 = int.Parse(Console.ReadLine());
Console.WriteLine();

//And one more order

Console.WriteLine("Enter the order's number: ");
int order3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the client's name: ");
string client3 = Console.ReadLine();

Console.WriteLine("Enter the product's name: ");
string productName3 = Console.ReadLine();

Console.WriteLine("Enter the product's price: ");
decimal productPrice3 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the client's street: ");
string street3 = Console.ReadLine();

Console.WriteLine("and the nomber of a house: ");
int houseNum3 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Order No: {order}");
Console.WriteLine($"Client: {client}.");
Console.WriteLine($"Product: {productName}, price: {productPrice} EUR.");
Console.WriteLine($"Address: {street}, {houseNum}.");
Console.WriteLine();

Console.WriteLine($"Order No: {order2}");
Console.WriteLine($"Client: {client2}.");
Console.WriteLine($"Product: {productName2}, price: {productPrice2} EUR.");
Console.WriteLine($"Address: {street2}, {houseNum2}.");
Console.WriteLine();

Console.WriteLine($"Order No: {order3}");
Console.WriteLine($"Client: {client3}.");
Console.WriteLine($"Product: {productName3}, price: {productPrice3} EUR.");
Console.WriteLine($"Address: {street3}, {houseNum3}.");
Console.WriteLine();
