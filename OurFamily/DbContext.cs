using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFamily
{
    internal class DbContext
    {
        public static List<User> UserList=new List<User>();
        public DbContext()
        {
            User user = new User()
            {
                Id = 1,
                UserName ="se",
                Password ="3",
                Name ="Sema",
                Surname ="Gerger",
              

            };
            UserList.Add(user);
            
        }
    }
}
