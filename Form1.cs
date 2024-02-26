namespace MLSApp
{
    public delegate void ShowModifyDel();
    public delegate void RefreshGrid();


    public partial class MLSForm : Form
    {
        List<House> FilteredList = new List<House>();
        List<House> SearchList = new List<House>();

        public MLSForm()
        {
            InitializeComponent();
        }

        private void MLSForm_Load(object sender, EventArgs e)
        {
            dataGridCurrent.DataSource = Data.HouseList;
            dataGridCurrent.Columns[2].Visible = false;
            dataGridCurrent.Columns[4].Visible = false;
            dataGridCurrent.Columns[8].Visible = false;
            comboBoxCity.DataSource = Enum.GetValues(typeof(City));
            comboBoxCity.SelectedIndex = 0;
            comboBoxPrice.SelectedIndex = 0;
            comboBoxArea.SelectedIndex = 0;
            comboBoxBath.SelectedIndex = 0;
            comboBoxBed.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.ShowModify += NewLogin_ShowModify;
            newLogin.Show();
        }

        private void NewLogin_ShowModify()
        {
            groupBoxModify.Visible = true;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            int pricecat = comboBoxPrice.SelectedIndex;
            int sqfeetcat = comboBoxArea.SelectedIndex;
            int bedrooms = comboBoxBed.SelectedIndex;
            int bathrooms = comboBoxBath.SelectedIndex;
            City city = (City)comboBoxCity.SelectedValue;
            if (pricecat != 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms != 0 && city != City.All)  //  All filters selected
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.SqFeetCat == sqfeetcat && house.Bed == bedrooms && house.Bath == bathrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms != 0 && city == City.All)  //  Price, sq feet, bed, and bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.SqFeetCat == sqfeetcat && house.Bed == bedrooms && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat != 0 && bedrooms == 0 && bathrooms != 0 && city == City.All)  //  Price, sq feet, and bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.SqFeetCat == sqfeetcat && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms == 0 && city == City.All)  //  Price, sq feet, and bed
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.SqFeetCat == sqfeetcat && house.Bed == bedrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat != 0 && bedrooms == 0 && bathrooms == 0 && city == City.All)  //  Price & sq feet
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.SqFeetCat == sqfeetcat)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat == 0 && bedrooms == 0 && bathrooms == 0 && city == City.All)  //  Price
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms != 0 && city != City.All)  //  Price, bed, bath, and city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.Bed == bedrooms && house.Bath == bathrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms != 0 && city == City.All)  //  Price, bed, and bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.Bed == bedrooms && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat != 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms == 0 && city == City.All)  //  Price & bed
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.PriceCat == pricecat && house.Bed == bedrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms != 0 && city != City.All)  //  Sq feet, bed, bath, and city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.Bed == bedrooms && house.Bath == bathrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms != 0 && city == City.All)  //  Sq feet, bed, and bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.Bed == bedrooms && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms == 0 && bathrooms != 0 && city == City.All)  //  Sq feet & bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms == 0 && city != City.All)  //  Sq feet, bed, and city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.Bed == bedrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms != 0 && bathrooms == 0 && city == City.All)  //  Sq feet & bed
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.Bed == bedrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms == 0 && bathrooms == 0 && city != City.All)  //  Sq feet & city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat != 0 && bedrooms == 0 && bathrooms == 0 && city == City.All)  //  Sq feet
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.SqFeetCat == sqfeetcat)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms != 0 && city != City.All)  //  Bed, bath, and city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.Bed == bedrooms && house.Bath == bathrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms != 0 && city == City.All)  //  Bed & bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.Bed == bedrooms && house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms != 0 && bathrooms == 0 && city == City.All)  //  Bed
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.Bed == bedrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms == 0 && bathrooms != 0 && city != City.All)  //  Bath & city
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.Bath == bathrooms && house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms == 0 && bathrooms != 0 && city == City.All)  //  Bath
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.Bath == bathrooms)
                    {
                        FilteredList.Add(house);
                    }
                }
            }
            if (pricecat == 0 && sqfeetcat == 0 && bedrooms == 0 && bathrooms == 0 && city != City.All)  //  City
            {
                foreach (House house in Data.HouseList)
                {
                    if (house.City == city)
                    {
                        FilteredList.Add(house);
                    }
                }
            }

            dataGridCurrent.DataSource = null;

            dataGridCurrent.DataSource = FilteredList;
            dataGridCurrent.Columns[2].Visible = false;
            dataGridCurrent.Columns[4].Visible = false;
            dataGridCurrent.Columns[8].Visible = false;
            richTextDescription.Clear();

            btnApply.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxPrice.SelectedIndex = 0;
            comboBoxArea.SelectedIndex = 0;
            comboBoxBath.SelectedIndex = 0;
            comboBoxBed.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
            dataGridCurrent.DataSource = null;
            dataGridCurrent.DataSource = Data.HouseList;
            dataGridCurrent.Columns[2].Visible = false;
            dataGridCurrent.Columns[4].Visible = false;
            dataGridCurrent.Columns[8].Visible = false;
            btnApply.Visible = true;
            FilteredList.Clear();
            SearchList.Clear();
            txtSearch.Clear();
            richTextDescription.Clear();
        }

        private void dataGridCurrent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            richTextDescription.Text = Data.HouseList[row].Description;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int mls = int.Parse(txtSearch.Text);
            foreach (House house in Data.HouseList)
            {
                if (house.MLS == mls)
                {
                    SearchList.Add(house);
                }
            }
            dataGridCurrent.DataSource = null;
            dataGridCurrent.DataSource = SearchList;
            dataGridCurrent.Columns[2].Visible = false;
            dataGridCurrent.Columns[4].Visible = false;
            dataGridCurrent.Columns[8].Visible = false;
            richTextDescription.Clear();
            txtSearch.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewListing newListing = new NewListing();
            newListing.GridRefresh += NewListing_GridRefresh;
            newListing.Show();
        }

        private void NewListing_GridRefresh()
        {
            comboBoxPrice.SelectedIndex = 0;
            comboBoxArea.SelectedIndex = 0;
            comboBoxBath.SelectedIndex = 0;
            comboBoxBed.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
            dataGridCurrent.DataSource = null;
            dataGridCurrent.DataSource = Data.HouseList;
            dataGridCurrent.Columns[2].Visible = false;
            dataGridCurrent.Columns[4].Visible = false;
            dataGridCurrent.Columns[8].Visible = false;
            btnApply.Visible = true;
            FilteredList.Clear();
            SearchList.Clear();
            txtSearch.Clear();
            richTextDescription.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove the listing?",
                "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.HouseList.RemoveAt(dataGridCurrent.CurrentRow.Index);
                dataGridCurrent.DataSource = null;
                dataGridCurrent.DataSource = Data.HouseList;
                dataGridCurrent.Columns[2].Visible = false;
                dataGridCurrent.Columns[4].Visible = false;
                dataGridCurrent.Columns[8].Visible = false;
                richTextDescription.Clear();
            }
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            
        }
    }
}
