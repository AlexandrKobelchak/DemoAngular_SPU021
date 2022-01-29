using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using System;

namespace Repositories
{
    public class FacultyRepository : GenericRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(DbContext context) : base(context)
        {
        }
    }
}
