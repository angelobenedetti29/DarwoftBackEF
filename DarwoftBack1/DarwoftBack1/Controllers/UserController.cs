using DarwoftBack1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarwoftBack1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
     
        [HttpGet]
        public IEnumerable<User> get()
        {
            using (var context = new DarwoftMarketContext())
            {
                //get all users
                return context.Users.ToList();

                //get user by id
                //return context.Users.Where(User => User.Id == 1).ToList();

                //add user 
                //var newUser = new User();
                //newUser.Username = "juan carlos";
                //newUser.Password = "juanCarlos123!";
                //newUser.IdTypeUser = 1;
                //context.Users.Add(newUser);
                //context.SaveChanges();

                //update user
                //var user = context.Users.Where(user => user.Username == "juan carlos").FirstOrDefault();
                //user.IdTypeUser = 2;
                //context.SaveChanges();

                //remuve user
                //var user = context.Users.Where(user => user.Username == " juan carlos").FirstOrDefault();
                //context.Users.Remove(user);
                //context.SaveChanges();

                //return context.Users.Where(user => user.Username == " juan carlos").ToList(); 



            }
        }
    }
}
