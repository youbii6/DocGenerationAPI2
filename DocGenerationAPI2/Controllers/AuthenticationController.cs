using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DocGenerationAPI2.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IConfiguration _configuration;

        public class AuthenticationRequestBody
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
        }

        private class ApiUser
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

          
            public ApiUser(int userId, string userName,
                string firstName, string lastName)
            {
                UserId = userId;
                UserName = userName;
                FirstName = firstName;
                LastName = lastName;
            }
        }
        public AuthenticationController(IConfiguration configuration) 
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(
            AuthenticationRequestBody authenticationRequestBody)
        {
            // 1- validate the username/password
            var user = ValidateUserCredentials(
                authenticationRequestBody.Username, authenticationRequestBody.Password);
            if (user == null) 
            {
                return Unauthorized();
            }

            // 2- create the token for a valide user 

            var securtykey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));
            var signingCredentials =new SigningCredentials(securtykey,SecurityAlgorithms.HmacSha256);

            // claims , fazet that we know about the user ow mawjoudin fel token
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub",user.UserId.ToString()));
            claimsForToken.Add(new Claim("given_name", user.FirstName));
            claimsForToken.Add(new Claim("family_name", user.LastName));


            // finally create the token 
            var jwtSecurityToken = new JwtSecurityToken(
              _configuration["Authentication:Issuer"],
              _configuration["Authentication:Audiance"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              signingCredentials);
              
            var TokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return Ok(TokenToReturn);

        }

        private ApiUser ValidateUserCredentials(string? username, string? password)
        {
            // assuming that the user exist in the DB and return it
            return new ApiUser(1, "user 1", "ayoub", "ksouri");
        }
    }
}
