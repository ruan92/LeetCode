// See https://aka.ms/new-console-template for more information
Console.WriteLine(Average(new int[] {48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000 }));

double Average(int[] salary)
{
    var min = salary[0];
    var max = salary[0];
    var sum = 0;

    for (var i = 0; i < salary.Length; i++)
    {
        if (salary[i] < min)
            min = salary[i];
        if (salary[i] > max)
            max = salary[i];

        sum += salary[i];
    }
    return Math.Abs((double)(sum - min - max) / (salary.Length - 2));
}