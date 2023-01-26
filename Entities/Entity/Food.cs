using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Food
    {  
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Calorie { get; set; }
        public string? ImagePath { get; set; }
        public Porsion Porsion { get; set; }
        public int CategoryId { get; set; }
        

        //Navigation
        public Category Category { get; set; }
        public List<Meal> Meals { get; set; }
    }
}
