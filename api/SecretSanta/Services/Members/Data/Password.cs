

namespace SecretSanta.Services.Members
{
    public class Password
    {
        private string HashCode { get; set; }
        private string Salt { get; set; }
        public static Password newPasswordFor(string password)
        {
            return null;
        }

        public bool compare(string password)
        {
            return false;
        }

        public bool compare(Password password)
        {
            return this.Salt.Equals(password.Salt) && this.HashCode.Equals(password.HashCode);
        }

        private static string generateSalt()
        {
            return null;
        }

        private static string generateHash(string password, string salt)
        {
            return null;
        }
    }
}