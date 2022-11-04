int[]lonelyArray = {10,6,5,8};
for (int i = 0; i <lonelyArray.Length; i++)
{
    if (lonelyArray[i]-1 ==lonelyArray[i+1] || lonelyArray[i]+1 ==lonelyArray[i+1] || lonelyArray[i] == lonelyArray[i+1])
    {
        System.Console.WriteLine($"{lonelyArray[i]} is not lonely");
    }
    else
    {
        System.Console.WriteLine($"{lonelyArray[i]} are lonely");
    }
}
































































