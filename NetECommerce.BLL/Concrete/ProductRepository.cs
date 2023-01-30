using NetEcommerce.DAL.Context;
using NetECommerce.BLL.Abstract;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NetECommerce.BLL.Concrete
{
    public class ProductRepository : IProductRepository
    {
       
        public List<Product> GetAll()
        {
            ProjectContext _db = new ProjectContext();
            return _db.Products.ToList();
        }
    }
}
