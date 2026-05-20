namespace PodgotovkaOOp
{
    partial class FormTechnicalInspection
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
            this.lbVehicleInfo = new System.Windows.Forms.Label();
            this.dgvInspections = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newinsp = new System.Windows.Forms.Label();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.mileage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tBEcoCat = new System.Windows.Forms.TextBox();
            this.lbEcoCat = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.inspName = new System.Windows.Forms.TextBox();
            this.lbBrakeEff = new System.Windows.Forms.Label();
            this.txtBrakes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParkBrake = new System.Windows.Forms.TextBox();
            this.cbLights = new System.Windows.Forms.CheckBox();
            this.cbTires = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lpg = new System.Windows.Forms.CheckBox();
            this.gasleak = new System.Windows.Forms.CheckBox();
            this.redo2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnLoad2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVehicleInfo
            // 
            this.lbVehicleInfo.AutoSize = true;
            this.lbVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleInfo.Location = new System.Drawing.Point(12, 9);
            this.lbVehicleInfo.Name = "lbVehicleInfo";
            this.lbVehicleInfo.Size = new System.Drawing.Size(0, 25);
            this.lbVehicleInfo.TabIndex = 0;
            // 
            // dgvInspections
            // 
            this.dgvInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspections.Location = new System.Drawing.Point(9, 37);
            this.dgvInspections.Name = "dgvInspections";
            this.dgvInspections.RowHeadersWidth = 51;
            this.dgvInspections.RowTemplate.Height = 24;
            this.dgvInspections.Size = new System.Drawing.Size(240, 101);
            this.dgvInspections.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // newinsp
            // 
            this.newinsp.AutoSize = true;
            this.newinsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newinsp.Location = new System.Drawing.Point(7, 141);
            this.newinsp.Name = "newinsp";
            this.newinsp.Size = new System.Drawing.Size(202, 20);
            this.newinsp.TabIndex = 3;
            this.newinsp.Text = "Register a new inspection";
            // 
            // txtMilage
            // 
            this.txtMilage.Location = new System.Drawing.Point(11, 212);
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.Size = new System.Drawing.Size(141, 22);
            this.txtMilage.TabIndex = 4;
            // 
            // mileage
            // 
            this.mileage.AutoSize = true;
            this.mileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileage.Location = new System.Drawing.Point(8, 189);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(103, 20);
            this.mileage.TabIndex = 5;
            this.mileage.Text = "Enter milage";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(5, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add inspection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(93, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Undo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBEcoCat
            // 
            this.tBEcoCat.Location = new System.Drawing.Point(12, 260);
            this.tBEcoCat.Name = "tBEcoCat";
            this.tBEcoCat.Size = new System.Drawing.Size(141, 22);
            this.tBEcoCat.TabIndex = 9;
            // 
            // lbEcoCat
            // 
            this.lbEcoCat.AutoSize = true;
            this.lbEcoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcoCat.Location = new System.Drawing.Point(7, 237);
            this.lbEcoCat.Name = "lbEcoCat";
            this.lbEcoCat.Size = new System.Drawing.Size(126, 20);
            this.lbEcoCat.TabIndex = 10;
            this.lbEcoCat.Text = "Eco group (1-6)";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(8, 285);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(137, 20);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Inspector\'s name";
            // 
            // inspName
            // 
            this.inspName.Location = new System.Drawing.Point(12, 309);
            this.inspName.Name = "inspName";
            this.inspName.Size = new System.Drawing.Size(141, 22);
            this.inspName.TabIndex = 12;
            // 
            // lbBrakeEff
            // 
            this.lbBrakeEff.AutoSize = true;
            this.lbBrakeEff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrakeEff.Location = new System.Drawing.Point(7, 334);
            this.lbBrakeEff.Name = "lbBrakeEff";
            this.lbBrakeEff.Size = new System.Drawing.Size(157, 20);
            this.lbBrakeEff.TabIndex = 13;
            this.lbBrakeEff.Text = "Brake efficency (%)";
            // 
            // txtBrakes
            // 
            this.txtBrakes.Location = new System.Drawing.Point(11, 357);
            this.txtBrakes.Name = "txtBrakes";
            this.txtBrakes.Size = new System.Drawing.Size(140, 22);
            this.txtBrakes.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Parking brake efficency (%)";
            // 
            // txtParkBrake
            // 
            this.txtParkBrake.Location = new System.Drawing.Point(13, 406);
            this.txtParkBrake.Name = "txtParkBrake";
            this.txtParkBrake.Size = new System.Drawing.Size(138, 22);
            this.txtParkBrake.TabIndex = 16;
            // 
            // cbLights
            // 
            this.cbLights.AutoSize = true;
            this.cbLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLights.Location = new System.Drawing.Point(11, 436);
            this.cbLights.Name = "cbLights";
            this.cbLights.Size = new System.Drawing.Size(144, 24);
            this.cbLights.TabIndex = 17;
            this.cbLights.Text = "Lights checked";
            this.cbLights.UseVisualStyleBackColor = true;
            // 
            // cbTires
            // 
            this.cbTires.AutoSize = true;
            this.cbTires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTires.Location = new System.Drawing.Point(11, 466);
            this.cbTires.Name = "cbTires";
            this.cbTires.Size = new System.Drawing.Size(208, 24);
            this.cbTires.TabIndex = 18;
            this.cbTires.Text = "Tires condition checked";
            this.cbTires.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Additional notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 521);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(140, 22);
            this.txtNotes.TabIndex = 20;
            // 
            // lpg
            // 
            this.lpg.AutoSize = true;
            this.lpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpg.Location = new System.Drawing.Point(13, 550);
            this.lpg.Name = "lpg";
            this.lpg.Size = new System.Drawing.Size(74, 24);
            this.lpg.TabIndex = 21;
            this.lpg.Text = "LPG?";
            this.lpg.UseVisualStyleBackColor = true;
            this.lpg.CheckedChanged += new System.EventHandler(this.lpg_CheckedChanged);
            // 
            // gasleak
            // 
            this.gasleak.AutoSize = true;
            this.gasleak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasleak.Location = new System.Drawing.Point(81, 549);
            this.gasleak.Name = "gasleak";
            this.gasleak.Size = new System.Drawing.Size(270, 24);
            this.gasleak.TabIndex = 22;
            this.gasleak.Text = "Gas leak test passed succesfuy";
            this.gasleak.UseVisualStyleBackColor = true;
            this.gasleak.Visible = false;
            // 
            // redo2
            // 
            this.redo2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.redo2.Location = new System.Drawing.Point(174, 580);
            this.redo2.Name = "redo2";
            this.redo2.Size = new System.Drawing.Size(75, 41);
            this.redo2.TabIndex = 23;
            this.redo2.Text = "Redo";
            this.redo2.UseVisualStyleBackColor = false;
            this.redo2.Click += new System.EventHandler(this.redo2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSave2.Location = new System.Drawing.Point(255, 580);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 41);
            this.btnSave2.TabIndex = 24;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoad2.Location = new System.Drawing.Point(336, 580);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(90, 41);
            this.btnLoad2.TabIndex = 25;
            this.btnLoad2.Text = "Load";
            this.btnLoad2.UseVisualStyleBackColor = false;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // FormTechnicalInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.redo2);
            this.Controls.Add(this.gasleak);
            this.Controls.Add(this.lpg);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTires);
            this.Controls.Add(this.cbLights);
            this.Controls.Add(this.txtParkBrake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrakes);
            this.Controls.Add(this.lbBrakeEff);
            this.Controls.Add(this.inspName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEcoCat);
            this.Controls.Add(this.tBEcoCat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.txtMilage);
            this.Controls.Add(this.newinsp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvInspections);
            this.Controls.Add(this.lbVehicleInfo);
            this.Name = "FormTechnicalInspection";
            this.Text = "FormTechnicalInspection";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVehicleInfo;
        private System.Windows.Forms.DataGridView dgvInspections;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label newinsp;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.Label mileage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tBEcoCat;
        private System.Windows.Forms.Label lbEcoCat;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox inspName;
        private System.Windows.Forms.Label lbBrakeEff;
        private System.Windows.Forms.TextBox txtBrakes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParkBrake;
        private System.Windows.Forms.CheckBox cbLights;
        private System.Windows.Forms.CheckBox cbTires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox lpg;
        private System.Windows.Forms.CheckBox gasleak;
        private System.Windows.Forms.Button redo2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnLoad2;
    }
}