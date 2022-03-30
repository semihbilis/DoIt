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
    [Table("Tag")]
    public class Tag : BaseEntity, IEntity
    {

        [Required(ErrorMessage = "Tag Text can't be empty.")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Tag Color can't be empty.")]
        public string Color { get; set; }

        [InverseProperty("Tags")]
        public virtual ICollection<Duty> Duties { get; set; }
    }
}
