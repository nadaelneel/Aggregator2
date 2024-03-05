using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Infrastracture.Interface;
using UserApp.Infrastracture.Context;

namespace User.Infrastracture.Reposatories
{
    public class UniteOfWork : IUniteOfWork
    {
        private AppDbContext dbContext;

        public UniteOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }
    }
}
