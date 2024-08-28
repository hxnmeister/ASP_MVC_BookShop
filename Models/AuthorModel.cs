using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_BookShop.Models
{
    public class AuthorModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}
