using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.EntityTypeConfigurations
{
    public class AdjuntoEntityTypeConfiguration : IEntityTypeConfiguration<Adjunto>
    {
        public void Configure(EntityTypeBuilder<Adjunto> config)
        {
            config.HasKey(x => x.Id);
        }
    }
}
