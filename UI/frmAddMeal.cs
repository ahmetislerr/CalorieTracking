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

namespace UI
{
    public partial class frmAddMeal : Form
    {
        CalorieTrackingContext context;
        Food food;
        private  frmFoodAdd _frmFoodAdd;
        public frmAddMeal(frmFoodAdd frmFoddAdd)
        {
            InitializeComponent();
            _frmFoodAdd = frmFoddAdd;
        }
        private void AddMealForm_Load(object sender, EventArgs e)
        {
            context = new CalorieTrackingContext();
            food = new Food();
            ComboBoxFill();
        }
        private void ComboBoxFill()
        {
            cmbPorsion.DataSource = Enum.GetNames(typeof(Porsion)).ToList();
            cmbPorsion.SelectedIndex = -1;
            cmbBoxCategory.DataSource = context.Categories.Select(c => c.CategoryName).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Category

            if (cmbBoxCategory.SelectedIndex==-1)
            {
                MessageBox.Show("Please select a category");
                return;
            }
            else
            {
                food.CategoryId=context.Categories.FirstOrDefault(c=>c.CategoryName == cmbBoxCategory.Text).CategoryID;
            }

            #endregion

            #region FoodName

            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Please enter the name of the food");
            }
            else
            {
                food.FoodName = txtFoodName.Text;
            }
            #endregion

            #region Porsion
            if (cmbPorsion.SelectedIndex == -1)
            {
                MessageBox.Show("Please select serving");
                return;
            }
            else
            {
                if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Piece)
                {
                    food.Porsion = Porsion.Piece;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Gram)
                {
                    food.Porsion = Porsion.Gram;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Slice)
                {
                    food.Porsion = Porsion.Slice;
                }
                else if ((Entities.Enums.Porsion)cmbPorsion.SelectedIndex == Porsion.Millilitre)
                {
                    food.Porsion = Porsion.Millilitre;
                }
            }
            #endregion

            #region Calori

            if (string.IsNullOrEmpty((txtCalorie.Text)))
            {
                MessageBox.Show("Please enter calori value");
                return;
            }
            else
            {
                food.Calorie = Convert.ToDecimal(txtCalorie.Text);
            }

            #endregion


            #region FoodPhoto
            if (food.ImagePath == null)
            {
                MessageBox.Show("Please add picture");
            }
            #endregion

            #region DatabaseConnect
            context.Foods.Add(food);
            context.SaveChanges();
            MessageBox.Show("Food registration successful");

            ButtonClear();
            food = new Food();
            #endregion
        }

        private void ButtonClear()
        {
            foreach (Control item in grpFoodAdd.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                
            }


        }

        private void txtCalorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                food.ImagePath = ofd.FileName;
                txtImagePath.Text = food.ImagePath;
            }
            else
            {
                MessageBox.Show("Photo not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _frmFoodAdd.Show();
            this.Close();
        }
    }

}
