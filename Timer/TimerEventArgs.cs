namespace Timer
{
    using System;

    /// <summary>
    /// Information about the arguments of the event.
    /// </summary>
    public class TimerEventArgs : EventArgs
    {
        private int _notificationInterval;

        public TimerEventArgs(int notificationInterval, string message)
        {
            NotificationInterval = notificationInterval;
            Message = message;
        }

        public int NotificationInterval
        {
            get
            {
                return _notificationInterval;
            }

            private set
            {
                if (value > 0)
                {
                    _notificationInterval = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be great zero.");
                }
            }
        }

        public string Message { get; }
    }
}
