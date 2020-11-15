using SecretSanta.Services.Profiles;
using SecretSanta.Profiles.Dto;

namespace SecretSanta.Mappers{
    public class MemberProfileToMemberProfileResponse : IMapper<MemberProfile, MemberProfileResponse>
    {
        public MemberProfileResponse map(MemberProfile source)
        {
            return new MemberProfileResponse();
        }
    }
}