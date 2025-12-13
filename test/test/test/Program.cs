using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args) {
            //var number = 3;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "Ashmoon";
            //var isLearning = true;
            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isLearning);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);

            try
            {
                //var number = "1234";
                //byte I = Convert.ToByte(number);
                //Console.WriteLine(I);

                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte!");
            }

            int aa = 1;
            int bb = aa++;
            Console.WriteLine(aa);
            Console.WriteLine(bb);


            var A = 10;
            var B = 3;
            Console.WriteLine((float)A != (float)B);
        }
    }
}