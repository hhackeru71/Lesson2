using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //המרות

            //המרה מטיפוס מספר לטיפוס מחרוזת
            int age = 30;
            string afterConvert = age.ToString();

            string number1 = "300";
            int number5 = int.Parse(number1);
            age = int.Parse(number1);//המרה ממחרוזת למספר חייב להיות המחרוזת אך ורק מספר
            Console.WriteLine("number5  ", number5);
            //number1 = "sdf";
            //age = int.Parse(number1);//error
            //Console.WriteLine("number1 is not int {0} ", number1);

            double number4 = double.Parse(number1);
            Console.WriteLine("number4  {0} ", number4);

            //המרה מרומזת
            int number6 = 6;
            double number7 = number6;
            Console.WriteLine("number7 {0} ", number7);

            //המרה מפורשת
            double number8 = 99.2;
            int number10 = (int)number8;//המרה רק כשיש טיפוס מסוג מספר 
            Console.WriteLine("number10 {0} ", number10);

            //string number12 = "3";
            //number10 = (int)(number12);//error

            string number13 = "4";
            int number14 = Convert.ToInt32(number13);
            Console.WriteLine("number14 {0} ", number14);

            double number15 = 4294967;
            int number17 = Convert.ToInt32(number15);
            Console.WriteLine("number17 {0} ", number17);

            //3 סוגי המרות של מספר
            //1. int.Parse(number1);
            //2. (int)number8
            //3. Convert.ToInt32(number13)

        }
    }
}
