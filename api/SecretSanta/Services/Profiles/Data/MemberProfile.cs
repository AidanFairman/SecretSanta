using System;
using System.Collections.Generic;
using SecretSanta.Wishes.Data;

namespace SecretSanta.Profiles.Data
{
    public class MemberProfile
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Wish> Wishlist { get; set; }
    }
}