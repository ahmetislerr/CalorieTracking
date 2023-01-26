using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    public partial class frmFoodUpdate : Form
    {
        User _user;
        frmFoodAdd _frmFoodAdd;
        frmUserProfile _frmUserProfile;
        CalorieTrackingContext context;
        List<Food> _foods;
        List<Meal> _meal;
        decimal totalCalori = 0;
        decimal mealCalori = 0;

        public frmFoodUpdate(User user, frmFoodAdd frmFoodAdd,frmUserProfile frmUserProfile)
        {
            InitializeComponent();
            _user = user;
            _frmFoodAdd = frmFoodAdd;
            _frmUserProfile = frmUserProfile;
            _foods = new List<Food>();
        }
        private void frmFoodUpdate_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();

            var ChoeseTime =
                context.Meals.Where(m => m.UserId == _user.UserID && m.MealDate == dtpFoodUpdate.Value.Date)
                    .Select(u => new { u.MealID, u.MealName, u.TotalMealCalories }).ToList();
            dgvFoodUpdate.DataSource = ChoeseTime;
            ComboBoxFill();
        }
        private void dtpFoodUpdate_ValueChanged(object sender, EventArgs e)
        {
            var ChoeseTime =
                context.Meals.Where(m => m.UserId == _user.UserID && m.MealDate == dtpFoodUpdate.Value.Date)
                    .Select(u => new { u.MealID, u.MealName, u.TotalMealCalories }).ToList();
            dgvFoodUpdate.DataSource = ChoeseTime;
        }
        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbFoodList.DataSource = context.Foods
                .Where(c => c.CategoryId == context.Categories
                    .FirstOrDefault(y => y.CategoryName == cmbFoodCategory.Text).CategoryID).ToList();

            lstbFoodList.DisplayMember = "FoodName";
            lstbFoodList.ValueMember = "Calorie";

        }

        private void ComboBoxFill()
        {
            cmbFoodCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            cmbFoodCategory.SelectedIndex = -1;
        }

        private void dgvFoodUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lstbEatsFood.Items.Clear();

            int mealID = Convert.ToInt32(dgvFoodUpdate.CurrentRow.Cells[0].Value);
            Meal _meal = context.Meals.Find(mealID);
            foreach (var item in context.Meals.Where(x => x.MealID == mealID).Select(y => y.Foods).FirstOrDefault())
            {
                if (item != null)
                {
                    lstbEatsFood.Items.Add(item);
                    lstbEatsFood.DisplayMember = "FoodName";
                    lstbEatsFood.ValueMember = "Calories";
                    _foods.Add(item);
                }
            }

            lstbEatsFood.DisplayMember = "FoodName";
            lstbEatsFood.ValueMember = "Calorie";

            lblCalorie.Text = _meal.TotalMealCalories.ToString();
        }
        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            totalCalori = Convert.ToDecimal(lblCalorie.Text);
            if (lstbEatsFood != null)
            {
                Food food = (Food)lstbEatsFood.SelectedItem;
                lstbEatsFood.Items.Remove(lstbEatsFood.SelectedItem);
                _foods.Remove(food);
                totalCalori -= food.Calorie;
            }
            else
            {
                MessageBox.Show("No food found to delete");
            }

            if (totalCalori <= 0)
            {
                btnFoodDelete.Enabled = false;
            }

            lblCalorie.Text = totalCalori.ToString();
        }
        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            totalCalori = Convert.ToDecimal(lblCalorie.Text);
            if (lstbFoodList.SelectedItem == null)
            {
                MessageBox.Show("Please select a category");
            }
            else
            {
                Food food = (Food)lstbFoodList.SelectedItem;
                lstbEatsFood.Items.Add(lstbFoodList.SelectedItem);
                totalCalori += food.Calorie;
                _foods.Add(food);
                lblCalorie.Text = totalCalori.ToString();
            }

            btnFoodDelete.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int mealID = Convert.ToInt32(dgvFoodUpdate.CurrentRow.Cells[0].Value);
            Meal _meal = context.Meals.Find(mealID);

            _meal.Foods = context.Meals.Where(x => x.MealID == mealID).Select(x => x.Foods).FirstOrDefault().ToList();
            _meal.Foods.Clear();

            context.Entry(_meal).Collection(f=>f.Foods).Load();

            //context.Meals.Include(s => new{s.Foods,s.MealID}).Where(u => u.UserId == _user.UserID).FirstOrDefault<Meal>();
            
            List<Food> foods = new List<Food>();
            foreach (var item in lstbEatsFood.Items)
            {
                foods.Add((Food)item);
            }
            _meal.Foods = foods;
            _meal.UserId = _user.UserID;
            _meal.TotalMealCalories = Convert.ToDecimal(lblCalorie.Text);
            //context.Meals.Update(_meal);
            context.SaveChanges();
            MessageBox.Show("Registration successful"); 
        }
        private void btnMealDelete_Click(object sender, EventArgs e)
        {
            int mealId = Convert.ToInt32(dgvFoodUpdate.CurrentRow.Cells[0].Value);

            Meal meal = context.Meals.Find(mealId);
            if (mealId != null)
            {
                context.Meals.Remove(meal);
            }
            context.SaveChanges();
            MessageBox.Show("Meal deleted successfully");

            dgvFoodUpdate.DataSource = context.Meals.Where(m => m.UserId == _user.UserID && m.MealDate == dtpFoodUpdate.Value.Date)
                .Select(u => new { u.MealID, u.MealName, u.TotalMealCalories }).ToList();
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _frmFoodAdd = new frmFoodAdd(_user, _frmUserProfile);
            _frmFoodAdd.Show();
            this.Close();

        }
    }
}

