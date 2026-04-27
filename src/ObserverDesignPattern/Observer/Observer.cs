using src.ObserverDesignPattern.Models;
using src.ObserverDesignPattern.Notification;
using src.ObserverDesignPattern.Observable;

namespace src.ObserverDesignPattern.Observer
{
    public class Observer: IObserver
    {
        private IObservable _observable;

        private INotification _notification;

        public User User{get; private set;}

        public Observer(IObservable observable, INotification notification, User user)
        {
            _observable = observable;
            _notification = notification;
            this.User = user;
        }
        public void Update()
        {
            _notification.SendMessage(this.User, _observable.GetData());
        }
    }
}