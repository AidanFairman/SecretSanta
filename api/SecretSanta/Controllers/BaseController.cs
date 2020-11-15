using Microsoft.AspNetCore.Mvc;

namespace SecretSanta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}