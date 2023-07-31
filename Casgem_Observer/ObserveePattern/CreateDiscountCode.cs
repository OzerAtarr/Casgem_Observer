using Casgem_Observer.DAL;
using Casgem_Observer.ObservePattern;

namespace Casgem_Observer.ObserveePattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGIAGUSTOS",
                DiscountAmount = 25,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
