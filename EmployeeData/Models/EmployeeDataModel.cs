using System.ComponentModel.DataAnnotations;

namespace EmployeeData.Models
{
    public class EmployeeModel
    {

        [Key] // Primary Key
        public int EmployeeCode { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public bool Gender { get; set; } // true for Male, false for Female

        [Required]
        public string Department { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public float BasicSalary { get; set; }
    }
}
