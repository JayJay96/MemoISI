using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoISI
{
    static class RandomiseArray
    {
        private static Random random = new Random();

        public static Bitmap[] RandomPermutation(Bitmap[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i += 1)
            {
                int swapIndex = random.Next(i, sequence.Length);
                if (swapIndex != i)
                {
                    Bitmap temp = sequence[i];
                    sequence[i] = sequence[swapIndex];
                    sequence[swapIndex] = temp;
                }
            }

            return sequence;
        }
    }
}
