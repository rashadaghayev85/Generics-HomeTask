using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeTask
{
    internal class IntList
    {
        private int[] intArray;
        public IntList()
        {
            intArray = new int[0];
        }
        public void Add(int num)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;
        }

        public int[] GetAll()
        {
            return intArray;
        }
        public int[] Delete(int num)
        {

            int[] arr = new int[0];
            bool a = true;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == num)
                {

                    continue;

                }
                else
                {

                    while (a == true)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = intArray[i];

                        if (i == intArray.Length - 1)
                        {
                            a = false;
                        }
                        break;

                    }

                }

            }
            
            return arr;
        }

    }
}

