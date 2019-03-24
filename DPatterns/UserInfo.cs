namespace DPatterns
{
    public interface IUserInfo
    {
        string Name { get; set; }

        string Password { get; set; }
    }

    public class UserInfo : IUserInfo
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}