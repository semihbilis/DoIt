using DoIt.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.Entities.Concrete
{
    [Table("Organization")]
    public class Organization : BaseEntity, IEntity
    {
        public Organization()
        {
            this.Projects = new HashSet<Project>();
        }
        [Required(ErrorMessage = "Organization Name can't be empty.")]
        public string Name { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [InverseProperty("Organization")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}
