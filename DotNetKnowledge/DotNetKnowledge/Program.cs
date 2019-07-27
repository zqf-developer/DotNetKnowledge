using System;

namespace DotNetKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            {
                //表明原始值类型和装箱的对象使用不同的内存位置，因此能够存储不同的值
                Console.WriteLine("============装箱================");

                var value = 10;

                object obj = value;

                value = 12;

                Console.WriteLine("The value-type value = {0}", value);
                Console.WriteLine("The object-type value = {0}", obj);
                Console.WriteLine("============装箱================");
            }

            {

                int i = 123;      // a value type
                object o = i;     // boxing
                int j = (int)o;   // unboxing
                Console.WriteLine("The value-type value = {0}", i);
                Console.WriteLine("The object-type value = {0}", o);
                Console.WriteLine("The value-type value = {0}", j);

            }
        }
    }
}
