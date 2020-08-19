using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GAMH.Models
{
    public class ClotheOrderModel
    {
        public string Gender { get; set; }

        [Required, MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        public string Size { get; set; }

        [Required, MinLength(6)]
        public string Phone { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required,MinLength(4)]
        public string ShippingAddress { get; set; }

        public ClotheType ClotheType { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public enum ClotheType
    {
        Pents = 0,
        Shoes = 1,
        Shirt = 2
    }
}
