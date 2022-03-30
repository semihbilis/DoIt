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
    [Table("Status")]
    public class Status : BaseEntity, IEntity
    {
        [Required(ErrorMessage = "Status Name can't be empty.")]
        public string Name { get; set; }
        public string Icon { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<Duty> Duties { get; set; }
    }
}
