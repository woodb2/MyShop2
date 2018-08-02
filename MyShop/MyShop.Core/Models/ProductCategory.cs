using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        //removed as it is in Base Entity
        //public string Id { get; set; }
        public string Category { get; set; }

        // Not needed, creation is handled in BaseEntity
        //public ProductCategory()
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}
    }
}
