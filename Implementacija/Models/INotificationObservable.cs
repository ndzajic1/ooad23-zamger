﻿namespace ooadproject.Models
{
    public interface INotificationObservable
    {
        void Attach(NotificationManager notifications);
        void Detach();
        Task Notify();
    }
}
