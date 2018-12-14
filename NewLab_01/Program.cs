using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordLength = 8;
            int checkBitsLength = 4;

            Console.Write("Please, input your full name: \n>");
            string inputString = Console.ReadLine().ToLower();

            byte[] inputStringByteArray = System.Text.Encoding.UTF8.GetBytes(inputString);

            BitArray inputStringBitArray = new BitArray(inputStringByteArray);

            int[] inputIntArray = BoolArrayToIntArray(inputStringBitArray);

            int[,] encodeIntArray = new int[inputIntArray.Length/wordLength, wordLength + checkBitsLength];

            int iterator = 0;

            for (int i = 0; i < inputIntArray.Length / wordLength; i++)
            {
                for (int j = 0; j < wordLength ; j++)
                {
                    encodeIntArray[i, j] = inputIntArray[iterator];
                    iterator++;
                }
            }



            Console.ReadKey();
        }

        static int[] BoolArrayToIntArray(BitArray sourceBoolArray)
        {
            var resultIntArray = new int[sourceBoolArray.Count];

            for(int i = 0; i < sourceBoolArray.Length ; i++)
            {
                resultIntArray[i] = sourceBoolArray[i] == true ? 1 : 0;
            }

            return resultIntArray;
        }
    }
}
