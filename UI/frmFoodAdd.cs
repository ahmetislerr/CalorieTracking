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
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class frmFoodAdd : Form
    {
        CalorieTrackingContext context;
        frmUserProfile _frmUserProfile;
        User _user;
        Meal _meal;
        List<Food> _foods;
        decimal _mealCalories;
        decimal _totalCalories;

        public frmFoodAdd(User user, frmUserProfile frmUserProfile)
        {
            InitializeComponent();
            _user = user;
            _frmUserProfile = frmUserProfile;
        }

        private void FoodAddForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            ComboBoxFill();
            FillDgvFoodAdd();

        }
        private void btnAddYourOwnFood_Click(object sender, EventArgs e)
        {
            frmAddMeal adfrm = new frmAddMeal(this);
            adfrm.Show();
            this.Hide();
        }
        private void cmbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbAllFoodName.DataSource = context.Foods
                .Where(c => c.CategoryId == context.Categories
                    .FirstOrDefault(y => y.CategoryName == cmbFoodCategory.Text).CategoryID).ToList();

            lstbAllFoodName.DisplayMember = "FoodName";
            lstbAllFoodName.ValueMember = "Calorie";
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var userMeals = context.Meals
                .Where(x => x.UserId == _user.UserID)
                .Where(y => y.MealDate == mntcldrCalender.SelectionStart.Date).ToList();

            bool isSame = false;
            foreach (var item in userMeals)
            {
                if (item.MealName == (Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex)
                {
                    isSame = true;
                    break;
                }
            }
            if (isSame)
            {
                MessageBox.Show("You have already added this meal. Please update");
                ListBoxComboBoxClear();
            }
            else
            {
                _meal = new Meal();

                if (cmbChooseYourMeals.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a meal");
                }
                else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Breakfast && _foods != null)
                {
                    _meal.MealName = MealType.Breakfast;
                    FoodAdd();
                }
                else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Lunch && _foods != null)
                {
                    _meal.MealName = MealType.Lunch;
                    FoodAdd();
                }
                else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Dinner && _foods != null)
                {
                    _meal.MealName = MealType.Dinner;
                    FoodAdd();
                }
                else if ((Entities.Enums.MealType)cmbChooseYourMeals.SelectedIndex == MealType.Snack && _foods != null)
                {
                    _meal.MealName = MealType.Snack;
                    FoodAdd();
                }
            }

        }
        private void FoodAdd()
        {
            _meal.MealDate = mntcldrCalender.SelectionStart.Date;
            _meal.TotalMealCalories = Convert.ToDecimal(lblCaloriValue.Text);

            foreach (var item in lstbFoodName.Items)
            {
                _foods.Add((Food)item);
                
            }
            
            _meal.Foods = _foods;
            _meal.UserId = _user.UserID;
            context.Meals.Add(_meal);
            context.SaveChanges();
            MessageBox.Show("Food registration successful");

            _mealCalories = 0;
            ListBoxComboBoxClear();
            FillDgvFoodAdd();

        }
        private void btnBacktoUserForm_Click(object sender, EventArgs e)
        {
            _frmUserProfile.Show();
            this.Close();
        }
        private void btnListBoxAdd_Click(object sender, EventArgs e)
        {
            if (lstbAllFoodName.SelectedItem == null)
            {
                MessageBox.Show("Please add a food");
            }
            else
            {
                lstbFoodName.Items.Add(lstbAllFoodName.SelectedItem);
                lstbFoodName.DisplayMember = "FoodName";
                lstbFoodName.ValueMember = "Calorie";
                Food food = (Food)lstbAllFoodName.SelectedItem;
                _mealCalories += food.Calorie;
                lblCaloriValue.Text = _mealCalories.ToString();
                _foods = new List<Food>();
                _foods.Add(food);
            }
        }
        private void ListBoxComboBoxClear()
        {
            foreach (Control item in grpFoodAdd.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
            lstbFoodName.Items.Clear();
            lblCaloriValue.Text = " ";
        }
        private void btnListBoxDelete_Click(object sender, EventArgs e)
        {
            Food food = (Food)lstbFoodName.SelectedItem;

            if (lstbFoodName.SelectedItem != null)
            {
                lstbFoodName.Items.Remove(lstbFoodName.SelectedItem);
                _foods.Remove(food);
                if (food != null)
                {
                    _mealCalories -= food.Calorie;
                    lblCaloriValue.Text = _mealCalories.ToString();
                }
                else
                {
                    _mealCalories -= 0;
                    lblCaloriValue.Text = "0";
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Please select a food from the list", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }
        private void mntcldrCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            FillDgvFoodAdd();
        }
        void FillDgvFoodAdd()
        {
            var selectedDate = context.Meals.Where(x => x.UserId == _user.UserID && x.MealDate == mntcldrCalender.SelectionStart.Date).ToList();

            dgvFoodAdd.DataSource = selectedDate;
            dgvFoodAdd.Columns["UserId"].Visible = false;
            dgvFoodAdd.Columns["MealID"].Visible = false;
            dgvFoodAdd.Columns["User"].Visible = false;
            dgvFoodAdd.Columns["MealName"].HeaderText = "Meal Name";
            dgvFoodAdd.Columns["MealDate"].HeaderText = "Meal Date";
            dgvFoodAdd.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }
        private void ComboBoxFill()
        {
            cmbChooseYourMeals.DataSource = Enum.GetNames(typeof(MealType)).ToList();
            cmbChooseYourMeals.SelectedIndex = -1;
            cmbFoodCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
            cmbFoodCategory.SelectedIndex = -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmFoodUpdate frmFoodUpdate = new frmFoodUpdate(_user, this, _frmUserProfile);
            frmFoodUpdate.Show();
            this.Hide();
        }
    }
}
