using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IUserRepository
    {
        User ValidateCredencials(UserVO user);
        User ValidateCredencials(string username);
        User RefreshUserInfo(User user);
        bool RevokeToken(string userName);
    }
}
