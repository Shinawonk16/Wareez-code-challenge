using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplyOriginal();
            
        }
        static void MultiplyOriginal()
        {
            int[]myArray = {5,3,6,1,12};
            // int original = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]* 2 == myArray[i+1])
                {
                     if (myArray[i+1]*2 == myArray[i+2])
                    {
                        if (myArray[i+3]*2 ==myArray[i+4] )
                        {
                            System.Console.WriteLine($"{myArray[i+4] * 2}");
                        }
                    }
                    else if (myArray[i+2]*2 == myArray[i+3])
                    {
                            System.Console.WriteLine($"{myArray[i+3]*2}");
                    }
                   
                    
                }
                else if (myArray[i+1]*2 == myArray[i+2])
                {
                    if (myArray[i+2]*2 == myArray[i+3])
                    {
                        if (myArray[i+3]*2 ==myArray[i+4] )
                        {
                            System.Console.WriteLine($"{myArray[i+4]* 2} ");
                        }
                    }
                    else if (myArray[i+2]*2 == myArray[i+4])
                    {
                        System.Console.WriteLine($"{myArray[i+4]*2}");
                    }
                }
                // else
                // {
                //     // System.Console.WriteLine($"{myArray[i]* 2}");
                // }
            }        
            

        }
    }
}        
