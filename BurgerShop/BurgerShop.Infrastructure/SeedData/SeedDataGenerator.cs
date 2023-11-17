using Bogus;
using BurgerShop.Domain.Entities.Concrete;
using BurgerShop.Domain.Enums;
using BurgerShop.Infrastructure.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BurgerShop.Infrastructure.SeedData
{
    public static class SeedDataGenerator
    {
        static List<Extra> extras = new List<Extra>();
        static List<Menu> menus = new List<Menu>();
        static List<AppUser> users = new List<AppUser>();
        static List<Order> orders = new List<Order>();
        static List<OrdersMenus> ordersMenus = new List<OrdersMenus>();
        static List<OrdersExtras> ordersExtras = new List<OrdersExtras>();

        static string[] extraList = new[] { "Avocado Sauce", "Curry Mayo Sauce", "Spicy Remoulade Sauce", "Roasted Garlic-Balsamic Aioli Sauce", "Herbed Mayo Sauce", "Sriracha Sauce", "Roasted Bell Pepper Sauce", "Chipotle And Lime Mayo Sauce", "Garlicky Mayo Sauce", "Toasted Sesame And Soy Mayo Sauce", "Ketchup Sauce", "Mustard Sauce", "Buffalo Sauce", "Honey Mustard Sauce", "BBQ Sauce", "Chili Cheese Sauce", "Spicy Mustard Sauce", "Ranch Sauce", "Spicy Sauce" };

        static string[] menuList = new[] { "Cheeseburger", "The Hurt Burger", "Bacon Cheeseburger", "Classic Cheeseburger", "Salmon Burger", "Seafood Burger", "BBQ Burger", "Vegetarian Burger" };

        public static void Seed(IApplicationBuilder app, int userCount)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.Migrate();

                GetMenuGenerator();
                GetExtraGenerator();

                if (!context.Menus.Any())
                {
                    context.Menus.AddRange(menus);
                    context.SaveChanges();
                }

                if (!context.Extras.Any())
                {
                    context.Extras.AddRange(extras);
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    GetAppUserGenerator(userCount);
                    context.Users.AddRange(users);
                    context.SaveChanges();
                }

                void GetExtraGenerator()
                {
                    foreach (var extra in extraList)
                    {
                        Extra extraFake = new Faker<Extra>()
                                .RuleFor(e => e.Id, _ => Guid.NewGuid())
                                .RuleFor(e => e.ExtraName, _ => extra)
                                .RuleFor(e => e.ExtraPrice, f => f.Random.Decimal(1, 5))
                                .RuleFor(e => e.CreatedDate, f => f.Date.Past(1))
                                .RuleFor(e => e.Status, f => f.Random.Bool(0.9f) ? Status.Active : Status.Passive);

                        extras.Add(extraFake);
                    }
                }

                void GetMenuGenerator()
                {
                    foreach (var menu in menuList)
                    {
                        foreach (var menuSize in Enum.GetValues<MenuSize>())
                        {
                            var menuFake = new Faker<Menu>()
                                    .RuleFor(e => e.Id, _ => Guid.NewGuid())
                                    .RuleFor(e => e.MenuName, _ => menu)
                                    .RuleFor(e => e.MenuPrice, f => f.Random.Decimal(8, 15))
                                    .RuleFor(e => e.MenuSize, _ => menuSize)
                                    .RuleFor(e => e.CreatedDate, f => f.Date.Past(1))
                                    .RuleFor(e => e.Status, f => f.Random.Bool(0.9f) ? Status.Active : Status.Passive);

                            menus.Add(menuFake);
                        }
                    }
                }

                void GetAppUserGenerator(int userCount)
                {
                    var userFake = new Faker<AppUser>()
                                 .RuleFor(u => u.Id, _ => Guid.NewGuid())
                                 .RuleFor(u => u.CreatedDate, f => f.Date.Past(1))
                                 .RuleFor(u => u.Status, f => f.Random.Bool(0.9f) ? Status.Active : Status.Passive)
                                 .RuleFor(u => u.BirthDate, f => f.Date.Between(new DateTime(1975, 01, 01), DateTime.Now.AddYears(-18)))
                                 .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                                 .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                                 .RuleFor(u => u.LastName, f => f.Name.LastName())
                                 .RuleFor(u => u.UserName, f => f.Person.UserName)
                                 .RuleFor(u => u.Email, f => f.Person.Email)
                                 .RuleFor(u => u.EmailConfirmed, f => f.Random.Bool(0.75f) ? true : false)
                                 .RuleFor(u => u.PhoneNumber, f => f.Person.Phone)
                                 .RuleFor(u => u.Orders, (_, u) =>
                                 {
                                     return GetOrderGenerator(u.Id, _.Random.SByte(3, 10));
                                 });

                    users.AddRange(userFake.Generate(userCount));
                }

                List<Order> GetOrderGenerator(Guid userId, int orderCount)
                {
                    var orderFake = new Faker<Order>()
                                    .RuleFor(o => o.Id, _ => Guid.NewGuid())
                                    .RuleFor(o => o.AppUserId, _ => userId)
                                    .RuleFor(o => o.OrderQuantity, f => f.Random.Bool(0.9f) ? (short)1 : (short)2)
                                    .RuleFor(o => o.OrderStatus, f => f.PickRandom<OrderStatus>())
                                    .RuleFor(o => o.OrderDate, f => f.Date.Past(1))
                                    .RuleFor(o => o.ShippedDate, f => f.Date.Past(1))
                                    .RuleFor(o => o.Notes, f => f.Random.Bool(0.5f) ? f.Lorem.Sentence(50, 45) : default)
                                    .RuleFor(o => o.ShippedAddress, f => f.Address.FullAddress())
                                    .RuleFor(o => o.CreatedDate, f => f.Date.Past(1))
                                    .RuleFor(o => o.Status, f => f.Random.Bool(0.9f) ? Status.Active : Status.Passive)
                                    .RuleFor(o => o.OrdersMenus, (_, o) =>
                                    {
                                        return GetOrdersMenusGenerator(o.Id, _.Random.SByte(1, 5));
                                    })
                                    .RuleFor(o => o.OrdersExtras, (_, o) =>
                                    {
                                        return GetOrdersExtrasGenerator(o.Id, _.Random.SByte(0, 5));
                                    });
                    orders.AddRange(orderFake.Generate(orderCount));
                    if (!context.Orders.Any())
                    {
                        context.Orders.AddRange(orders);
                    }
                    return orders;
                }

                List<OrdersMenus> GetOrdersMenusGenerator(Guid orderId, int menuCount)
                {   
                    var menusToSelect = menus;
                    for (int i = 0; i < menuCount; i++)
                    {
                        var selectMenu = new Random().Next(0, menusToSelect.Count);
                        //TODO: Her seferinde farklı menü eklenmesi gerekiyor.
                        var ordersMenusFake = new Faker<OrdersMenus>()
                                            .RuleFor(om => om.OrderId, orderId)
                                            .RuleFor(om => om.MenuId, _ => menusToSelect[selectMenu].Id)
                                            .RuleFor(om => om.MenuPrice, _ => menusToSelect[selectMenu].MenuPrice)
                                            .RuleFor(om => om.MenuQuantity, f => f.Random.Short(1, 5));

                        ordersMenus.Add(ordersMenusFake);
                        menusToSelect.Remove(menusToSelect[selectMenu]);
                    }
                    if (!context.OrdersMenus.Any())
                    {
                        context.OrdersMenus.AddRange(ordersMenus);
                    }
                    return ordersMenus;
                }

                List<OrdersExtras> GetOrdersExtrasGenerator(Guid orderId, int extraCount)
                {
                    var extrasToSelect = extras;
                    for (int i = 0; i < extraCount; i++)
                    {
                        var selectExtra = new Random().Next(0, extrasToSelect.Count);
                        //TODO: Her seferinde farklı extra eklenmesi gerekiyor.
                        var ordersExtrasFake = new Faker<OrdersExtras>()
                                            .RuleFor(om => om.OrderId, orderId)
                                            .RuleFor(om => om.ExtraId, _ => extrasToSelect[selectExtra].Id)
                                            .RuleFor(om => om.ExtraPrice, _ => extrasToSelect[selectExtra].ExtraPrice)
                                            .RuleFor(om => om.ExtraQuantity, f => f.Random.Short(1, 3));

                        ordersExtras.Add(ordersExtrasFake);
                        extrasToSelect.Remove(extrasToSelect[selectExtra]);
                    }
                    if (!context.OrdersExtras.Any())
                    {
                        context.OrdersExtras.AddRange(ordersExtras);
                    }
                    return ordersExtras;
                }
            }
        }

    }
}
