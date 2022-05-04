Console.Write("Enter Name: ");
string username = Console.ReadLine();

if (username.ToLower() == "Masha")
{
    Console.WriteLine("Ura! Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}