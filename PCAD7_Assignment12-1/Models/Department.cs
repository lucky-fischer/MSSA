using System.ComponentModel.DataAnnotations;

namespace PCAD7_Assignment12_1.Models
{
    //master table
    public class Department
    {
        [Key] // this is the primary key in the table
        public int DeptId {  get; set; }
        public string? DeptName { get; set; }
        // 1 to maany relation. this is what is going to make the relationship between Department and Products
        public virtual ICollection<Product>? Products { get; set; }
    }
}
