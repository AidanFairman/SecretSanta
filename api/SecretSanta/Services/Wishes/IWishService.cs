using System.Collections.Generic;

namespace SecretSanta.Services.Wishes
{
    public interface IWishService
    {
        List<Wish> GetWishlist(long memberID);
        List<Wish> GetWishlistForMemberAndGame(long memberID, long gameID);
    }
}