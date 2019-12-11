using System;
using System.Threading;

namespace AsyncLesson
{
    class Program
    {
        //delegate int MyAction(); 
        static void Main(string[] args)
        {
            //var action = new MyAction(CalculateSophisticNumber);
            var action = new Func<int>(CalculateSophisticNumber);
            //action();
            var result = action.Invoke();
            Console.WriteLine(result);
            Console.WriteLine("Главный поток завершил работу");
            Console.ReadLine();
        }

        private static int CalculateSophisticNumber()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - выполняет работу");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - закончил работу метода");
            return 20000;
        }
    }
}
