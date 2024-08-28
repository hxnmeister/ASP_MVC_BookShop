using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_BookShop.Models
{
    public class BookSearchModel
    {
        [Required(ErrorMessage = "Searching field cannot be empty!")]
        [MinLength(1, ErrorMessage = "Enter at least 1 character!")]
        [DisplayName("Searching Parameter: ")]
        public string SearchingParam { get; set; }

        [Required(ErrorMessage = "Criteria is required!")]
        public string Criteria { get; set; }
    }
}
