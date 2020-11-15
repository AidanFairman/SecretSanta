using Microsoft.Extensions.DependencyInjection;
using System;

namespace SecretSanta.Mappers
{
    public sealed class MappingService
    {
        private readonly IServiceProvider serviceProvider;
        public MappingService(IServiceProvider provider)
        {
            serviceProvider = provider;
        }
        public T map<F, T>(F from)
        {
            return serviceProvider.GetService<IMapper<F, T>>().map(from);
        }
    }
}