using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
namespace Working_with_models.Models
{
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Id *")]
        public int eid { get; set; }

        [DisplayName("Name *")]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Name is mandatory")]
        public string name { get; set; }

        [DisplayName("E-mail *")]
       
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-mail is mandatory")]
        public string email { get; set; }

        [DisplayName("Address *")]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Address is mandatory")]
        public string address { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string landmark { get; set; }

        [DisplayName("Pincode *")]
        [MaxLength(6)]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Pincode is mandatory")]
        public int pincode { get; set; }
        
    }
}
