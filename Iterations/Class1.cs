// Training exercises from Codility

using System;

namespace Iterations
{
    public class BinaryGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            int N = 561892; 

            BinaryGap binaryGap = new BinaryGap();
            Console.WriteLine(binaryGap.Solution(N));
        }

        
        public int Solution(int N)
        {
            // convert integer to binary and save as a string
            var binNum = Convert.ToString(N, 2);

            //pre default validations
            if (binNum == "0" || binNum == "1" || !binNum.Contains("0") || binNum.Length==2)
                return 0;

            if (binNum.Length == 3)
            {
                if (binNum == "101")
                     return 1;
                else return 0;
            }

            bool foundOne = false;
            int binGapValue = 0;
            int returnGapValue = 0;

            // Loop through each character
            for(int n = 0; n < binNum.Length; n++)
            {
                if (foundOne == true && binNum.Substring(n, 1) == "0")
                    binGapValue++;

                if (binNum.Substring(n,1) == "1")
                {
                    if (binGapValue > returnGapValue )
                        returnGapValue = binGapValue;
                    else
                        foundOne = true;

                    binGapValue = 0;
                }
            }
            return returnGapValue;
        }
    }
}
