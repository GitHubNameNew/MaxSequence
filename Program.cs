using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxSeqSize = 1;
            int tempSeqSize = 1;
            int seqElemValue = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempSeqSize++;

                    if (tempSeqSize > maxSeqSize)
                    {
                        maxSeqSize = tempSeqSize;
                        arr[i] = seqElemValue;
                    }
                }
                else
                {
                    tempSeqSize = 1;
                }
            }
            Console.WriteLine(maxSeqSize);
        }
    }
}
