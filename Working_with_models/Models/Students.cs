using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Working_with_models.Models
 
{
    public class Students
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("Roll no *")]
        public int rollno { get; set; }

       
        [DisplayName("Student Name *")]
        [MinLength(2)]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage ="Percentage is required")]
        [DisplayName("Percentage *")]
        public int percentage { get; set; }

    }
    public class ProductContext : DbContext
    {
        public DbSet<Students> student { get; set; }
    }

}
