using PicturePlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlanner.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }
            var users = new User[]
            {
                new User{Name="Test User 1",Status=0,Email="testuser1@testemaildomain.com",Password="testpass1"},
                new User{Name="Test User 2",Status=0,Email="testuser2@testemaildomain.com",Password="testpass2"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
