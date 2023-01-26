using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace DAL.Mapping
{
    public class FoodMapping : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");

            builder.HasKey(f => f.FoodID);

            builder.Property(f => f.FoodName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("nvarchar");

            builder.Property(f => f.Calorie)
                .IsRequired()
                .HasColumnType("decimal(6,2)");

            
            builder.Property(f => f.Porsion)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(15);

            builder.HasData(

                new Food { Calorie = 242, CategoryId = 1, FoodID = 1, FoodName = "Bonfile", Porsion = Porsion.Piece },
                new Food { Calorie = 219, CategoryId = 1, FoodID = 2, FoodName = "Kavurma", Porsion = Porsion.Piece },
                new Food { Calorie = 290, CategoryId = 1, FoodID = 3, FoodName = "Köfte", Porsion = Porsion.Piece },
                new Food { Calorie = 225, CategoryId = 1, FoodID = 4, FoodName = "Tavuk Izgara", Porsion = Porsion.Piece },
                new Food { Calorie = 135, CategoryId = 1, FoodID = 5, FoodName = "Hindi Göğüs(100 Gr)", Porsion = Porsion.Gram },
                new Food { Calorie = 242, CategoryId = 2, FoodID = 6, FoodName = "Bezelye", Porsion = Porsion.Piece },
                new Food { Calorie = 243, CategoryId = 2, FoodID = 7, FoodName = "Brokoli", Porsion = Porsion.Piece },
                new Food { Calorie = 244, CategoryId = 2, FoodID = 8, FoodName = "Domates", Porsion = Porsion.Piece },
                new Food { Calorie = 245, CategoryId = 2, FoodID = 9, FoodName = "Salatalık", Porsion = Porsion.Piece },
                new Food { Calorie = 246, CategoryId = 2, FoodID = 10, FoodName = "Enginar", Porsion = Porsion.Piece },
                new Food { Calorie = 247, CategoryId = 2, FoodID = 11, FoodName = "Mısır", Porsion = Porsion.Piece },
                new Food { Calorie = 150, CategoryId = 3, FoodID = 12, FoodName = "Taze Fasülye", Porsion = Porsion.Piece },
                new Food { Calorie = 175, CategoryId = 3, FoodID = 13, FoodName = "Yaprak Sarma", Porsion = Porsion.Piece },
                new Food { Calorie = 200, CategoryId = 3, FoodID = 14, FoodName = "Pırasa", Porsion = Porsion.Piece },
                new Food { Calorie = 300, CategoryId = 4, FoodID = 15, FoodName = "Hamsi Tava", Porsion = Porsion.Piece },
                new Food { Calorie = 400, CategoryId = 4, FoodID = 16, FoodName = "Levrak Izgara", Porsion = Porsion.Piece },
                new Food { Calorie = 550, CategoryId = 4, FoodID = 17, FoodName = "Kalamar Tava", Porsion = Porsion.Piece },
                new Food { Calorie = 150, CategoryId = 5, FoodID = 18, FoodName = "Mercimek", Porsion = Porsion.Piece },
                new Food { Calorie = 155, CategoryId = 5, FoodID = 19, FoodName = "Ezogelin", Porsion = Porsion.Piece },
                new Food { Calorie = 355, CategoryId = 5, FoodID = 20, FoodName = "Kelle - Paça", Porsion = Porsion.Piece },
                new Food { Calorie = 300, CategoryId = 5, FoodID = 21, FoodName = "İşkembe", Porsion = Porsion.Piece },
                new Food { Calorie = 125, CategoryId = 5, FoodID = 22, FoodName = "Tarhana", Porsion = Porsion.Piece },
                new Food { Calorie = 150, CategoryId = 6, FoodID = 23, FoodName = "Pirinç Pilavı", Porsion = Porsion.Piece },
                new Food { Calorie = 100, CategoryId = 6, FoodID = 24, FoodName = "Bulgur Pilavı", Porsion = Porsion.Piece },
                new Food { Calorie = 155, CategoryId = 6, FoodID = 25, FoodName = "Nohutlu Pirinç Pilavı", Porsion = Porsion.Piece },
                new Food { Calorie = 200, CategoryId = 6, FoodID = 26, FoodName = "Tavuklu Pirinç Pilavı", Porsion = Porsion.Piece },
                new Food { Calorie = 120, CategoryId = 6, FoodID = 27, FoodName = "Sebzeli Bulgur Pilavı", Porsion = Porsion.Piece },
                new Food { Calorie = 120, CategoryId = 6, FoodID = 28, FoodName = "Sade Makarna", Porsion = Porsion.Piece },
                new Food { Calorie = 120, CategoryId = 6, FoodID = 29, FoodName = "Fettucini Alfredo", Porsion = Porsion.Piece },
                new Food { Calorie = 250, CategoryId = 7, FoodID = 30, FoodName = "Sezar", Porsion = Porsion.Piece },
                new Food { Calorie = 120, CategoryId = 7, FoodID = 31, FoodName = "Çoban Salata", Porsion = Porsion.Piece },
                new Food { Calorie = 150, CategoryId = 7, FoodID = 32, FoodName = "Mevsim Salata", Porsion = Porsion.Piece },
                new Food { Calorie = 300, CategoryId = 7, FoodID = 33, FoodName = "Gavurdağ Salata", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId = 7, FoodID = 34, FoodName = "Rus Salatası", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId = 8, FoodID = 35, FoodName = "Beyaz Ekmeği", Porsion = Porsion.Slice },
                new Food { Calorie = 450, CategoryId = 8, FoodID = 36, FoodName = "Kepekli Ekmeği", Porsion = Porsion.Slice },
                new Food { Calorie = 450, CategoryId = 8, FoodID = 37, FoodName = "Çavdar Ekmeği", Porsion = Porsion.Slice },
                new Food { Calorie = 250, CategoryId = 9, FoodID = 38, FoodName = "Pepsi", Porsion = Porsion.Millilitre },
                new Food { Calorie = 250, CategoryId = 9, FoodID = 39, FoodName = "Sprite", Porsion = Porsion.Millilitre },
                new Food { Calorie = 250, CategoryId = 9, FoodID = 40, FoodName = "Fanta", Porsion = Porsion.Millilitre },
                new Food { Calorie = 50, CategoryId = 9, FoodID = 41, FoodName = "Su", Porsion = Porsion.Millilitre },
                new Food { Calorie = 55, CategoryId = 9, FoodID = 42, FoodName = "Çay", Porsion = Porsion.Millilitre },
                new Food { Calorie = 60, CategoryId = 9, FoodID = 43, FoodName = "Türk Kahvesi", Porsion = Porsion.Millilitre },
               
                new Food { Calorie = 650, CategoryId =10, FoodID = 44, FoodName = "Baklava", Porsion = Porsion.Piece },
                new Food { Calorie = 750, CategoryId =10, FoodID = 45, FoodName = "Tulumba", Porsion = Porsion.Piece },
                new Food { Calorie = 800, CategoryId =10, FoodID = 46, FoodName = "Katmer", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId =10, FoodID = 48, FoodName = "Sütlaç", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId =10, FoodID = 49, FoodName = "Sufle", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId =10, FoodID = 50, FoodName = "Waffle", Porsion = Porsion.Piece },
                new Food { Calorie = 450, CategoryId =10, FoodID = 51, FoodName = "Tiremusu", Porsion = Porsion.Piece }  
            );
        }
    }
}
