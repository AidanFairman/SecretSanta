

namespace SecretSanta.Services.Members
{
    public interface IMemberService
    {
        Member GetMember(long ID);
        Member GetMember(string Email);
    }
}