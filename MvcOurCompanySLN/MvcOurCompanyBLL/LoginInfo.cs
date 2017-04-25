using System.ComponentModel.DataAnnotations;

namespace MvcOurCompanyBLL
{
    public class LoginInfo
    {
        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}
