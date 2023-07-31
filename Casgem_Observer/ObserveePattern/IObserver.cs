using Casgem_Observer.DAL;

namespace Casgem_Observer.ObservePattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
