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
    internal class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(E => E.Description)
                .HasColumnType("varchar")
                .HasMaxLength(200);
            
            builder.HasOne(E => E.Organizer)
                .WithMany(O => O.Events)
                .HasForeignKey(E => E.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
