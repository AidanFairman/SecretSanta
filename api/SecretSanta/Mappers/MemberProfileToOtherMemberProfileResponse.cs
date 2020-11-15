using SecretSanta.Profiles.Dto;
using SecretSanta.Profiles.Data;

namespace SecretSanta.Mappers{
    public class MemberProfileToOtherMemberProfileResponse : IMapper<MemberProfile, OtherMemberProfileResponse>
    {
        public OtherMemberProfileResponse map(MemberProfile source)
        {
            return new OtherMemberProfileResponse();
        }
    }
}