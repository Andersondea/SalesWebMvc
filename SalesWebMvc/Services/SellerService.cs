using SalesWebMvc.Data.Models;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _contex;

        public SellerService(SalesWebMvcContext contex)
        {
            _contex = contex;
        }

        public List<Seller> FindAll() => _contex.Seller.ToList();

        public void Insert(Seller obj)
        {
            obj.Department = _contex.Department.First();
            _contex.Add(obj);
            _contex.SaveChanges();
        }
    }
}
