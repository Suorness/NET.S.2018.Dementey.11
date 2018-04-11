namespace Timer
{
    using System;
    using System.Threading;

    /// <summary>
    /// Implementing a timer with notification.
    /// </summary>
    public class TimerManager
    {
        public event EventHandler<TimerEventArgs> Notification = delegate { };

        /// <summary>
        /// Subscriber Notification.
        /// </summary>
        /// <param name="seconds">Delay time</param>
        /// <param name="message">Message for subscribers</param>
        public void NotifyOnTimer(int seconds, string message)
        {
            if (seconds < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(seconds)} must be greater than zero");
            }

            Thread.Sleep(seconds * 1000);
            OnNotification(this, new TimerEventArgs(seconds, message));
        }

        protected virtual void OnNotification(object sender, TimerEventArgs args)
        {
            var eventHandler = Notification;

            eventHandler?.Invoke(sender, args);
        }
    }
}
