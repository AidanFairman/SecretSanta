using SecretSanta.Profiles.Data;

namespace SecretSanta.Profiles
{
    public interface IProfileService
    {
        MemberProfile GetMemberProfile(long ID);
        MemberProfile GetMemberProfile(string Email);
        MemberProfile GetMemberProfileForGame(long memberId, long gameId);
        MemberProfile GetMemberProfileForGame(string email, long gameId);
    }
}