using System;

namespace ObserverPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Change subject and notify observers
            s.SubjectState = "123";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
