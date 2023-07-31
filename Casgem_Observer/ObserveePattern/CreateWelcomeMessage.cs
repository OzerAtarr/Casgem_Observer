using Casgem_Observer.DAL;
using Casgem_Observer.ObservePattern;

namespace Casgem_Observer.ObserveePattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context _context = new Context();

        public void CreateNewUser(AppUser appUser)
        {
            _context.WelComeMessages.Add(new WelComeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize abone olduğunuz için teşekkir ederiz, hoş geldiniz."
            });
            _context.SaveChanges();
        }
    }
}
