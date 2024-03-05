using Departments.Data;
using Departments.Infrastracture.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Infrastracture.Reposatories
{
    public class DepartmentReposatory : Manger<Department>
    {
        public DepartmentReposatory(AppDbContext db) : base(db)
        {
        }
    }
}
