using Departments.Infrastracture.Context;
using Departments.Infrastracture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Infrastracture.Reposatories
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
