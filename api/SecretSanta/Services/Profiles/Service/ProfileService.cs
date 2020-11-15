using System;
using System.Collections.Generic;
using SecretSanta.Members;
using SecretSanta.Members.Data;
using SecretSanta.Wishes;
using SecretSanta.Wishes.Data;
using SecretSanta.Profiles.Data;

namespace SecretSanta.Profiles
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