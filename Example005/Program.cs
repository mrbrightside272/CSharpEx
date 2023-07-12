System.Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура, это же Маша!");
}
else
{
    System.Console.Write("привет, ");
    System.Console.Write(username);
}