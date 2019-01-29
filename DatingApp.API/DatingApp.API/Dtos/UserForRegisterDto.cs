using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(18,MinimumLength =6,ErrorMessage ="You must specify password between 6 and 16 charecters")]
        public string Password { get; set; }
    }
}
