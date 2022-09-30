int[,] positions = new [,]{
    {100,100},
    {200,100},
};
Console.WriteLine(string.Join(",", Stairs(positions)));
static int[] Stairs (int[,] positions)
{
    int[] output = new int[positions.GetLength(0)];
    for(int i = 0; i< positions.GetLength(0); i++)
    {
        if(i == 0)
        {
            output[0] = positions[0,1];
        }
        else{
            if(positions[i, 0] < (positions[i-1, 1] + positions[i-1, 0]))
            {
                output[i] = positions[i,1] + positions[i-1, 1];
            }
            else if(output[i-1] > positions[i, 1]) {
                output[i] = output[i-1];
            }
            else{
                output[i] = positions[i, 1];
            }
        }
    }
    return output;
}