using AngSignalR2.DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngSignalR2.DAL
{
    public class BingoDbContext : IdentityDbContext<BingoUser>
    {

        public DbSet<Message> Messages { get; set; }
        public DbSet<BingoGame> BingoGames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BingoGame>()
                .HasMany<BingoUser>(b => b.BingoUsers)
                .WithMany(g => g.BingoGames)
                .Map(t => t.MapLeftKey("BingoGameId")
                    .MapRightKey("BingoUserId")
                    .ToTable("UserGame"));

            modelBuilder.Entity<BingoUser>()
                .HasMany<Message>(u => u.Messages)
                .WithRequired(m => m.BingoUser)
                .HasForeignKey(m => m.BingoUserId);

            modelBuilder.Entity<BingoGame>()
                .HasMany<Message>(g => g.Messages)
                .WithOptional(m => m.BingoGame)
                .HasForeignKey(m => m.BingoGameId);
        }

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