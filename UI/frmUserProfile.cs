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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class frmUserProfile : Form
    {
        CalorieTrackingContext context;
        private DateTime time;
        private DateTime time2;
        private User _userProfile;

        public frmUserProfile(User user)
        {
            InitializeComponent();
            _userProfile = user;
        }
        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();

            lblUserInfo.Text = "Name Surname :" + "\n" + _userProfile.UserName + " " + _userProfile.UserSurname
                               + "\n" + "Weight :" + _userProfile.UserWeight
                               + "\n" + "Height :" + _userProfile.UserHeight
                               + "\n" + "BirthDate :" + _userProfile.UserBirthDate.ToShortDateString();

            if (_userProfile.PhotoPath != null)
            {
                pctbUserPicture.Image = Image.FromFile(_userProfile.PhotoPath);
            }

            var selectedDate = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate == DateTime.Today).ToList();

            dgvDailyReport.DataSource = selectedDate;
            dgvDailyReport.Columns["UserId"].Visible = false;
            dgvDailyReport.Columns["MealID"].Visible = false;
            dgvDailyReport.Columns["User"].Visible = false;
            dgvDailyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvDailyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvDailyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";

            ComboBoxFill();
        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            frmFoodAdd frm = new frmFoodAdd(_userProfile, this);
            frm.Show();
            this.Hide();
        }
        private void btnStatisticsForm_Click(object sender, EventArgs e)
        {
            frmStatistics frm = new frmStatistics(_userProfile, this);
            frm.Show();
            this.Hide();
        }
        private void dtpDailyReport_ValueChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;

            var selectedDate = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate == time).ToList();

            dgvDailyReport.DataSource = selectedDate;
            dgvDailyReport.Columns["UserId"].Visible = false;
            dgvDailyReport.Columns["MealID"].Visible = false;
            dgvDailyReport.Columns["User"].Visible = false;
            dgvDailyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvDailyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvDailyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }
        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;
            time2 = dtpDailyReport.Value.Date.AddDays(-7);

            var selectedDate = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate <= time && x.MealDate >= time2).OrderBy(x => x.MealDate).ToList();

            dgvWeeklyMonthlyReport.DataSource = selectedDate;

            dgvWeeklyMonthlyReport.Columns["UserId"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealID"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["User"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvWeeklyMonthlyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvWeeklyMonthlyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }
        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            time = dtpDailyReport.Value.Date;
            time2 = dtpDailyReport.Value.Date.AddDays(-30);

            var selectedDate = context.Meals.Where(x => x.UserId == _userProfile.UserID && x.MealDate <= time && x.MealDate >= time2).OrderBy(x => x.MealDate).ToList();


            dgvWeeklyMonthlyReport.DataSource = selectedDate;

            dgvWeeklyMonthlyReport.Columns["UserId"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealID"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["User"].Visible = false;
            dgvWeeklyMonthlyReport.Columns["MealName"].HeaderText = "Meal Name";
            dgvWeeklyMonthlyReport.Columns["MealDate"].HeaderText = "Meal Date";
            dgvWeeklyMonthlyReport.Columns["TotalMealCalories"].HeaderText = "Total Meal Calories";
        }
        private void rbWeeklyComparison_CheckedChanged(object sender, EventArgs e)
        {
            time = DateTime.Today;
            time2 = DateTime.Today.AddDays(-7);

            if (cmbMealSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a meal");
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Breakfast)
            {
                var list = context.Meals
                .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Breakfast && m.MealDate <= time && m.MealDate >= time2)
                .SelectMany(f => f.Foods)
                .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
             
                dgvComparisonReport.Columns[0].DataPropertyName = "Key";
                dgvComparisonReport.Columns[0].HeaderText = "Food Name";
                dgvComparisonReport.Columns[1].DataPropertyName = "Sum";
                dgvComparisonReport.Columns[1].HeaderText = "Total Calorie";
                dgvComparisonReport.Columns[2].DataPropertyName = "Count";
                dgvComparisonReport.Columns[2].HeaderText = "Total Porsion";
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Dinner)
            {
                var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Snack)
            {
                var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Snack && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Lunch)
            {
                var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Lunch && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
            }
        }
        private void rbmounthlyComparison_CheckedChanged(object sender, EventArgs e)
        {
            time = DateTime.Today;
            time2 = DateTime.Today.AddDays(-30);

            if (cmbMealSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a meal");
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Breakfast)
            {
                var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Breakfast && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy; 
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Dinner)
            {
               var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Dinner && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;  
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Snack)
            {
               var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Snack && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
            }
            else if ((Entities.Enums.MealType)cmbMealSelection.SelectedIndex == MealType.Lunch)
            {
                var list = context.Meals
                    .Where(m => m.UserId == _userProfile.UserID && m.MealName == MealType.Lunch && m.MealDate <= time && m.MealDate >= time2)
                    .SelectMany(f => f.Foods)
                    .Select(a => new { a.FoodName, a.Porsion, a.Calorie, a.Category.CategoryName })
                    .ToList();

                var listGroupBy = list.GroupBy(x => x.FoodName).Select(b => new { b.Key, Sum = b.Sum(s => s.Calorie), Count = b.Count() }).ToList();

                dgvComparisonReport.DataSource = listGroupBy;
            }
        }
        private void cmbMealSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbWeeklyComparison.Checked == true)
            {
                rbWeeklyComparison_CheckedChanged(sender, e);
            }
            else if (rbmounthlyComparison.Checked == true)
            {
                rbmounthlyComparison_CheckedChanged(sender, e);
            }
        }
        private void ComboBoxFill()
        {
            cmbMealSelection.DataSource = Enum.GetNames(typeof(MealType)).ToList();
            cmbMealSelection.SelectedIndex = -1;
        }

        private void frmUserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
