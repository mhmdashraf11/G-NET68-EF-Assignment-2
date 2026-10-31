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
    internal class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badge");
            builder.ToTable(t => t.HasCheckConstraint("CheckBadgeTier", "[Tier] In ('Standard','VIP')"));
            builder.HasKey(B => B.Number);
            builder.Property(b => b.Tier)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();


            builder.HasOne(B => B.Attendee)
                .WithOne(A => A.Badge)
                .HasForeignKey<Badge>(B => B.AttendeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
