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
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserID);

            builder.HasMany(u => u.Meals)
                .WithOne(m => m.User)
                .HasForeignKey(m=>m.UserId);

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);

            builder.Property(u=>u.UserSurname)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(u=>u.UserMail)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.Property(u => u.UserPassword)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(8);

            builder.Property(u=>u.UserBirthDate)
                .IsRequired()
                .HasColumnType("datetime2");



            builder.Property(u => u.UserWeight)
                .IsRequired()
                .HasColumnType("decimal(10,2)");


            builder.Property(u => u.UserHeight)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(u => u.UserGender)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(15);

            builder.Property(u => u.PhotoPath)
                .IsRequired();
        }
    }
}
