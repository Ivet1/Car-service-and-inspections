namespace PodgotovkaOOp
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.lbVehicleType = new System.Windows.Forms.ListBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBaseCost = new System.Windows.Forms.TextBox();
            this.RegNum = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.BasePrice = new System.Windows.Forms.Label();
            this.btnCalcTotal = new System.Windows.Forms.Button();
            this.gbSpecificData = new System.Windows.Forms.GroupBox();
            this.cbIstwostroke = new System.Windows.Forms.CheckBox();
            this.txtDynamicValue = new System.Windows.Forms.TextBox();
            this.lblDynamic = new System.Windows.Forms.Label();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnShowTrucks = new System.Windows.Forms.Button();
            this.btnShowMotorcycles = new System.Windows.Forms.Button();
            this.btnSortByPrice = new System.Windows.Forms.Button();
            this.btnquickstats = new System.Windows.Forms.Button();
            this.lbStats = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnOpenInspections = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.gbSpecificData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(21, 12);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(278, 516);
            this.dgvVehicles.TabIndex = 0;
            this.dgvVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.Location = new System.Drawing.Point(307, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(433, 11);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(113, 22);
            this.txtRegNum.TabIndex = 2;
            // 
            // lbVehicleType
            // 
            this.lbVehicleType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbVehicleType.FormattingEnabled = true;
            this.lbVehicleType.ItemHeight = 16;
            this.lbVehicleType.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Motorcycle"});
            this.lbVehicleType.Location = new System.Drawing.Point(307, 11);
            this.lbVehicleType.Name = "lbVehicleType";
            this.lbVehicleType.Size = new System.Drawing.Size(120, 84);
            this.lbVehicleType.TabIndex = 3;
            this.lbVehicleType.SelectedIndexChanged += new System.EventHandler(this.lbVehicleType_SelectedIndexChanged);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(433, 40);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(113, 22);
            this.txtBrand.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(433, 68);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(113, 22);
            this.txtModel.TabIndex = 5;
            // 
            // txtBaseCost
            // 
            this.txtBaseCost.Location = new System.Drawing.Point(433, 96);
            this.txtBaseCost.Name = "txtBaseCost";
            this.txtBaseCost.Size = new System.Drawing.Size(113, 22);
            this.txtBaseCost.TabIndex = 6;
            // 
            // RegNum
            // 
            this.RegNum.AutoSize = true;
            this.RegNum.Location = new System.Drawing.Point(552, 14);
            this.RegNum.Name = "RegNum";
            this.RegNum.Size = new System.Drawing.Size(127, 16);
            this.RegNum.TabIndex = 7;
            this.RegNum.Text = "Registration number";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(552, 43);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(43, 16);
            this.Brand.TabIndex = 8;
            this.Brand.Text = "Brand";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(552, 68);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(45, 16);
            this.Model.TabIndex = 9;
            this.Model.Text = "Model";
            // 
            // BasePrice
            // 
            this.BasePrice.AutoSize = true;
            this.BasePrice.Location = new System.Drawing.Point(552, 96);
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(155, 16);
            this.BasePrice.TabIndex = 10;
            this.BasePrice.Text = "Base Repair Cost (labor)";
            // 
            // btnCalcTotal
            // 
            this.btnCalcTotal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalcTotal.Location = new System.Drawing.Point(307, 145);
            this.btnCalcTotal.Name = "btnCalcTotal";
            this.btnCalcTotal.Size = new System.Drawing.Size(120, 49);
            this.btnCalcTotal.TabIndex = 11;
            this.btnCalcTotal.Text = "Calculate Total Repair Cost";
            this.btnCalcTotal.UseVisualStyleBackColor = false;
            this.btnCalcTotal.Click += new System.EventHandler(this.btnCalcTotal_Click);
            // 
            // gbSpecificData
            // 
            this.gbSpecificData.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSpecificData.Controls.Add(this.cbIstwostroke);
            this.gbSpecificData.Controls.Add(this.txtDynamicValue);
            this.gbSpecificData.Controls.Add(this.lblDynamic);
            this.gbSpecificData.Location = new System.Drawing.Point(433, 124);
            this.gbSpecificData.Name = "gbSpecificData";
            this.gbSpecificData.Size = new System.Drawing.Size(200, 100);
            this.gbSpecificData.TabIndex = 12;
            this.gbSpecificData.TabStop = false;
            this.gbSpecificData.Text = "Specific Data ";
            this.gbSpecificData.Enter += new System.EventHandler(this.gbSpecificData_Enter);
            // 
            // cbIstwostroke
            // 
            this.cbIstwostroke.AutoSize = true;
            this.cbIstwostroke.Location = new System.Drawing.Point(10, 70);
            this.cbIstwostroke.Name = "cbIstwostroke";
            this.cbIstwostroke.Size = new System.Drawing.Size(102, 20);
            this.cbIstwostroke.TabIndex = 2;
            this.cbIstwostroke.Text = "Is two stroke";
            this.cbIstwostroke.UseVisualStyleBackColor = true;
            this.cbIstwostroke.Visible = false;
            // 
            // txtDynamicValue
            // 
            this.txtDynamicValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtDynamicValue.Location = new System.Drawing.Point(6, 41);
            this.txtDynamicValue.Name = "txtDynamicValue";
            this.txtDynamicValue.Size = new System.Drawing.Size(100, 22);
            this.txtDynamicValue.TabIndex = 1;
            // 
            // lblDynamic
            // 
            this.lblDynamic.AutoSize = true;
            this.lblDynamic.Location = new System.Drawing.Point(7, 22);
            this.lblDynamic.Name = "lblDynamic";
            this.lblDynamic.Size = new System.Drawing.Size(0, 16);
            this.lblDynamic.TabIndex = 0;
            // 
            // btnShowCars
            // 
            this.btnShowCars.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowCars.Location = new System.Drawing.Point(305, 200);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(122, 50);
            this.btnShowCars.TabIndex = 13;
            this.btnShowCars.Text = "Show only cars";
            this.btnShowCars.UseVisualStyleBackColor = false;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnShowTrucks
            // 
            this.btnShowTrucks.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowTrucks.Location = new System.Drawing.Point(307, 256);
            this.btnShowTrucks.Name = "btnShowTrucks";
            this.btnShowTrucks.Size = new System.Drawing.Size(120, 43);
            this.btnShowTrucks.TabIndex = 14;
            this.btnShowTrucks.Text = "Show only trucks";
            this.btnShowTrucks.UseVisualStyleBackColor = false;
            this.btnShowTrucks.Click += new System.EventHandler(this.btnShowTrucks_Click);
            // 
            // btnShowMotorcycles
            // 
            this.btnShowMotorcycles.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowMotorcycles.Location = new System.Drawing.Point(307, 305);
            this.btnShowMotorcycles.Name = "btnShowMotorcycles";
            this.btnShowMotorcycles.Size = new System.Drawing.Size(120, 44);
            this.btnShowMotorcycles.TabIndex = 15;
            this.btnShowMotorcycles.Text = "Show only motorcycles";
            this.btnShowMotorcycles.UseVisualStyleBackColor = false;
            this.btnShowMotorcycles.Click += new System.EventHandler(this.btnShowMotorcycles_Click);
            // 
            // btnSortByPrice
            // 
            this.btnSortByPrice.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSortByPrice.Location = new System.Drawing.Point(305, 355);
            this.btnSortByPrice.Name = "btnSortByPrice";
            this.btnSortByPrice.Size = new System.Drawing.Size(122, 40);
            this.btnSortByPrice.TabIndex = 16;
            this.btnSortByPrice.Text = "Sort by repair price";
            this.btnSortByPrice.UseVisualStyleBackColor = false;
            this.btnSortByPrice.Click += new System.EventHandler(this.btnSortByPrice_Click);
            // 
            // btnquickstats
            // 
            this.btnquickstats.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnquickstats.Location = new System.Drawing.Point(305, 399);
            this.btnquickstats.Name = "btnquickstats";
            this.btnquickstats.Size = new System.Drawing.Size(120, 39);
            this.btnquickstats.TabIndex = 17;
            this.btnquickstats.Text = "Quick statistics";
            this.btnquickstats.UseVisualStyleBackColor = false;
            this.btnquickstats.Click += new System.EventHandler(this.btnquickstats_Click);
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.Location = new System.Drawing.Point(436, 245);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(0, 16);
            this.lbStats.TabIndex = 18;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUndo.Location = new System.Drawing.Point(305, 444);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(120, 39);
            this.btnUndo.TabIndex = 19;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRedo.Location = new System.Drawing.Point(305, 489);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(118, 39);
            this.btnRedo.TabIndex = 20;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnOpenInspections
            // 
            this.btnOpenInspections.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOpenInspections.Location = new System.Drawing.Point(639, 124);
            this.btnOpenInspections.Name = "btnOpenInspections";
            this.btnOpenInspections.Size = new System.Drawing.Size(90, 65);
            this.btnOpenInspections.TabIndex = 21;
            this.btnOpenInspections.Text = "Open inspections";
            this.btnOpenInspections.UseVisualStyleBackColor = false;
            this.btnOpenInspections.Click += new System.EventHandler(this.btnOpenInspections_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSave.Location = new System.Drawing.Point(640, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoad.Location = new System.Drawing.Point(640, 237);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 28);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(822, 544);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenInspections);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.btnquickstats);
            this.Controls.Add(this.btnSortByPrice);
            this.Controls.Add(this.btnShowMotorcycles);
            this.Controls.Add(this.btnShowTrucks);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.gbSpecificData);
            this.Controls.Add(this.btnCalcTotal);
            this.Controls.Add(this.BasePrice);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.RegNum);
            this.Controls.Add(this.txtBaseCost);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lbVehicleType);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVehicles);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.gbSpecificData.ResumeLayout(false);
            this.gbSpecificData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.ListBox lbVehicleType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBaseCost;
        private System.Windows.Forms.Label RegNum;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label BasePrice;
        private System.Windows.Forms.Button btnCalcTotal;
        private System.Windows.Forms.GroupBox gbSpecificData;
        private System.Windows.Forms.TextBox txtDynamicValue;
        private System.Windows.Forms.Label lblDynamic;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnShowTrucks;
        private System.Windows.Forms.Button btnShowMotorcycles;
        private System.Windows.Forms.Button btnSortByPrice;
        private System.Windows.Forms.Button btnquickstats;
        private System.Windows.Forms.Label lbStats;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnOpenInspections;
        private System.Windows.Forms.CheckBox cbIstwostroke;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

