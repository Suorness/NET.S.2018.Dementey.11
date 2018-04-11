namespace ConsoleTimer
{
    using System;
    using Timer;

    public class Program
    {
        public static void Main(string[] args)
        {
            var timer = new TimerManager();

            var listener1 = new Listener();
            var listener2 = new Listener();

            timer.Notification += listener1.Notify;
            timer.Notification += listener2.Notify;

            timer.NotifyOnTimer(3, "Waiting 3 seconds");

            Console.ReadLine();
        }
    }
}
