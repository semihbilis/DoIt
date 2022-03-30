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
    [Table("Duty")]
    public class Duty : BaseEntity, IEntity
    {
        [Required(ErrorMessage = "Duty Name can't be empty.")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Duty Priority can't be empty.")]
        public int Priority { get; set; }

        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        public int? AssigneeId { get; set; }
        [ForeignKey("AssigneeId")]
        public virtual User Assignee { get; set; }
        [InverseProperty("Duties")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
