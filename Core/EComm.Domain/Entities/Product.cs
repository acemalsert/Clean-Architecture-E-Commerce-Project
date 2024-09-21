using EComm.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product() { }
        public Product(string title, string description, int brandId, decimal price, decimal discount)
        {
            this.Title = title;
            this.Description = description;
            this.BrandId = brandId;
            this.Price = price;
            this.Discount = discount;
        }

        public string Title {  get; set; }
        public string Description { get; set; }
        public int BrandId {  get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand Brand { get; set; }

        // Since we are using unit of work we can't use EF Core's auto created intermediary table 
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
