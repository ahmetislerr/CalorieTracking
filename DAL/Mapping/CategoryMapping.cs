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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.CategoryID);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasMany(c => c.Foods)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryId);

            builder.HasData(
                new Category { CategoryID = 1, CategoryName = "Et ve Tavuk Yemekleri" },
                new Category { CategoryID = 2, CategoryName = "Sebze Yemekleri" },
                new Category { CategoryID = 3, CategoryName = "Zeytin Yağlı Yemekler" },
                new Category { CategoryID = 4, CategoryName = "Balık ve Deniz Ürünleri" },
                new Category { CategoryID = 5, CategoryName = "Çorbalar" },
                new Category { CategoryID = 6, CategoryName = "Makarna ve Pilav" },
                new Category { CategoryID = 7, CategoryName = "Salata - Turşu" },
                new Category { CategoryID = 8, CategoryName = "Ekmekler" },
                new Category { CategoryID = 9, CategoryName = "Sıcak-Soğuk İçecekler" },
                new Category { CategoryID = 10, CategoryName = "Tatlılar" }
                
            );
        }
    }
}
