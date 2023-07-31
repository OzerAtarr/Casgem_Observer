using Casgem_Observer.DAL;
using Casgem_Observer.ObservePattern;
using System.Drawing;

namespace Casgem_Observer.ObserveePattern
{
    public class CreateMagazineAnnounComment : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context _context = new Context();

        public CreateMagazineAnnounComment(IServiceProvider serviceProvider, Context contex)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Spor Dergisi",
                Content = "Spor Dergimizin Ağustos 2023 Sayısı Bayimize Geldi"
            });
            _context.SaveChanges();
        }
    }

    
}
