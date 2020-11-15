using SecretSanta.Profiles.Data;
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