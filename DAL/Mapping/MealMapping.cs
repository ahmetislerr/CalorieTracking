using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class MealMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meals");

            builder.HasKey(m => m.MealID);

            builder.Property(m => m.MealName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
            builder.Property(m => m.MealDate)
                .IsRequired()
                .HasColumnType("datetime2");

            builder.Property(m => m.TotalMealCalories)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
            builder.HasMany(f => f.Foods)
                .WithMany(m => m.Meals);
        }
    }
}
