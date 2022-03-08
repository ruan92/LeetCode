// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int FirstUniqChar(string s)
{
    var index = new Dictionary<char, int>();

    foreach (var c in s)
    {
        if (!index.TryAdd(c, 1))
        {
            if (index.TryGetValue(c, out var value))
            {
                index.Remove(c);
                index.Add(c, ++value);
            }
        }
    }

    for (int i = 0; i < s.Length; i++)
    {
        if (index[s[i]] == 1)
            return i;
    }

    return -1;

}