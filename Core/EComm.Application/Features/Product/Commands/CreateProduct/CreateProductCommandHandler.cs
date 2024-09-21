using EComm.Application.Bases;
using EComm.Application.Features.Product.Rules;
using EComm.Application.Interfaces.AutoMapper;
using EComm.Application.Interfaces.UnitOfWorks;
using EComm.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EComm.Application.Features.Product.Commands.CreateProduct
{
    public class CreateProductCommandHandler : BaseHandler, IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(ProductRules productRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Domain.Entities.Product> products = await unitOfWork.GetReadRepository<Domain.Entities.Product>().GetAllAsync();

            await productRules.ProductTitleMustNotBeSame(products, request.Title);

            Domain.Entities.Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);

            await unitOfWork.GetWriteRepository<Domain.Entities.Product>().AddAsync(product);
            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategoryId = categoryId
                    });

                await unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}
