using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.EntityTypeConfigurations
{
    public class InspeccionEntityTypeConfiguration : IEntityTypeConfiguration<Inspeccion>
    {
        public void Configure(EntityTypeBuilder<Inspeccion> config)
        {
            config.HasKey(x => x.Id);

            config.HasMany(x => x.Adjuntos).WithOne(x => x.Inspeccion).HasForeignKey(x => x.InspeccionId);
        }
    }
}
