
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Meal
    {
        public int MealID { get; set; }
        public MealType MealName { get; set; }
        public DateTime MealDate { get; set; }
        public decimal TotalMealCalories { get; set; }
        public int UserId { get; set; }

        //Navigation
        public User User { get; set; }
        public List<Food> Foods { get; set; }
    }
}
