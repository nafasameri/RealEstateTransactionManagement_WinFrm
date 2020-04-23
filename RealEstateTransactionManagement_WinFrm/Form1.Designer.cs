namespace RealEstateTransactionManagement_WinFrm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGetData = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlYard = new System.Windows.Forms.Panel();
            this.txbYard = new System.Windows.Forms.TextBox();
            this.pnlTerrace = new System.Windows.Forms.Panel();
            this.txbTerrace = new System.Windows.Forms.TextBox();
            this.pnlTypeProducts = new System.Windows.Forms.Panel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbRent = new System.Windows.Forms.TextBox();
            this.txbNumOfRooms = new System.Windows.Forms.TextBox();
            this.cmbCoverWall = new System.Windows.Forms.ComboBox();
            this.cmbColdSystem = new System.Windows.Forms.ComboBox();
            this.cmbHeatSystem = new System.Windows.Forms.ComboBox();
            this.cmbTerrace = new System.Windows.Forms.ComboBox();
            this.cmbYard = new System.Windows.Forms.ComboBox();
            this.txbFloor = new System.Windows.Forms.TextBox();
            this.txbFloorArea = new System.Windows.Forms.TextBox();
            this.cmbTypeProducts = new System.Windows.Forms.ComboBox();
            this.cmbHomeType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbShowData = new System.Windows.Forms.GroupBox();
            this.dgvHouse = new System.Windows.Forms.DataGridView();
            this.grbGetData.SuspendLayout();
            this.pnlYard.SuspendLayout();
            this.pnlTerrace.SuspendLayout();
            this.pnlTypeProducts.SuspendLayout();
            this.grbShowData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGetData
            // 
            this.grbGetData.BackColor = System.Drawing.Color.Transparent;
            this.grbGetData.Controls.Add(this.btnSave);
            this.grbGetData.Controls.Add(this.pnlYard);
            this.grbGetData.Controls.Add(this.pnlTerrace);
            this.grbGetData.Controls.Add(this.pnlTypeProducts);
            this.grbGetData.Controls.Add(this.txbNumOfRooms);
            this.grbGetData.Controls.Add(this.cmbCoverWall);
            this.grbGetData.Controls.Add(this.cmbColdSystem);
            this.grbGetData.Controls.Add(this.cmbHeatSystem);
            this.grbGetData.Controls.Add(this.cmbTerrace);
            this.grbGetData.Controls.Add(this.cmbYard);
            this.grbGetData.Controls.Add(this.txbFloor);
            this.grbGetData.Controls.Add(this.txbFloorArea);
            this.grbGetData.Controls.Add(this.cmbTypeProducts);
            this.grbGetData.Controls.Add(this.cmbHomeType);
            this.grbGetData.Controls.Add(this.label10);
            this.grbGetData.Controls.Add(this.label9);
            this.grbGetData.Controls.Add(this.label8);
            this.grbGetData.Controls.Add(this.label7);
            this.grbGetData.Controls.Add(this.label6);
            this.grbGetData.Controls.Add(this.label5);
            this.grbGetData.Controls.Add(this.label4);
            this.grbGetData.Controls.Add(this.label3);
            this.grbGetData.Controls.Add(this.label2);
            this.grbGetData.Controls.Add(this.label1);
            this.grbGetData.Location = new System.Drawing.Point(6, 3);
            this.grbGetData.Margin = new System.Windows.Forms.Padding(2);
            this.grbGetData.Name = "grbGetData";
            this.grbGetData.Padding = new System.Windows.Forms.Padding(2);
            this.grbGetData.Size = new System.Drawing.Size(456, 385);
            this.grbGetData.TabIndex = 1;
            this.grbGetData.TabStop = false;
            this.grbGetData.Text = "Get Data";
            this.grbGetData.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 341);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 35);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlYard
            // 
            this.pnlYard.Controls.Add(this.txbYard);
            this.pnlYard.Location = new System.Drawing.Point(268, 183);
            this.pnlYard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlYard.Name = "pnlYard";
            this.pnlYard.Size = new System.Drawing.Size(157, 29);
            this.pnlYard.TabIndex = 0;
            this.pnlYard.Visible = false;
            // 
            // txbYard
            // 
            this.txbYard.Location = new System.Drawing.Point(30, 5);
            this.txbYard.Margin = new System.Windows.Forms.Padding(2);
            this.txbYard.Name = "txbYard";
            this.txbYard.Size = new System.Drawing.Size(92, 20);
            this.txbYard.TabIndex = 21;
            this.txbYard.Text = "Yard";
            // 
            // pnlTerrace
            // 
            this.pnlTerrace.Controls.Add(this.txbTerrace);
            this.pnlTerrace.Location = new System.Drawing.Point(268, 219);
            this.pnlTerrace.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTerrace.Name = "pnlTerrace";
            this.pnlTerrace.Size = new System.Drawing.Size(157, 35);
            this.pnlTerrace.TabIndex = 20;
            this.pnlTerrace.Visible = false;
            // 
            // txbTerrace
            // 
            this.txbTerrace.Location = new System.Drawing.Point(30, 2);
            this.txbTerrace.Margin = new System.Windows.Forms.Padding(2);
            this.txbTerrace.Name = "txbTerrace";
            this.txbTerrace.Size = new System.Drawing.Size(92, 20);
            this.txbTerrace.TabIndex = 21;
            this.txbTerrace.Text = "Terrace";
            // 
            // pnlTypeProducts
            // 
            this.pnlTypeProducts.BackColor = System.Drawing.Color.Transparent;
            this.pnlTypeProducts.Controls.Add(this.txbPrice);
            this.pnlTypeProducts.Controls.Add(this.txbRent);
            this.pnlTypeProducts.Location = new System.Drawing.Point(268, 58);
            this.pnlTypeProducts.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTypeProducts.Name = "pnlTypeProducts";
            this.pnlTypeProducts.Size = new System.Drawing.Size(150, 81);
            this.pnlTypeProducts.TabIndex = 1;
            this.pnlTypeProducts.Visible = false;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(30, 15);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(92, 20);
            this.txbPrice.TabIndex = 20;
            this.txbPrice.Text = "Price";
            // 
            // txbRent
            // 
            this.txbRent.Location = new System.Drawing.Point(30, 46);
            this.txbRent.Margin = new System.Windows.Forms.Padding(2);
            this.txbRent.Name = "txbRent";
            this.txbRent.Size = new System.Drawing.Size(92, 20);
            this.txbRent.TabIndex = 21;
            this.txbRent.Text = "Rent";
            // 
            // txbNumOfRooms
            // 
            this.txbNumOfRooms.Location = new System.Drawing.Point(151, 254);
            this.txbNumOfRooms.Margin = new System.Windows.Forms.Padding(2);
            this.txbNumOfRooms.Name = "txbNumOfRooms";
            this.txbNumOfRooms.Size = new System.Drawing.Size(92, 20);
            this.txbNumOfRooms.TabIndex = 19;
            // 
            // cmbCoverWall
            // 
            this.cmbCoverWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoverWall.FormattingEnabled = true;
            this.cmbCoverWall.Items.AddRange(new object[] {
            "Paint",
            "Wallpaper",
            "None"});
            this.cmbCoverWall.Location = new System.Drawing.Point(151, 355);
            this.cmbCoverWall.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCoverWall.Name = "cmbCoverWall";
            this.cmbCoverWall.Size = new System.Drawing.Size(92, 21);
            this.cmbCoverWall.TabIndex = 18;
            // 
            // cmbColdSystem
            // 
            this.cmbColdSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColdSystem.FormattingEnabled = true;
            this.cmbColdSystem.Items.AddRange(new object[] {
            "Water cooler",
            "Air conditioner",
            "None"});
            this.cmbColdSystem.Location = new System.Drawing.Point(151, 321);
            this.cmbColdSystem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColdSystem.Name = "cmbColdSystem";
            this.cmbColdSystem.Size = new System.Drawing.Size(92, 21);
            this.cmbColdSystem.TabIndex = 17;
            // 
            // cmbHeatSystem
            // 
            this.cmbHeatSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeatSystem.FormattingEnabled = true;
            this.cmbHeatSystem.Items.AddRange(new object[] {
            "Heater",
            "Package",
            "None"});
            this.cmbHeatSystem.Location = new System.Drawing.Point(151, 287);
            this.cmbHeatSystem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHeatSystem.Name = "cmbHeatSystem";
            this.cmbHeatSystem.Size = new System.Drawing.Size(92, 21);
            this.cmbHeatSystem.TabIndex = 16;
            // 
            // cmbTerrace
            // 
            this.cmbTerrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerrace.FormattingEnabled = true;
            this.cmbTerrace.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbTerrace.Location = new System.Drawing.Point(151, 220);
            this.cmbTerrace.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTerrace.Name = "cmbTerrace";
            this.cmbTerrace.Size = new System.Drawing.Size(92, 21);
            this.cmbTerrace.TabIndex = 15;
            this.cmbTerrace.SelectedIndexChanged += new System.EventHandler(this.cmbTerrace_SelectedIndexChanged);
            // 
            // cmbYard
            // 
            this.cmbYard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYard.FormattingEnabled = true;
            this.cmbYard.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbYard.Location = new System.Drawing.Point(151, 186);
            this.cmbYard.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYard.Name = "cmbYard";
            this.cmbYard.Size = new System.Drawing.Size(92, 21);
            this.cmbYard.TabIndex = 14;
            this.cmbYard.SelectedIndexChanged += new System.EventHandler(this.cmbYard_SelectedIndexChanged);
            // 
            // txbFloor
            // 
            this.txbFloor.Location = new System.Drawing.Point(151, 154);
            this.txbFloor.Margin = new System.Windows.Forms.Padding(2);
            this.txbFloor.Name = "txbFloor";
            this.txbFloor.Size = new System.Drawing.Size(92, 20);
            this.txbFloor.TabIndex = 13;
            // 
            // txbFloorArea
            // 
            this.txbFloorArea.Location = new System.Drawing.Point(151, 121);
            this.txbFloorArea.Margin = new System.Windows.Forms.Padding(2);
            this.txbFloorArea.Name = "txbFloorArea";
            this.txbFloorArea.Size = new System.Drawing.Size(92, 20);
            this.txbFloorArea.TabIndex = 12;
            // 
            // cmbTypeProducts
            // 
            this.cmbTypeProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeProducts.FormattingEnabled = true;
            this.cmbTypeProducts.Items.AddRange(new object[] {
            "Sale",
            "Rent"});
            this.cmbTypeProducts.Location = new System.Drawing.Point(151, 87);
            this.cmbTypeProducts.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeProducts.Name = "cmbTypeProducts";
            this.cmbTypeProducts.Size = new System.Drawing.Size(92, 21);
            this.cmbTypeProducts.TabIndex = 11;
            this.cmbTypeProducts.SelectedIndexChanged += new System.EventHandler(this.cmbTypeProducts_SelectedIndexChanged);
            // 
            // cmbHomeType
            // 
            this.cmbHomeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeType.FormattingEnabled = true;
            this.cmbHomeType.Items.AddRange(new object[] {
            "Apartemant",
            "houses"});
            this.cmbHomeType.Location = new System.Drawing.Point(151, 53);
            this.cmbHomeType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHomeType.Name = "cmbHomeType";
            this.cmbHomeType.Size = new System.Drawing.Size(92, 21);
            this.cmbHomeType.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RosyBrown;
            this.label10.Location = new System.Drawing.Point(30, 360);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cover Wall";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(30, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cold System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Location = new System.Drawing.Point(30, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Heat System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(30, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Num Of Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(30, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Terrace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Floor Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Type";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(551, 344);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(96, 35);
            this.btnGetData.TabIndex = 22;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(551, 305);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(96, 35);
            this.btnShowData.TabIndex = 23;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(551, 266);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 35);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grbShowData
            // 
            this.grbShowData.BackColor = System.Drawing.Color.Transparent;
            this.grbShowData.Controls.Add(this.dgvHouse);
            this.grbShowData.Location = new System.Drawing.Point(6, 3);
            this.grbShowData.Margin = new System.Windows.Forms.Padding(2);
            this.grbShowData.Name = "grbShowData";
            this.grbShowData.Padding = new System.Windows.Forms.Padding(2);
            this.grbShowData.Size = new System.Drawing.Size(456, 385);
            this.grbShowData.TabIndex = 22;
            this.grbShowData.TabStop = false;
            this.grbShowData.Text = "Show Data";
            this.grbShowData.Visible = false;
            // 
            // dgvHouse
            // 
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Location = new System.Drawing.Point(6, 19);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.Size = new System.Drawing.Size(445, 354);
            this.dgvHouse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RealEstateTransactionManagement_WinFrm.Properties.Resources.property1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 392);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.grbGetData);
            this.Controls.Add(this.grbShowData);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGetData.ResumeLayout(false);
            this.grbGetData.PerformLayout();
            this.pnlYard.ResumeLayout(false);
            this.pnlYard.PerformLayout();
            this.pnlTerrace.ResumeLayout(false);
            this.pnlTerrace.PerformLayout();
            this.pnlTypeProducts.ResumeLayout(false);
            this.pnlTypeProducts.PerformLayout();
            this.grbShowData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGetData;
        private System.Windows.Forms.GroupBox grbShowData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Panel pnlYard;
        private System.Windows.Forms.Panel pnlTypeProducts;
        private System.Windows.Forms.Panel pnlTerrace;
        private System.Windows.Forms.TextBox txbYard;
        private System.Windows.Forms.TextBox txbTerrace;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbRent;
        private System.Windows.Forms.TextBox txbNumOfRooms;
        private System.Windows.Forms.TextBox txbFloor;
        private System.Windows.Forms.TextBox txbFloorArea;
        private System.Windows.Forms.ComboBox cmbCoverWall;
        private System.Windows.Forms.ComboBox cmbColdSystem;
        private System.Windows.Forms.ComboBox cmbHeatSystem;
        private System.Windows.Forms.ComboBox cmbTerrace;
        private System.Windows.Forms.ComboBox cmbYard;
        private System.Windows.Forms.ComboBox cmbTypeProducts;
        private System.Windows.Forms.ComboBox cmbHomeType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvHouse;
    }
}

