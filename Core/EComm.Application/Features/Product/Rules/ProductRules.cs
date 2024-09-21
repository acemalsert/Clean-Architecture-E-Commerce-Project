using EComm.Application.Bases;
using EComm.Application.Features.Product.Exceptions;

namespace EComm.Application.Features.Product.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Domain.Entities.Product> products, string requestTitle)
        {
            if (products.Any(x => x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
