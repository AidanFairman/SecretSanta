using System;
using System.Web;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecretSanta.Controllers;
using SecretSanta.Profiles;
using SecretSanta.Profiles.Data;
using SecretSanta.Profiles.Dto;
using SecretSanta.Mappers;

namespace SecretSanta.Profiles
{
    public class ProfileController : BaseController
    {
        private readonly IProfileService profileService;
        private readonly MappingService mapper;

        public ProfileController(IProfileService profileService, MappingService mappingService)
        {
            this.profileService = profileService;
            this.mapper = mappingService;
        }

        [HttpGet]
        public MemberProfileResponse GetMyProfile()
        {
            string email = User.Identity.Name;
            MemberProfile profile = profileService.GetMemberProfile(email);
            return mapper.map<MemberProfile, MemberProfileResponse>(profile);
        }

        [HttpGet("id/{memberid:int}/game/{gameId}")]
        public MemberProfileResponse GetMemberProfileForGame(int memberId, int gameId)
        {

        }

        [HttpPut]
        public MemberProfileResponse UpdateMemberProfile([FromBody] MemberUpdateRequest updateRequest)
        {

        }
    }
}