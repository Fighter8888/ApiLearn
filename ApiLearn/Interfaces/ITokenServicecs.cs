using ApiLearn.Models;

namespace ApiLearn.Interfaces
{
    public interface ITokenServicecs
    {
        string CreateToken (AppUser user);
    }
}
