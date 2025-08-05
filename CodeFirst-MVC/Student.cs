using System.ComponentModel.DataAnnotations;

namespace CodeFirst_Practice.Models
{
    public class Student
    {
        [Key]
        public int StuId { get; set; }

        public string StudentName { get; set; }

        public decimal Telugu { get; set; }

        public decimal Hindi { get; set; }

        public decimal English { get; set; }

        public decimal Maths { get; set; }

        public decimal Science { get; set; }

        public decimal Social { get; set; }

        


    }
}