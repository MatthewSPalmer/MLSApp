using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSApp
{
    public partial class NewListing : Form
    {
        public event RefreshGrid? GridRefresh;
        public NewListing()
        {
            InitializeComponent();
        }

        private void NewListing_Load(object sender, EventArgs e)
        {
            comboBoxNewCity.DataSource = Enum.GetValues(typeof(City));
            comboBoxNewCity.SelectedIndex = 0;
            comboBoxNewBath.SelectedIndex = 0;
            comboBoxNewBed.SelectedIndex = 0;
        }

        private void btnNewSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewMLS.Text == String.Empty || txtNewPrice.Text == String.Empty || txtNewSqFeet.Text == String.Empty || richTextNewDescription.Text == String.Empty || comboBoxNewCity.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill out all boxes!");
            }
            else
            {
                int MLS = int.Parse(txtNewMLS.Text);
                int price = int.Parse(txtNewPrice.Text);
                int pricecat = GetPriceCat(price);
                int sqfeet = int.Parse(txtNewSqFeet.Text);
                int sqfeetcat = GetPriceCat(sqfeet);
                int bed = int.Parse(comboBoxNewBed.Text);
                int bath = int.Parse(comboBoxNewBath.Text);
                string description = richTextNewDescription.Text;
                City city = (City)comboBoxNewCity.SelectedValue;
                Data.HouseList.Add(new House() { MLS = MLS, Price = price, PriceCat = pricecat, SqFeet = sqfeet, SqFeetCat = sqfeetcat, Bed = bed, Bath = bath, City = city, Description = description });
                this.Hide();
                GridRefresh();
            }
        }

        private void btnNewClear_Click(object sender, EventArgs e)
        {
            txtNewMLS.Text = null;
            txtNewPrice.Text = null;
            txtNewSqFeet.Text = null;
            comboBoxNewBath.SelectedIndex = 0;
            comboBoxNewBed.SelectedIndex = 0;
            comboBoxNewCity.SelectedIndex = 0;
            richTextNewDescription.Clear();
        }

        private void btnNewReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private int GetPriceCat(int price)
        {
            if (price < 375000) { return 1; }
            if (price >= 375000 && price < 400000) { return 2; }
            if (price >= 400000 && price < 425000) { return 3; }
            if (price >= 425000 && price < 450000) { return 4; }
            if (price >= 450000 && price < 475000) { return 5; }
            if (price >= 475000 && price < 500000) { return 6; }
            if (price >= 500000 && price < 525000) { return 7; }
            if (price >= 525000) { return 8; }
            else return 9;
        }
        private int GetSqFeetCat(int sqfeet)
        {
            if (sqfeet < 1500) { return 1; }
            if (sqfeet >= 1500 && sqfeet > 1750) { return 2; }
            if (sqfeet >= 1750 && sqfeet > 2000) { return 3; }
            if (sqfeet >= 2000 && sqfeet > 2250) { return 4; }
            if (sqfeet >= 2250 && sqfeet > 2500) { return 5; }
            if (sqfeet >= 2500 && sqfeet > 2750) { return 6; }
            if (sqfeet >= 2750 && sqfeet > 3000) { return 7; }
            if (sqfeet >= 3000 && sqfeet > 3250) { return 8; }
            if (sqfeet >= 3250) { return 9; }
            else return 10;

        }

        private void btnNewSubmit_Validating(object sender, CancelEventArgs e)
        {
        }

        private void comboBoxNewCity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
