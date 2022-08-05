Console.WriteLine("Enter username: ");
string username = Console.ReadLine ();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Ura, this is MASHA");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}