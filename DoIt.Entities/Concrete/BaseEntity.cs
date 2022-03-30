using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.Entities.Concrete
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
