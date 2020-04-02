using System;

namespace Task_DEV1
{
    public class FindMaxDifferentSymbolsInSequence
    {
        /// <summary>
        /// Find maximum length of sequence with different elements in entered string from console
        /// </summary>
        /// <param name="YourString"> Your string with sequence of elements </param>
        /// <returns> Maximum length of sequence with different elements in entered string as quantity of this elements </returns>
        public static int ReturnLengthOfMaxDifferentSymbols(string YourString)
        {
            if (YourString == null)
            {
                throw new NullReferenceException();
            }

            int Count = 1, FinalCount = 0, Length = YourString.Length;
            
                for (int i = 0; i < Length; i++)
                {

                    if (i < Length - 1 && YourString[i] != YourString[i + 1])
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
