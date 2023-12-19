Countdown(-100);

void Countdown(int number)
{
    if (number <= 0)return;
        Console.WriteLine(number);
        Countdown(number - 1);
}