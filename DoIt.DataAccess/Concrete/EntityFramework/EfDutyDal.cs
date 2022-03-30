using DoIt.Core.DataAccess.EntityFramework;
using DoIt.DataAccess.Abstract;
using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.DataAccess.Concrete.EntityFramework
{
    public class EfDutyDal : EfEntityRepositoryBase<Duty, Context>, IDutyDal
    {
    }
}
