using System.ComponentModel.DataAnnotations;

namespace PCAD7_Project_MVC.Models
{
    public class AllLetters:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {

            if (value != null)
            {
                return ((string)value).All(Char.IsLetter);
            }
            return false;
        }
    }
}
