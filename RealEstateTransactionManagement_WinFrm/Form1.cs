using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RealEstateTransactionManagement_WinFrm
{
    public partial class Form1 : Form
    {
        public struct HouseType
        {
            public string HomeType;//ویلایی یا اپارتمانی
            public string TypeProducts;//فروشی یا اجاره ای
            public int Price;//قیمت خونه یا رهن
            public int Rent;//قیمت اجاره
            public int FloorArea;//مساحت زیربنا
            public int Floor;//طبقه
            public int YardArea;//مساحت حیاط
            public int TerraceArea;//مساحت تراس
            public int NumOfRooms;//تعداد اتاق ها
            public string yard;//حیاط اختصاصی
            public string terrace;//تراس
            public string HeatSystem;//سیستم گرمایش
            public string ColdSystem;//سیستم سرمایش
            public string CoverWall;//پوشش دیوار
        };

        SqlConnection Connection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        CurrencyManager cr;
        HouseType House;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\Projects\Projects VS_2015\RealEstateTransactionManagement_WinFrm\RealEstateTransactionManagement_WinFrm\dbManagement.mdf"";Integrated Security=True";
            Connection.Open();
        }

        private void cmbTypeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlTypeProducts.Visible = true;
            if (cmbTypeProducts.SelectedItem.ToString() == "Rent") ;
            else txbRent.Visible = false;
        }

        private void cmbYard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYard.SelectedItem.ToString() == "Yes") pnlYard.Visible = true;
            else pnlYard.Visible = false;
        }

        private void cmbTerrace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTerrace.SelectedItem.ToString() == "Yes") pnlTerrace.Visible = true;
            else pnlTerrace.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { House.HomeType = cmbHomeType.SelectedItem.ToString(); } catch { }
            try { House.TypeProducts = cmbTypeProducts.SelectedItem.ToString(); } catch { }
            try { House.Price = int.Parse(txbPrice.Text); } catch { }
            try { House.Rent = int.Parse(txbRent.Text); } catch { }
            try { House.FloorArea = int.Parse(txbFloorArea.Text); } catch { }
            try { House.Floor = int.Parse(txbFloor.Text); } catch { }
            try { House.NumOfRooms = int.Parse(txbNumOfRooms.Text); } catch { }
            try { House.ColdSystem = cmbColdSystem.SelectedItem.ToString(); } catch { }
            try { House.HeatSystem = cmbHeatSystem.SelectedItem.ToString(); } catch { }
            try { House.CoverWall = cmbCoverWall.SelectedItem.ToString(); } catch { }
            try { if (cmbYard.SelectedItem.ToString() == "Yes") House.YardArea = int.Parse(txbYard.Text);
                else House.YardArea = 0; } catch { }
            try { if (cmbTerrace.SelectedItem.ToString() == "Yes") House.TerraceArea = int.Parse(txbTerrace.Text);
                else House.TerraceArea = 0; } catch { }

            sqlCommand.CommandText = "INSERT INTO tblHouses (HomeType, TypeProducts, Price, Rent, FloorArea, Floor, YardArea, Yard, TerraceArea, Terrace, NumOfRooms, HeatSystem, ColdSystem, CoverWall) " +
                " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14)";
            sqlCommand.Connection = Connection; 
            sqlCommand.Parameters.AddWithValue("p1", House.HomeType);
            sqlCommand.Parameters.AddWithValue("p2", House.TypeProducts);
            sqlCommand.Parameters.AddWithValue("p3", House.Price);
            sqlCommand.Parameters.AddWithValue("p4", House.Rent);
            sqlCommand.Parameters.AddWithValue("p5", House.FloorArea);
            sqlCommand.Parameters.AddWithValue("p6", House.Floor);
            sqlCommand.Parameters.AddWithValue("p7", House.YardArea);
            sqlCommand.Parameters.AddWithValue("p8", House.yard);
            sqlCommand.Parameters.AddWithValue("p9", House.TerraceArea);
            sqlCommand.Parameters.AddWithValue("p10", House.terrace);
            sqlCommand.Parameters.AddWithValue("p11", House.NumOfRooms);
            sqlCommand.Parameters.AddWithValue("p12", House.HeatSystem);
            sqlCommand.Parameters.AddWithValue("p13", House.ColdSystem);
            sqlCommand.Parameters.AddWithValue("p14", House.CoverWall);
            sqlCommand.ExecuteNonQuery();
        }

        private void FillGrid(string sql = "SELECT * FROM tblHouses")
        {
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = Connection;
            sqlDataAdapter.SelectCommand = sqlCommand;
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet, "T1");
            dgvHouse.DataBindings.Clear();
            dgvHouse.DataBindings.Add("datasource", dataSet, "T1");
            txbYard.DataBindings.Clear();
            txbYard.DataBindings.Add("text", dataSet, "T1.YardArea");
            txbTerrace.DataBindings.Clear();
            txbTerrace.DataBindings.Add("text", dataSet, "T1.TerraceArea");
            txbPrice.DataBindings.Clear();
            txbPrice.DataBindings.Add("text", dataSet, "T1.Price");
            txbRent.DataBindings.Clear();
            txbRent.DataBindings.Add("text", dataSet, "T1.Rent");
            txbNumOfRooms.DataBindings.Clear();
            txbNumOfRooms.DataBindings.Add("text", dataSet, "T1.NumOfRooms");
            txbFloor.DataBindings.Clear();
            txbFloor.DataBindings.Add("text", dataSet, "T1.Floor");
            txbFloorArea.DataBindings.Clear();
            txbFloorArea.DataBindings.Add("text", dataSet, "T1.FloorArea");
            cmbCoverWall.DataBindings.Clear();
            cmbCoverWall.DataBindings.Add("text", dataSet, "T1.CoverWall");
            cmbColdSystem.DataBindings.Clear();
            cmbColdSystem.DataBindings.Add("text", dataSet, "T1.ColdSystem");
            cmbHeatSystem.DataBindings.Clear();
            cmbHeatSystem.DataBindings.Add("text", dataSet, "T1.HeatSystem");
            cmbTerrace.DataBindings.Clear();
            cmbTerrace.DataBindings.Add("text", dataSet, "T1.Terrace");
            cmbYard.DataBindings.Clear();
            cmbYard.DataBindings.Add("text", dataSet, "T1.Yard");
            cmbTypeProducts.DataBindings.Clear();
            cmbTypeProducts.DataBindings.Add("text", dataSet, "T1.TypeProducts");
            cmbHomeType.DataBindings.Clear();
            cmbHomeType.DataBindings.Add("text", dataSet, "T1.HomeType");

            cr = (CurrencyManager)this.BindingContext[dataSet, "T1"];

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            grbGetData.Visible = true;
            grbShowData.Visible = false;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            grbShowData.Visible = true;
            grbGetData.Visible = false;
            FillGrid();
        }
    }
}