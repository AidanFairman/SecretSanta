using System;
using System.Collections.Generic;
using SecretSanta.Services.Wishes;

namespace SecretSanta.Services.Profiles
{
    public class MemberProfile
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Wish> Wishlist { get; set; }
    }
}