using G_NET68_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Configurations
{
    internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizerProfile");
            builder.HasKey(OP => OP.Id);
            builder.Property(OP => OP.Bio)
                .HasColumnType("varchar(150)");

            builder.HasOne(OP => OP.Organizer)
                .WithOne(O => O.Profile)
                .HasForeignKey<OrganizerProfile>(Op => Op.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
