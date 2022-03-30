using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.DataAccess.Concrete.EntityFramework.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable(@"Statuses", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.CreateDate).HasColumnName("CreateDate");
            Property(x => x.UpdateDate).HasColumnName("UpdateDate");
            Property(x => x.EndDate).HasColumnName("EndDate");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Icon).HasColumnName("Icon");
        }
    }
}
