using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidationCredentials(UserVO user);
        TokenVO ValidationCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
