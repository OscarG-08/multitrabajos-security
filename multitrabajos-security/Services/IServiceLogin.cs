using multitrabajos_security.DTOs;

namespace multitrabajos_security.Services
{
    public interface IServiceLogin
    {
        Task<Models.User> Login(LoginRequest loginRequest);

    }
}
