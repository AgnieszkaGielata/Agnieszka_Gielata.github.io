using System;
using System.ComponentModel.DataAnnotations;

namespace W5.Models
{
    public enum Gender { Female, Male }
    
    public class StudentViewModel
    {
        private Random random = new Random();
        public StudentViewModel()
        {
            this.Id = random.Next(0,1000);
            this.Index = 0;
            this.Name = "name";
            this.Gender = Gender.Male;
            this.Active = false;
            this.DepartmentId = 1;
            this.BirthDate = new DateTime(2000, 3, 22);
        }
       
        public StudentViewModel(int v2, string v3, Gender male, bool v4, int v5, System.DateTime dateTime)
        {
            this.Id = random.Next(0, 1000);
            this.Index = v2;
            this.Name = v3;
            this.Gender = male;
            this.Active = v4;
            this.DepartmentId = v5;
            this.BirthDate = dateTime;
        }

        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{1,6}$")]
        public int Index { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "To short name")]
        [Display(Name = "Last Name")]
        [MaxLength(20, ErrorMessage = " To long name, do not exceed {1}")]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool Active { get; set; }
        public int DepartmentId { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime BirthDate { get; set; }

    }
}
