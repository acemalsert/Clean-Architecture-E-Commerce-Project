using Bogus;
using EComm.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EComm.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id =1,
                Title  = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(0,10),
                Price = faker.Finance.Amount(10,1000),
                CreatedDate =  DateTime.Now,
                IsDeleted =false,
                BrandId = 1
            };

            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                BrandId = 3
            };

            builder.HasData(product1,product2);
        }
    }
}