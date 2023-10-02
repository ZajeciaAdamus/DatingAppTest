using System.ComponentModel.DataAnnotations;

namespace API.Entities;
public class AppUser
{
    public int Id { get; set;}
    public string UserName { get; set;} // wymagane bo Required

    public byte[] PasswordHash {get; set;}
    public byte[] PasswordSalt {get; set;}
}
