using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Omu.ValueInjecter;

namespace AngSignalR2.DAL.Models
{
    public class BingoUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<BingoUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public ICollection<Message> Messages { get; set; }
        public ICollection<BingoGame> BingoGames { get; set; }

    }

    public class BingoUserVM
    {
        public string UserName { get; set; }        
    }

    public class BingoUserScoreVM
    {
        public string UserName { get; set; }
        public string TotalScore { get; set; }
        public string HighScore { get; set; }
    }

    public class BingoUserBM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}