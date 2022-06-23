// IF и ELSE команды
Console.WriteLine("Введите свое имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "катя")
{
    Console.WriteLine("Ура, это же Катя!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}