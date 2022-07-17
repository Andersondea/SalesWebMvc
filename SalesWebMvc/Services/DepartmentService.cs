using SalesWebMvc.Data.Models;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _contex;

        public DepartmentService(SalesWebMvcContext contex)
        {
            _contex = contex;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _contex.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
