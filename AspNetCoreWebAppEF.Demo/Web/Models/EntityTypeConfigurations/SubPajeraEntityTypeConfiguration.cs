using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.EntityTypeConfigurations
{
    public class SubPajeraEntityTypeConfiguration : IEntityTypeConfiguration<SubPajera>
    {
        public void Configure(EntityTypeBuilder<SubPajera> config)
        {
            config.HasKey(x => x.Id);

            config.HasMany(x => x.Adjuntos).WithOne(x => x.SubPajera).HasForeignKey(x => x.SubPajeraId);
        }
    }
}
