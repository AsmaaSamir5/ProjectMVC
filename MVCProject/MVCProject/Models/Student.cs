using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Student
    {
        public int Id { get; set; }


        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Name Is Required")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}",
                           ErrorMessage = "name must be char only and more than 2 char")]
        public string Name { get; set; }

        [Range(minimum: 20, maximum: 80)]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [ForeignKey("Track")]
        public int TR { get; set; }
        public Track  Track { get; set; }

        [ForeignKey("Instructor")]
        public int Inst { get; set; }
        public Instructor Instructor { get; set; }

    }
}
