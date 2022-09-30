var survivor = Asteroids(new int[] {-5,-2,10,70,-99,80,78,-56,1000,-670});
string output = string.Join(",", survivor);
Console.WriteLine($"Output = [{output}]");


static List<int> Asteroids(int[] asteroids)
{
    string representation = string.Join(",", asteroids);
    string[] Survivors = representation.Split(',');
    for (int i = 0; i < Survivors.Length; i++)
    {
        if (Survivors[i] != "removed" && int.Parse(Survivors[i]) < 0)
        {
            for (int j = i - 1; j >= 0 && j < Survivors.Length; j--)
            {
                if (Survivors[j] != "removed" && int.Parse(Survivors[j]) >= 0)
                {
                    if (Math.Abs(int.Parse(Survivors[i])) > Math.Abs(int.Parse(Survivors[j])))
                    {
                        Survivors[j] = "removed";
                    }
                    else if (Math.Abs(int.Parse(Survivors[i])) == Math.Abs(int.Parse(Survivors[j])))
                    {
                        Survivors[i] = "removed";
                        Survivors[j] = "removed";
                        break;
                    }
                    else
                    {
                        Survivors[i] = "removed";
                        break;
                    }
                }
            }
        }
    }

    var Remaining = new List<int> { };
    foreach (var item in Survivors)
    {
        if (item != "removed") Remaining.Add(int.Parse(item));
    }
    return Remaining;
}
