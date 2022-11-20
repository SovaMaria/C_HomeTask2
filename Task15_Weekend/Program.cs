Console.Write ("Введите цифру дня недели: ");
int date = Convert.ToInt32 (Console.ReadLine());
if (date == 6 || date == 7)
{
    Console.Write ("Выходной день");
}
else if (date < 1 || date > 7)
{
    Console.Write ("Вы ввели несуществующий день недели");
}
else
{
    Console.Write ("Будний день");
}