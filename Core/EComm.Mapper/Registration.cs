using Microsoft.Extensions.DependencyInjection;
using EComm.Application.Interfaces.AutoMapper;


namespace EComm.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper,AutoMapper.Mapper>();
        }
    }
}
