using SalesWebMvc.Data.Models;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _contex;

        public DepartmentService(SalesWebMvcContext contex)
        {
            _contex = contex;
        }

        public List<Department> FindAll()
        {
            return _contex.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
