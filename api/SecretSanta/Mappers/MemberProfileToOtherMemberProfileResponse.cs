using SecretSanta.Profiles.Dto;
using SecretSanta.Services.Profiles;

namespace SecretSanta.Mappers{
    public class MemberProfileToOtherMemberProfileResponse : IMapper<MemberProfile, OtherMemberProfileResponse>
    {
        public OtherMemberProfileResponse map(MemberProfile source)
        {
            return new OtherMemberProfileResponse();
        }
    }
}