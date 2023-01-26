using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserBirthDate { get; set; }
        public decimal UserWeight { get; set; }
        public decimal UserHeight { get; set; }
        public Gender UserGender { get; set; }
        public string? PhotoPath { get; set; }


        //Navigation
        public List<Meal> Meals { get; set; }
    }
}
