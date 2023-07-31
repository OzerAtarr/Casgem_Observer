using Casgem_Observer.DAL;
using Casgem_Observer.ObservePattern;
using System;

namespace Casgem_Observer.ObserveePattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notifyserver(AppUser appUser)
        {
            _observers.ForEach(x=>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}
