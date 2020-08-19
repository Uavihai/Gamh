using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GAMH.Models
{
    public class ContactViewModel
    {
        [Required,MinLength(2)]
        public string FirstName { get; set; }

        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required,MinLength(6)]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime ContactTime { get; set; }
    }
}
