
using Cinema.Domain.Domain;
using Cinema.Domain.identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public virtual DbSet<TicketInOrder> TicketInOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
      //  public virtual DbSet<EmailMessage> EmailMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Order>()
               .Property(z => z.Id)
               .ValueGeneratedOnAdd();

            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.Ticket)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCartId);

            builder.Entity<TicketInShoppingCart>()
                .HasOne(z => z.ShoppingCart)
                .WithMany(z => z.TicketInShoppingCarts)
                .HasForeignKey(z => z.TicketId);

            builder.Entity<ShoppingCart>()
                .HasOne<ApplicationUser>(z => z.Owner)
                .WithOne(z => z.UserCart)
                .HasForeignKey<ShoppingCart>(z => z.OwnerId);


            builder.Entity<TicketInOrder>()
                .HasOne(z => z.PurchasedTicket)
                .WithMany(z => z.TicketInOrders)
                .HasForeignKey(z => z.OrderId);

            builder.Entity<TicketInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.TicketInOrders)
                .HasForeignKey(z => z.TicketId);



            // add roles
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2",
                Name = "Standard_User",
                NormalizedName = "STANDARD_USER"
            });

            // sett admin user
            var appUser = new ApplicationUser
            {
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                EmailConfirmed = true,
                UserName = "admin@test.com",
                NormalizedUserName = "ADMIN@TEST.COM",
                PhoneNumberConfirmed = true
            };
            //set user password
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Pass123!");

            //seed user
            builder.Entity<ApplicationUser>().HasData(appUser);

            // shopping cart for admin user
            var shoppingCart = new ShoppingCart()
            {
                Id = Guid.NewGuid(),
                OwnerId = appUser.Id
            };
            builder.Entity<ShoppingCart>().HasData(shoppingCart);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = appUser.Id
            });
        }
    

    }
}
