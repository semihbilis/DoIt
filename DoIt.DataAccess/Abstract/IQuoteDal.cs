using DoIt.Core.DataAccess;
using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.DataAccess.Abstract
{
    public interface IQuoteDal : IEntityRepository<Quote>
    {
    }
}
