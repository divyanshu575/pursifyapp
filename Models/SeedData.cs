using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using pursifyapp.Data;
using System;
using System.Linq;

namespace pursifyapp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new pursifyappContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<pursifyappContext>>()))
            {
                // Look for any purses.
                if (context.Purse.Any())
                {
                    return;   // DB has been seeded
                }
                context.Purse.AddRange(
                    new Purse
                    {
                        Name = "Scudera Ferrari Style Wallet",
                        Type = "Wallet",
                        Color = "Red",
                        Material = "Polyester",
                        Comp = 4,
                        Size = "Small",
                        Price = 700

                    },

                    new Purse
                    {
                        Name = "Gucci GG Marmont Bifold Wallet",
                        Type = "Wallet",
                        Color = "Black",
                        Material = "Leather",
                        Comp = 6,
                        Size = "Small",
                        Price = 650

                    },

                    new Purse
                    {
                        Name = "Tom Ford Micro Grain Bifold Wallet",
                        Type = "Wallet",
                        Color = "Brown",
                        Material = "Leather",
                        Comp = 5,
                        Size = "Small",
                        Price = 750

                    },

                    new Purse
                    {
                        Name = "Balenciaga Superbusy Messenger Bag",
                        Type = "Messenger bag",
                        Color = "Blue",
                        Material = "Leather",
                        Comp = 5,
                        Size = "Medium",
                        Price = 3000
                    },
                   new Purse
                   {
                       Name = "Swissgear Anti-Theft Backpack",
                       Type = "Backpack",
                       Color = "Grey",
                       Material = "Polyester",
                       Comp = 2,
                       Size = "Large",
                       Price = 140
                   },

                   new Purse
                   {
                       Name = "Ralph Lauren Ranger Backpack",
                       Type = "Backpack",
                       Color = "Green",
                       Material = "Polyester",
                       Comp = 2,
                       Size = "Large",
                       Price = 250
                   },

                     new Purse
                     {
                         Name = "Adidas Defender Duffle bag",
                         Type = "Duffle bag",
                         Color = "Blue",
                         Material = "Polyester",
                         Comp = 4,
                         Size = "Large",
                         Price = 55
                     },
                     new Purse
                     {
                         Name = "Special Edition Ranger Backpack",
                         Type = "Backpack",
                         Color = "Olive Green",
                         Material = "PU",
                         Comp = 3,
                         Size = "Large",
                         Price = 199
                     },
                     new Purse
                     {
                         Name = "Ovel Model Wallet",
                         Type = "Wallet",
                         Color = "Orange",
                         Material = "Polyester",
                         Comp = 2,
                         Size = "Large",
                         Price = 99
                     },
                     new Purse
                     {
                         Name = "Rolex Wallet",
                         Type = "Wallet",
                         Color = "Pink",
                         Material = "genuine Leather ",
                         Comp = 2,
                         Size = "Large",
                         Price = 350
                     }

                );
                context.SaveChanges();
            }
        }
    }
}
