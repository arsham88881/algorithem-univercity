using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithem.dynamicAlghorithemExample.fibonacci
{
    public interface IFibo
    {
        int GetFibo(int target);    ///پارامتر ورودی ان شماره جمله  ی درخواستی است
    }
    public class dynamicMethodFibo : IFibo
    {
        public int GetFibo(int target)
        {
            int[] array = new int[target + 1];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= target; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[target];
        }
    }
    public class RecursiveMethodFibo : IFibo
    {

        public int GetFibo(int target)
        {
            if (target <= 1)
            {
                return target;
            }
            else
            {
                return GetFibo(target - 1) + GetFibo(target - 2);
            }
        }
    }
}
