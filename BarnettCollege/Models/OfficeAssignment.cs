using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarnettCollege.Models
{
    public class OfficeAssigment
    {
        /*By default, EF treats the key as non-database-generated 
        because the column is for an identifying relationship.*/
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50), Display(Name = "Office Location")]
        public string Location { get; set; }
        public Instructor Instructor { get; set; }
    }
}
