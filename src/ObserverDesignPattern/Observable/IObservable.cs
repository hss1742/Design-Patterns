using src.ObserverDesignPattern.Models;
using src.ObserverDesignPattern.Observer;

namespace src.ObserverDesignPattern.Observable
{
    public interface IObservable
    {
        void AddObserver(IObserver obj);

        void RemoveObserver(IObserver obj);

        void NotifySubscribers();

        Product GetData();

        void SetQuantity(int quantity);
    }
}