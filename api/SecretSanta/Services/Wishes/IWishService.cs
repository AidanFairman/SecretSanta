using System.Collections.Generic;
using SecretSanta.Wishes.Data;

namespace SecretSanta.Wishes
{
    public interface IWishService
    {
        List<Wish> GetWishlist(long memberID);
        List<Wish> GetWishlistForMemberAndGame(long memberID, long gameID);
    }
}