using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Infrastracture.Interfaces
{
    public interface IUniteOfWork
    {
        void Commit();
    }
}
