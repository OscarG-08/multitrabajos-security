using multitrabajos_security.DTOs;
using multitrabajos_security.Models;
using multitrabajos_security.Repositories;

namespace multitrabajos_security.Services
{
    public class ServiceLogin : IServiceLogin
    {
        //Inyeccion de dependencia
        private readonly Contexto _contexto;
        private readonly IConfiguration _configuration;
        public ServiceLogin(Contexto contexto, IConfiguration configuration)
        {
            _contexto = contexto;
            _configuration = configuration;
        }
        public async Task<User> Login(LoginRequest loginRequest)
        {
            return await authUser(loginRequest.Username, loginRequest.Password);
        }
        private async Task<User> authUser(string username, string password)
        {
            var userData = _contexto.Usuario.Where(x => x.Estado.Equals("A")
                                                    && x.Email.Equals(username) 
                                                    && x.Password.Equals(password))
                                                    .FirstOrDefault();
            return userData;
        }
    }
}
