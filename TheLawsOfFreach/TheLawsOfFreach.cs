int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//Instead of doing all the work below, I could just code the following :
// Console.WriteLine(array.Min());
// Console.WriteLine(array.Average());

int currentSmallest = int.MaxValue;
foreach (int value in array)
{
    if (value < currentSmallest)
     currentSmallest = value;
}
Console.WriteLine(currentSmallest);

int total = 0;
foreach (int value in array)
    total += value;

float average = (float)total / array.Length;
Console.WriteLine(average);