using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarnettCollege.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name"), StringLength(50, MinimumLength = 2), Required]
        public string LastName { get; set; }
        [Display(Name = "First Middle Name"), StringLength(50, MinimumLength = 2), 
            RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public string FirstMidName { get; set; }
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstMidName}";
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
