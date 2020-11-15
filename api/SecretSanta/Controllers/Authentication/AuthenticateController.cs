using SecretSanta.Controllers;
using SecretSanta.Authentication;  
using Microsoft.AspNetCore.Http;  
using Microsoft.AspNetCore.Identity;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.Extensions.Configuration;  
using Microsoft.IdentityModel.Tokens;  
using System;  
using System.Collections.Generic;  
using System.IdentityModel.Tokens.Jwt;  
using System.Security.Claims;  
using System.Text;  
using System.Threading.Tasks;

namespace SecretSanta.Authentication
{
    public class AuthenticateController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public AuthenticateController(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager, IConfiguration _configuration){
            userManager = _userManager;
            roleManager = _roleManager;
            configuration = _configuration;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel){
            ApplicationUser user = await userManager.FindByEmailAsync(loginModel.Email);
            if(user != null && await userManager.CheckPasswordAsync(user, loginModel.Password)){
                IList<string> userRoles = await userManager.GetRolesAsync(user);
                List<Claim> authClaims = new List<Claim>{
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                foreach(string role in userRoles){
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                SymmetricSecurityKey authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT.Secret"]));

                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires:DateTime.UtcNow.AddHours(6),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

                return Ok(new{
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model){
            ApplicationUser userExists = await userManager.FindByEmailAsync(model.Email);
            if(userExists != null){
                return StatusCode(StatusCodes.Status500InternalServerError, new Response{Status="Error", Message="User already exists. Please log in."});
            }

            ApplicationUser user = new ApplicationUser(){
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            IdentityResult result = await userManager.CreateAsync(user, model.Password);
            if(!result.Succeeded){
                return StatusCode(StatusCodes.Status500InternalServerError, new Response{Status="Error", Message="USer creation failed! Please check details and try again."});
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }
    }
}