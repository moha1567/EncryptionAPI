using Microsoft.AspNetCore.Mvc;

namespace EncryptionAPI.Controllers
{
    [ApiController]
    [Route("api/encryption")]
    public class EncryptionController : ControllerBase
    {
        private const int Shift = 3; // Förskjutning i chiffer (t.ex. Caesar-chiffer)

        // Endpoint för att kryptera text
        [HttpGet("encrypt")]
        public IActionResult Encrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
                return BadRequest("Ingen text angiven!");

            string encrypted = new string(text.Select(c => (char)(c + Shift)).ToArray());
            return Ok(encrypted); 
        }

        // Endpoint för att avkryptera text
        [HttpGet("decrypt")]
        public IActionResult Decrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
                return BadRequest("Ingen text angiven!");

            string decrypted = new string(text.Select(c => (char)(c - Shift)).ToArray());
            return Ok(decrypted);
        }
    }
}
