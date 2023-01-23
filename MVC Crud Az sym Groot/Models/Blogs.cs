using System.ComponentModel.DataAnnotations;

namespace MVC_Crud_Az_sym_Groot.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }

        public string? BlogName { get; set; }
        public string? Description { get; set; }

       public DateTime? CreatedDate { get; set; }
    }
}
