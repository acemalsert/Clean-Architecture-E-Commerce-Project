using EComm.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace EComm.Persistance.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("tr");
            Detail detail1 = new()
            {
                Id = 1,
                CategoryId = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Detail detail2 = new()
            {
                Id = 2,
                CategoryId = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            Detail detail3 = new()
            {
                Id = 3,
                CategoryId = 4,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
