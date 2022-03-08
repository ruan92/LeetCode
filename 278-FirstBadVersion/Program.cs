// See https://aka.ms/new-console-template for more information
Console.WriteLine(FirstBadVersion(2126753390));

int FirstBadVersion(int n)
{
    var left = 0;
    var right = n;
    int pivot = 0;

    while (left <= right)
    {
        pivot = (left + (right-left)) / 2;
        var pivotValue = IsBadVersion(pivot);

        if (pivotValue == false)
        {
            left = pivot + 1;
        }
        else
        {
            right = pivot - 1;
        }

    }

    if (!IsBadVersion(pivot))
        return pivot + 1;

    return pivot;
}

bool IsBadVersion(int version)
{
    if (version > 1702766719)
        return true;
    return false;
}