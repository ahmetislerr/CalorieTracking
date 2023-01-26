using System.Security.Cryptography;
using Entities.Enums;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text;
using System.Text.RegularExpressions;

namespace UI;

internal static class Methods
{
    internal static bool CheckForUpperCase(string sifre)
    {
        int count = 0;
        foreach (char item in sifre)
        {
            if (char.IsUpper(item))
            {
                count++;
            }
        }
        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    internal static bool CheckForLowerCase(string sifre)
    {
        int count = 0;
        foreach (char item in sifre)
        {
            if (char.IsLower(item))
            {
                count++;
            }
        }

        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    internal static bool CheckForSpecialCharacter(string sifre)
    {
        string specialCharacters = "!@#$%^&*()_+{}|:<>?-=[];',./";
        int count = 0;
        foreach (char item in sifre)
        {
            if (specialCharacters.Contains(item))
            {
                count++;
            }
        }
        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool IsValidEmail(string email)
    {
        Regex emailRegex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        return emailRegex.IsMatch(email);
    }
    public static string Sha256_hash(string sifre)
    {
        using (SHA256 hash = SHA256Managed.Create())
        {
            return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
        }
    }
<<<<<<< Updated upstream
=======

    public static void EditDatagridviewColumnName(DataGridView dgv)
    {
        dgv.Columns[0].DataPropertyName = "Key";
        dgv.Columns[0].HeaderText = "Food Name";
        dgv.Columns[1].DataPropertyName = "Sum";
        dgv.Columns[1].HeaderText = "Total Calorie";
        dgv.Columns[2].DataPropertyName = "Count";
        dgv.Columns[2].HeaderText = "Total Porsion";
    }
    
    public static void GetStatsForMostEatenMeal(ComboBox cmb,DataGridView dvg,MealType mealType)
    {
        context = new CalorieTrackingContext();
        var list = context.Meals
                   .Where(m => m.MealName == mealType)
                   .SelectMany(f => (f.Foods)
                   .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName, a.Category.CategoryID })
                   .Where(b => b.CategoryName == cmb.Text)
                   .ToList());

        var listGroupBy = list.GroupBy(x => x.FoodName)
            .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).OrderByDescending(x => x.Count).ToList().FirstOrDefault();

        var listMostEatenMeal = new List<object>();
        listMostEatenMeal.Add(listGroupBy);
        dvg.DataSource = listMostEatenMeal;

        if (listMostEatenMeal.Count > 1)
        {
            EditDatagridviewColumnName(dvg);
        }
    }

    public static void GetStatsForMealsEatenByCategory(ComboBox cmb, DataGridView dvg, MealType mealType)
    {
        context = new CalorieTrackingContext();

        var list = context.Meals
                   .Where(m => m.MealName == mealType)
                   .SelectMany(f => f.Foods)
                   .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                   .Where(b => b.CategoryName == cmb.Text)
                   .ToList();

        var listGroupBy = list.GroupBy(x => x.FoodName)
            .Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

        dvg.DataSource = listGroupBy;

        if (listGroupBy.Count > 1)
        {
            EditDatagridviewColumnName(dvg);
        }
    }
>>>>>>> Stashed changes
}




