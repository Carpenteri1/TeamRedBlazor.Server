using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamRedBlazor.Client.Server.Data.Models
{
    [Authorize]
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
