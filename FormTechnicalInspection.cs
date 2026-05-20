using PodgotovkaOOp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodgotovkaOOp.Commands;
using PodgotovkaOOp.Models.Intefrace;
using PodgotovkaOOp.Services;
using PodgotovkaOOp.Models;

namespace PodgotovkaOOp
{
    public partial class FormTechnicalInspection : Form
    {
        private readonly Vehicle _currentVehicle;
        List<Models.Inspection> inspections= new List<Models.Inspection>();
        private Stack<ICommand> inspectionundoStack = new Stack<ICommand>();
        private Stack<ICommand> inspectionredoStack = new Stack<ICommand>();
        public FormTechnicalInspection(Vehicle selectedVehicle)
        {
            _currentVehicle = selectedVehicle;
            InitializeComponent();
            lbVehicleInfo.Text = $"Inspecting:{_currentVehicle.GetSummaryInfo()}";
        }

        private void lpg_CheckedChanged(object sender, EventArgs e)
        {
            gasleak.Visible= lpg.Checked;
            if(!lpg.Checked)
            {
                gasleak.Checked = false;
            }
        }
        public void ClearFields()
        {
            txtBrakes.Clear();
            txtNotes.Clear();
            txtParkBrake.Clear();
            inspName.Clear();
            tBEcoCat.Clear();
            txtMilage.Clear();
            dateTimePicker1.Value= DateTime.Now;
            cbLights.Checked = false;
            cbTires.Checked = false;
            lpg.Checked = false;
        }
        public void RefreshInspectionTable()
        {
            dgvInspections.DataSource = null;
            dgvInspections.DataSource = inspections;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Inspection date cannot be in the future.");
                return;
            }
        if 
        (string.IsNullOrWhiteSpace(inspName.Text) ||
        string.IsNullOrWhiteSpace(txtMilage.Text) ||
        string.IsNullOrWhiteSpace(tBEcoCat.Text) ||
        string.IsNullOrWhiteSpace(txtParkBrake.Text) ||
        string.IsNullOrWhiteSpace(txtBrakes.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(txtMilage.Text, out int mileageValue))
            {
                MessageBox.Show("Please enter a valid number for mileage.");
                return;
            }
            if(!int.TryParse(tBEcoCat.Text, out int ecoCatValue))
            {
                MessageBox.Show("Please enter a valid number for the eco category.");
                return;
            }
            if(tBEcoCat.Text.Length<1||tBEcoCat.Text.Length>6)
            {
                MessageBox.Show("Eco category must be between 1 and 6.");
                return;
            }
            if(!decimal.TryParse(txtParkBrake.Text, out decimal parkBrakeValue))
            {
                MessageBox.Show("Please enter a valid number for parking brake efficiency.");
                return;
            }
            if(!decimal.TryParse(txtBrakes.Text, out decimal brakeEfficiencyValue))
            {
                MessageBox.Show("Please enter a valid number for brake efficiency.");
                return;
            }
            bool brakesAreOk = brakeEfficiencyValue >= 50.0m;
            bool parkingBrakeIsOk = parkBrakeValue >= 16.0m;
            bool gasIsOK=!lpg.Checked || gasleak.Checked;
            bool lightsAreOK = cbLights.Checked;
            bool tiresAreOK = cbTires.Checked;
            bool dynamicInspectionPassed = brakesAreOk && parkingBrakeIsOk && gasIsOK && lightsAreOK && tiresAreOK;
            Models.Inspection newInspection = new Models.Inspection(
                inspName.Text,
                dateTimePicker1.Value,
                dynamicInspectionPassed,
                mileageValue,
                ecoCatValue,
                gasleak.Checked,
                parkBrakeValue,
                brakeEfficiencyValue,
                cbLights.Checked,
                cbTires.Checked,
                txtNotes.Text
            );
            if(newInspection!=null)
            {
                ICommand addCommand = new AddInspectionCommand(inspections, newInspection);
                addCommand.Execute();
                inspectionundoStack.Push(addCommand);
                inspectionredoStack.Clear();
            }
            RefreshInspectionTable();
            ClearFields();
            if (newInspection.Passed)
            {
                MessageBox.Show("Inspection passed successfully!");
            }
            else
            {
                MessageBox.Show("Inspection failed. Please review the results and try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inspectionundoStack.Count > 0)
            {
                ICommand command=inspectionundoStack.Pop();
                command.Undo();
                inspectionredoStack.Push(command);
                RefreshInspectionTable();
            }
                else
                {
                    MessageBox.Show("No actions to undo.");
                }
        }

        private void redo2_Click(object sender, EventArgs e)
        {
            if (inspectionredoStack.Count > 0)
            {
                ICommand command = inspectionredoStack.Pop();
                command.Redo();
                inspectionundoStack.Push(command);
                RefreshInspectionTable();
            }
            else
            {   MessageBox.Show("No actions to redo."); }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (inspections == null || inspections.Count == 0)
            {
                MessageBox.Show("Няма прегледи за запис!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml";
                sfd.Title = "Save inspections";
                sfd.FileName = "inspections.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PodgotovkaOOp.Services.XML xmlService = new PodgotovkaOOp.Services.XML();
                        xmlService.Save(sfd.FileName, inspections);

                        MessageBox.Show("Inspections saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while trying to save inspections: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml";
                ofd.Title = "Select XML File to Load Inspections";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PodgotovkaOOp.Services.XML xmlService = new PodgotovkaOOp.Services.XML();
                        inspections = xmlService.LoadInspections(ofd.FileName);
                        dgvInspections.DataSource = null;
                        dgvInspections.DataSource = inspections;

                        MessageBox.Show("Inspections loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading inspections: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
    }
    }
}
