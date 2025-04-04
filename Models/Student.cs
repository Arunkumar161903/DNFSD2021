using System.ComponentModel.DataAnnotations;

namespace Apihome.Models

{
    public class Student
    {
        
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public decimal Salary  { get; set; }    
    }
}
