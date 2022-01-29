using Domain;
using Entities;
using Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFacultyRepository : IDbRepository<Faculty>
    {
    }
}
