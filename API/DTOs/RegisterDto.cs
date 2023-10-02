using System.ComponentModel.DataAnnotations;

namespace API.DTOs;
public class RegisterDto
{
    // wystawianie do API danych
    [Required]
    public string Username {get; set;}
    [Required]
    public string Password {get; set;}
}
