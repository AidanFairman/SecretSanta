using SecretSanta.Members.Data;

namespace SecretSanta.Members
{
    public interface IMemberService
    {
        Member GetMember(long ID);
        Member GetMember(string Email);
    }
}