using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_FINAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a First Name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a DOB.")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "Please enter a Degree.")]
        public string Degree { get; set; }

        public virtual Group Group { get; set; }
        public string UserId { get; internal set; }
    }
}