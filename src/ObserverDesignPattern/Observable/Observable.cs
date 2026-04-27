using System;
using System.Collections.Generic;
using src.ObserverDesignPattern.Models;
using src.ObserverDesignPattern.Observer;

namespace src.ObserverDesignPattern.Observable
{
    public class Observable: IObservable
    {
        private List<IObserver> _observersList = new List<IObserver>();

        public Product Product{get; private set;}

        public Observable(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException();
            }
            Product = product;
        }
        public void AddObserver(IObserver obj)
        {
            if(obj == null || _observersList.Contains(obj)) return;
            _observersList.Add(obj);
        }

        public void RemoveObserver(IObserver obj)
        {
            if(obj == null || !_observersList.Contains(obj)) return;
            _observersList.Remove(obj);
        }

        public void NotifySubscribers()
        {
            foreach(var observer in _observersList)
            {
                observer.Update();
            }
        }

        public Product GetData()
        {
            return Product;
        }

        public void SetQuantity(int Quantity)
        {
            bool wasOutOfStock = Product.Quantity == 0;
            Product.Quantity += Quantity;

            if(wasOutOfStock && Product.Quantity > 0)
            {
                NotifySubscribers();
            }
        }
    }
}