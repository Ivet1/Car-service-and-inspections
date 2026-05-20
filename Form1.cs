using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodgotovkaOOp.Models.Intefrace;
using PodgotovkaOOp.Commands;
using PodgotovkaOOp.Models;
using PodgotovkaOOp.Services;

namespace PodgotovkaOOp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Models.Vehicle> vehicles = new List<Models.Vehicle>();
        private Stack<ICommand> _undoStack = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = lbVehicleType.SelectedItem?.ToString();
            txtDynamicValue.Clear();
            cbIstwostroke.Visible = false;
            cbIstwostroke.Checked = false;
            if (selectedType == "Car")
            {
                lblDynamic.Text = "Engine Type (Gasoline/Diesel):";
                gbSpecificData.Text = "Car Specific Data";
            }
            else if (selectedType == "Truck")
            {
                lblDynamic.Text = "Load Capacity (tons):";
                gbSpecificData.Text = "Truck Specific Data";
            }
            else if (selectedType == "Motorcycle")
            {
                lblDynamic.Text = "Engine Displacement (cc):";
                gbSpecificData.Text = "Motorcycle Specific Data";
                cbIstwostroke.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedType = lbVehicleType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(txtRegNum.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtBaseCost.Text) ||
                string.IsNullOrWhiteSpace(txtDynamicValue.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // ВАЛИДАЦИЯ ЗА БАЗОВАТА ЦЕНА (Безопасно преобразуване)
            if (!decimal.TryParse(txtBaseCost.Text, out decimal baseCost))
            {
                MessageBox.Show("Base cost must be a valid number.");
                return;
            }

            string regNum = txtRegNum.Text;
            string brand = txtBrand.Text;
            string model = txtModel.Text;

            // Тук ще запазим създадения обект, за да го подадем на командата
            Models.Vehicle newVehicle = null;

            // 2. СЪЗДАВАНЕ НА КОНКРЕТНИЯ ОБЕКТ СПРЯМО ТИПА
            if (selectedType == "Car")
            {
                string engineType = txtDynamicValue.Text;
                if (engineType.ToLower() != "gasoline" && engineType.ToLower() != "diesel")
                {
                    MessageBox.Show("Engine type must be 'Gasoline' or 'Diesel'.");
                    return;
                }
                newVehicle = new Models.Car(regNum, brand, model, baseCost, engineType);
            }
            else if (selectedType == "Truck")
            {
                if (!decimal.TryParse(txtDynamicValue.Text, out decimal loadCapacity))
                {
                    MessageBox.Show("Load capacity must be a valid number.");
                    return;
                }
                newVehicle = new Models.Truck(regNum, brand, model, baseCost, loadCapacity);
            }
            else if (selectedType == "Motorcycle")
            {
                if (!decimal.TryParse(txtDynamicValue.Text, out decimal engineDisplacement))
                {
                    MessageBox.Show("Engine displacement must be a valid number.");
                    return;
                }
                bool isTwoStroke = cbIstwostroke.Checked;
                newVehicle = new Models.Motorcycle(regNum, brand, model, baseCost, engineDisplacement, isTwoStroke);
            }
            else
            {
                MessageBox.Show("Please select a valid vehicle type from the list.");
                return;
            }

            // 3. ПРИЛАГАНЕ НА COMMAND PATTERN (Ако обектът е създаден успешно)
            if (newVehicle != null)
            {
                // Създаваме листчето-команда, като му даваме главния списък (vehicles) и новия обект
                ICommand addCommand = new AddVehicleCommand(vehicles, newVehicle);

                // Изпълняваме командата (тя вътрешно прави vehicles.Add(newVehicle))
                addCommand.Execute();

                // Слагаме я в стека за връщане назад и чистим Redo историята
                _undoStack.Push(addCommand);
                _redoStack.Clear();
            }

            RefreshTable();
            ClearTextBoxes();
            MessageBox.Show("Vehicle added successfully.");
        }
        private void RefreshTable()
        {
            dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = vehicles;
        }
        private void ClearTextBoxes()
        {
            txtRegNum.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtBaseCost.Clear();
            txtDynamicValue.Clear();
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            if (vehicles.Count == 0 || vehicles == null)
            {
                MessageBox.Show("No vehicles to calculate.");
                return;
            }
            decimal totalCost = vehicles.Sum(v => v.CalculateModelCost());
            MessageBox.Show($"Total Repair Cost for all vehicles: {totalCost:C}");
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            var cars = vehicles.OfType<Models.Car>().ToList();
            if (cars.Count == 0)
            {
                MessageBox.Show("No cars to display.");
                return;
            }
            else
            {
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = cars;
            }
        }

        private void btnShowTrucks_Click(object sender, EventArgs e)
        {
            var trucks = vehicles.OfType<Models.Truck>().ToList();
            if (trucks.Count == 0)
            {
                MessageBox.Show("No trucks to display.");
                return;
            }
            else
            {
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = trucks;
            }
        }
        private void btnShowMotorcycles_Click(object sender, EventArgs e)
        {
            var motorcycles = vehicles.OfType<Models.Motorcycle>().ToList();
            if (motorcycles.Count == 0)
            {
                MessageBox.Show("No motorcycles to display.");
                return;
            }
            else
            {
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = motorcycles;
            }
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            var sortedVehicles=vehicles.OrderByDescending(vehicles => vehicles.CalculateModelCost()).ToList();
         dgvVehicles.DataSource = null;
            dgvVehicles.DataSource = sortedVehicles;
        }

        private void btnquickstats_Click(object sender, EventArgs e)
        {
            int carsCount = vehicles.OfType<Models.Car>().Count();
            int trucksCount = vehicles.OfType<Models.Truck>().Count();
            int motorcyclesCount = vehicles.OfType<Models.Motorcycle>().Count();
            decimal avgCarCost = vehicles.OfType<Models.Car>().Any() ?
                vehicles.OfType<Models.Car>().Average(c => c.CalculateModelCost()) : 0;
            decimal avgTruckCost = vehicles.OfType<Models.Truck>().Any() ?
                vehicles.OfType<Models.Truck>().Average(t => t.CalculateModelCost()) : 0;
            decimal avgMotorcycleCost = vehicles.OfType<Models.Motorcycle>().Any() ?
                vehicles.OfType<Models.Motorcycle>().Average(m => m.CalculateModelCost()) : 0;
           string message=$"Vehicle count:\n" +
                $"Cars: {carsCount}\n" +
                $"Trucks: {trucksCount}\n" +
                $"Motorcycles: {motorcyclesCount}\n\n" +
                $"Average Repair Cost:\n" +
                $"Cars: {avgCarCost:C}\n" +
                $"Trucks: {avgTruckCost:C}\n" +
                $"Motorcycles: {avgMotorcycleCost:C}";
            lbStats.Text = message;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count > 0)
            {
                // 2.Взимаме ГОТОВАТА, вече съществуваща последна команда(напр.Add или Delete)
                ICommand lastCommand = _undoStack.Pop();
                // 3. Извикваме нейния ВЪТРЕШЕН метод Undo (тя сама знае какво да прави)
                lastCommand.Undo();
                // 4. Преместваме я в Redo стека, ако потребителят размисли
                _redoStack.Push(lastCommand);
                RefreshTable();
            }
            else
            {
                MessageBox.Show("No actions to undo.");
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (_redoStack.Count > 0)
            {
                // 2. Взимаме последно отменената команда от върха на Redo кутията
                ICommand lastUndoneCommand = _redoStack.Pop();
                // 3. Изпълняваме я наново (Ако е била Add - добавя колата пак, ако е била Delete - я трие пак)
                lastUndoneCommand.Redo();
                // 4. Връщаме я обратно в Undo кутията, защото тя отново е реално действие
                _undoStack.Push(lastUndoneCommand);
                RefreshTable();
            }
            else
            {
                MessageBox.Show("No actions to redo.");
            }
        }

        private void btnOpenInspections_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                var selectedVehicle = dgvVehicles.SelectedRows[0].DataBoundItem as Models.Vehicle;
                if(selectedVehicle!=null)
                {
                    FormTechnicalInspection inspectionsForm = new FormTechnicalInspection(selectedVehicle);
                    inspectionsForm.ShowDialog();
                }
            }
                else
                {
                    MessageBox.Show("Please select a vehicle to view inspections.");
            }
        }

        private void dgvVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedVehicle = dgvVehicles.Rows[e.RowIndex].DataBoundItem as Models.Vehicle;
               if(selectedVehicle!=null)
                {
                    string details = selectedVehicle.GetDetailedInfo();
                    MessageBox.Show(details, "Vehicle Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gbSpecificData_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (vehicles == null || vehicles.Count == 0)
            {
                MessageBox.Show("No vehicles to save");
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml";
                sfd.Title = "Save vehicles";
                sfd.FileName = "vehicles.xml"; 

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PodgotovkaOOp.Services.XML xmlService = new PodgotovkaOOp.Services.XML();
                        xmlService.Save(sfd.FileName, vehicles);

                        MessageBox.Show("Vehicles saved succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while trying to save: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml";
                ofd.Title = "Select XML File to Load Vehicles";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PodgotovkaOOp.Services.XML xmlService = new PodgotovkaOOp.Services.XML();
                        vehicles = xmlService.LoadVehicles(ofd.FileName);
                        dgvVehicles.DataSource = null;
                        dgvVehicles.DataSource = vehicles;

                        MessageBox.Show("Vehicles loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


