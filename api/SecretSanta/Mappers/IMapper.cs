

namespace SecretSanta.Mappers
{
    public interface IMapper<F, T>
    {
        T map(F source);
    }
}