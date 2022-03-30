using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt.DataAccess.Concrete.EntityFramework.Mappings
{
    class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            ToTable(@"Tags", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.CreateDate).HasColumnName("CreateDate");
            Property(x => x.UpdateDate).HasColumnName("UpdateDate");
            Property(x => x.EndDate).HasColumnName("EndDate");
            Property(x => x.Text).HasColumnName("Text");
            Property(x => x.Color).HasColumnName("Color");
        }
    }
}
