using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Data;
using UserApp.Infrastracture.Context;

namespace User.Infrastracture.Reposatories
{
    public class UserReposatory : Manger<Users>
    {
        
        public UserReposatory(AppDbContext db) : base(db)
        {
        }
       
    }
}
