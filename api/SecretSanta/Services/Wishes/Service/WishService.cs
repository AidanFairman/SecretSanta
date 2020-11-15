using SecretSanta.Wishes.Data;

using System.Collections.Generic;

namespace SecretSanta.Wishes
{
    public class WishService : IWishService
    {
        public List<Wish> GetWishlist(long memberID)
        {
            throw new System.NotImplementedException();
        }

        public List<Wish> GetWishlistForMemberAndGame(long memberID, long gameID)
        {
            throw new System.NotImplementedException();
        }
    }
}