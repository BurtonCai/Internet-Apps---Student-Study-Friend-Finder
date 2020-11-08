using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_FINAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Students = new HashSet<Student>();
        }

        public int ID { get; set; }
        [Display(Name = "Group Name")]
        [Required(ErrorMessage = "Please enter a group name.")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a subject.")]
        [StringLength(120)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the details.")]
        [StringLength(40)]
        public string Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
