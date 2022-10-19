using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCAD7_Assignment12_1.Models
{
    //step1 add model
    public enum Dept
    {
        Gi=1,
        Books,
        Mats,
        supplies

    }
    public class Product
    {
        [Display(Name ="Product Id")]
        [Required(ErrorMessage ="Please fill in Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // we use this so the Server wont create its own ID key. other wise the server table key and this key will have a conflict. 
        public int Id { get; set; }

        public int DeptId { get; set; } // foreign key. this is what connects Products.cs and Department.cs

        [Display(Name="Product Name")]
        [Required(ErrorMessage ="Please fill in name")]
        public string? Name { get; set; }

        [Display(Name="Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(255, ErrorMessage ="Description is too long")]
        
        public string? Description { get; set; }

        [DataType(DataType.Currency)]
        public float price { get; set; }
        public Dept Department { get; set; }
        public string? imageName { get; set; }
    }
}    
     