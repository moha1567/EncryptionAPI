using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/encryption")]
public class EncryptionController : ControllerBase
{
    private const int Shift = 3;

    [HttpGet("encrypt")]
    public IActionResult Encrypt(string text)
    {
        string encrypted = new string(text.Select(c => (char)(c + Shift)).ToArray());
        return Ok(encrypted);
    }

    [HttpGet("decrypt")]
    public IActionResult Decrypt(string text)
    {
        string decrypted = new string(text.Select(c => (char)(c - Shift)).ToArray());
        return Ok(decrypted);
    }
}
