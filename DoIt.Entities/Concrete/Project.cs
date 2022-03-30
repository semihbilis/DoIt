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
    [Table("Project")]
    public class Project : BaseEntity, IEntity
    {
        [Required(ErrorMessage = "Project Name can't be empty.")]
        public string Name { get; set; }

        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public virtual Organization Organization { get; set; }
        [InverseProperty("Project")]
        public virtual ICollection<Status> Statuses { get; set; }
    }
}
