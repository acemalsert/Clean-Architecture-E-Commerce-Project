using EComm.Application.DTOs;

namespace EComm.Application.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand {get;set;}
    }
}
