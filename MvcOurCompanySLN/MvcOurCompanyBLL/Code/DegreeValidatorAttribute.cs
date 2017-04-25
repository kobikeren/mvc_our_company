using System.ComponentModel.DataAnnotations;

namespace MvcOurCompanyBLL.Code
{
    class DegreeValidatorAttribute : ValidationAttribute
    {
        public DegreeValidatorAttribute()
        {
            ErrorMessage = "Please enter one, two or three";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            string valueStr = value.ToString();

            //if the value is one, two or three return true
            if (valueStr == "one" || valueStr == "two" || valueStr == "three")
                return true;

            return false;            
        }
    }
}
