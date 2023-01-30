using System;
using System.Collections.Generic;
using System.Text;
using NetECommerce.Entity.Entity;

namespace NetECommerce.BLL.Abstract
{
    public interface IProductRepository<Tip>
    {
        public List<Tip> GetAll();
        public Tip Create(Tip tip);
        public Tip Update(Tip tip);
        public Tip Delete(int tip);

  
    }
}
