using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcOurCompanyBLL
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter employee name")]
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Please enter product")]
        public string Product { get; set; }

        [Required(ErrorMessage = "Please enter number of units")]
        [DisplayName("Number Of Units")]
        public int NumberOfUnits { get; set; }

        [Required(ErrorMessage = "Please enter company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Please enter contact name")]
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Please enter order status")]
        [DisplayName("Order Status")]
        public string OrderStatus { get; set; }
    }
}
