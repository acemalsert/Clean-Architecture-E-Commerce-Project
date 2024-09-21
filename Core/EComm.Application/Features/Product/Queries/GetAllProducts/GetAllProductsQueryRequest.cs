using EComm.Application.Interfaces.RedisCache;
using MediatR;

namespace EComm.Application.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllProducts";
        public double CacheTime => 60;
    }
}
