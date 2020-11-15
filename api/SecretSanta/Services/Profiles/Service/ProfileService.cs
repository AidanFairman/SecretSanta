using System;
using System.Collections.Generic;
using SecretSanta.Services.Members;
using SecretSanta.Services.Wishes;

namespace SecretSanta.Services.Profiles
{
    public class ProfileService : IProfileService
    {
        private readonly IMemberService memberService;
        private readonly IWishService wishService;
        public ProfileService(IMemberService _memberService, IWishService _wishService)
        {
            memberService = _memberService;
            wishService = _wishService;
        }

        public MemberProfile GetMemberProfile(long memberId)
        {
            Member member = memberService.GetMember(memberId);
            List<Wish> wishlist = wishService.GetWishlist(memberId);
            return new MemberProfile();
        }

        public MemberProfile GetMemberProfile(string Email)
        {
            return new MemberProfile();
        }

        public MemberProfile GetMemberProfileForGame(long memberId, long gameId)
        {
            return null;
        }

        public MemberProfile GetMemberProfileForGame(string email, long gameId)
        {
            return null;
        }
    }
}