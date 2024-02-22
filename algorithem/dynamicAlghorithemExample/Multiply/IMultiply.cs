using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithem.dynamicAlghorithemExample.Multiply
{
    public interface IMultiply
    {
        int Multiply(int valence, int choose); //پرامتر اول کل مجموعه و پرامتر دوم انتخاب ما
    }
    public class dynamicMethodMultiply : IMultiply
    {
        public int Multiply(int valence, int choose)
        {
            int[,] array = new int[valence + 1, choose + 1];


            for (int i = 1; i <= valence; i++)
            {
                for (int j = 0; j <= ((valence<choose)?valence:choose); j++)
                {
                    if (i == j || j == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
                    }
                }
            }
            return array[valence, choose];
        }
    }
    public class recursiveMethodMUltiply : IMultiply
    {
        public int Multiply(int valence, int choose)
        {
            if (valence == choose || choose == 0)
            {
                return 1;
            }
            else
            {
                return Multiply(valence - 1, choose - 1) + Multiply(valence - 1, choose);
            }
        }
    }

}
