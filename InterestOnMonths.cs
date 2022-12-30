using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percent


{
    internal class InterestOnMonths
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            Console.WriteLine(Calculate(userInput));

            Console.ReadKey();

        }
        public static double Calculate(string userInput)
        {
            string[] numArray = userInput.Split(new char[] { ' ' });//Возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.

            double sumOfmoney = Double.Parse(numArray[0], System.Globalization.CultureInfo.InvariantCulture);
            double percent = Double.Parse(numArray[1], System.Globalization.CultureInfo.InvariantCulture);
            double months = Double.Parse(numArray[2], System.Globalization.CultureInfo.InvariantCulture);

            return sumOfmoney*Math.Pow((1+(percent/100)/12), months);
        }
    }
}
