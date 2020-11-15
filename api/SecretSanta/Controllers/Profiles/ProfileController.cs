using System;
using System.Web;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecretSanta.Services.Profiles;
using SecretSanta.Mappers;

namespace SecretSanta.Profiles.Dto
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;
        private readonly MappingService mapper;

        public ProfileController(IProfileService profileService, MappingService mappingService)
        {
            this.profileService = profileService;
            this.mapper = mappingService;
        }

        [HttpGet]
        public MemberProfileResponse get()
        {
            string email = User.Identity.Name;
            MemberProfile profile = profileService.GetMemberProfile(email);
            return mapper.map<MemberProfile, MemberProfileResponse>(profile);
        }

        [HttpGet("{id:int}")]
        public MemberProfileResponse get(int id)
        {
            return null;
        }
    }
}