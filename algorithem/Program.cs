using algorithem.dynamicAlghorithemExample.fibonacci;
using algorithem.dynamicAlghorithemExample.Multiply;
using System.Reflection.Emit;

internal class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("-------------------------fibonacci-------------------------");

        ///درمثال پایین کاملا مشخص است که نمونه ی بازگشتی زمان را هدر میدهد


        dynamicMethodFibo method = new dynamicMethodFibo();

        Console.WriteLine("this is fibo 40: " + method.GetFibo(40)); //حدود ۱.۵ ثانیه

        RecursiveMethodFibo method1 = new RecursiveMethodFibo();

        Console.WriteLine("this is fibo 40: " + method1.GetFibo(40)); //بیشتر از ۶ ثانیه


        ///////////////////////////////////////////////////////////////////
        ///
        Console.WriteLine("------------------------binomial multiplication-----------------------");

        dynamicMethodMultiply method2 = new dynamicMethodMultiply();
        Console.WriteLine("combination 6 as 80 : " + method2.Multiply(80, 6)); // کمتر از ۲ ثانیه

        recursiveMethodMUltiply method3 = new recursiveMethodMUltiply();
        Console.WriteLine("combination 6 as 80 : " + method3.Multiply(80, 6)); //بیش از ۷ ثانیه 




        //به صورت غیرهمزمان نوشته شده است تا تفاوت در زمان مشهود باشد
        await Task.CompletedTask;
    }
}