using MvcOurCompanyBLL.Code;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcOurCompanyBLL
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter degree")]
        [DegreeValidator]
        public string Degree { get; set; }
    }
}
