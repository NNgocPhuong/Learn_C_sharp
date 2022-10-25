
using System.Collections;

namespace Program
{
    class Program_test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            ArrayList myArray = new ArrayList();
            myArray.Insert(0, 1);
            myArray.Add(2);
            for (int i = 0; i < myArray.Count; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }
    }
}