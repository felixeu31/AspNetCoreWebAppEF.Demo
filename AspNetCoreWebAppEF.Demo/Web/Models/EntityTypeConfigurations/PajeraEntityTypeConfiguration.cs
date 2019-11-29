using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.EntityTypeConfigurations
{
    public class PajeraEntityTypeConfiguration : IEntityTypeConfiguration<Pajera>
    {
        public void Configure(EntityTypeBuilder<Pajera> config)
        {
            config.HasKey(x => x.Id);

            config.HasMany(x => x.SubPajeras).WithOne(x => x.Pajera).HasForeignKey(x => x.PajeraId);
            config.HasMany(x => x.Inspecciones).WithOne(x => x.Pajera).HasForeignKey(x => x.PajeraId);
            config.HasMany(x => x.Adjuntos).WithOne(x => x.Pajera).HasForeignKey(x => x.PajeraId);
        }
    }
}
