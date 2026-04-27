using src.ObserverDesignPattern.Models;

namespace src.ObserverDesignPattern.Notification
{
    public interface INotification
    {
        void SendMessage(User user, Product product);
    }
}