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
    [Table("User")]
    public class User : BaseEntity, IEntity
    {
        [Required(ErrorMessage = "User Name can't be empty."),StringLength(13,MinimumLength =3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "User Surname can't be empty."), StringLength(13, MinimumLength = 3)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "User Email can't be empty."), StringLength(21, MinimumLength = 5),EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "User Password can't be empty."), StringLength(21, MinimumLength = 5)]
        public string Password { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Duty> Duties { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Quote> Quotes { get; set; }

        [NotMapped]
        public string Fullname => $"{Name} {Surname}";
    }
}
