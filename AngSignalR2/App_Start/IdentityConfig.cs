using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using AngSignalR2.DAL.Models;
using AngSignalR2.DAL;

namespace AngSignalR2
{
    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.

    public class BingoUserManager : UserManager<BingoUser>
    {
        public BingoUserManager(IUserStore<BingoUser> store)
            : base(store)
        {
        }

        public static BingoUserManager Create(IdentityFactoryOptions<BingoUserManager> options, IOwinContext context)
        {
            var manager = new BingoUserManager(new UserStore<BingoUser>(context.Get<BingoDbContext>()));
            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<BingoUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<BingoUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }
}
