using AngSignalR2.DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL
{
    public class BingoDbContext : IdentityDbContext<BingoUser>
    {
        public BingoDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BingoDbContext Create()
        {
            return new BingoDbContext();
        }
    }
}