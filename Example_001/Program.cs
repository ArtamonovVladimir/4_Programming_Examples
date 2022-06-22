// Задачка с собакой и 2-мя друзьями, которые идут друг другу. Собака бежит от 1 друга к 2 и обратно, пока они не встретяться на опрделенной дистанции. 
// Вопрос: сколько раз собака пробежит между ними, пока они не встретяться на определенной дистанции.
Console.Write("Введите расстояние в метрах между друзьями: ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость в м/ч для 1 друга: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость в м/ч для 2 друга: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки в м/ч: ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите расстояние встречи между друзьями: ");
double meetDistance = Convert.ToDouble(Console.ReadLine());
int count = 0;
int friend = 2;
double meetTime = 0;
while (distance < meetDistance)
{
    if (friend == 1)
    {
        meetTime = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        meetTime = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * meetTime;
    count = count + 1;
}
Console.Write("Собака пробежит {count} раз");
// Console.Write(count);
// Console.WriteLine(" раз.");