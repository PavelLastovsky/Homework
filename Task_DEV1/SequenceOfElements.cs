using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DEV1
{
    public class SequenceOfElements
    {
        public static int MaxDifferentElements(string YourString)
        {
            if (YourString == null)
                return 0;
            int Count = 1;
            int FinalCount = 0;
            int length = YourString.Length;
            
                for (int i = 0; i < length; i++)
                {

                    if (i < length - 1 && YourString[i] != YourString[i + 1])
                    {
                        Count++;
                    }
                    else
                    {

                        if (Count > FinalCount)
                        {
                            FinalCount = Count;
                        }

                        Count = 1;
                    }
                }
                return FinalCount;
            
        }
    }
}
