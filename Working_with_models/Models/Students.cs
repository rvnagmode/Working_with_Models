using System;
using System.Data.Entity; 
namespace Working_with_models.Models
 
{
    public class Students
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public int percentage { get; set; }

    }
    public class ProductContext : DbContext
    {
        
        public DbSet<Students> student { get; set; }
    }

}
