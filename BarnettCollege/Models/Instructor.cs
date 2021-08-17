using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BarnettCollege.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required, Display(Name = "Last Name"), StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required, Display(Name = "First Name"), Column("FirstName"),
            StringLength(50, MinimumLength = 2)]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date), Display(Name = "Hire Date"), 
            DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return  $"{LastName}, {FirstMidName}";
            }
        }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }

    }
}
