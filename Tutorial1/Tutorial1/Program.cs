// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

double result = GetMax(new int[]{ 3, 2, 4 });
Console.WriteLine(result);


static double GetAvg(int[] arr)
{
    double sum = 0;
    foreach (var a in arr)
    {
        sum += a;
    }
    return sum / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = arr[0];
    foreach (var i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }

    return max;
}
