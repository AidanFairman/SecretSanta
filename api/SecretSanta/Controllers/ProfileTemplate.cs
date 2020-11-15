using System;

namespace SecretSanta.Controllers{
    [ApiController]
	[Route("/profile")]
	public interface ProfileTemplate{
        [HttpGet]
        public T get();
    }
}