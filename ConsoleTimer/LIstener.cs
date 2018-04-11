namespace ConsoleTimer
{
    using System;
    using Timer;

    public class Listener
    {
        public void Notify(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"Message: {e.Message}");
        }
    }
}
