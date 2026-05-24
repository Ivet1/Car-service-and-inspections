# Vehicle Inspection & Technical Control System (GTP Manager)

A C# Windows Forms application designed to automate Vehicle Inspection Stations. The project features a highly organized single-project structure where domain logic, architectural interfaces, state commands, and data services are fully integrated alongside the graphical user interface.

The system leverages advanced Object-Oriented Programming (OOP) principles, structural polymorphism, the **Command Design Pattern** for bidirectional state navigation (Undo/Redo), and manual **LINQ to XML** serialization for relational data persistence.

---

##  Architectural & Technical Implementation

### 1. Polymorphic Domain Model Hierarchy (`Models/`)
The core application manages vehicles and logs using a clean object-oriented inheritance structure located inside the `Models` directory:
* **`Vehicle` (Base Class):** The main abstract/base class capturing generic attributes: `Brand`, `Model`, `Registration Number`, and `Base Repair Cost`(labor).
* **`Car`:** Extends `Vehicle` with dynamic fuel type configurations (`Gasoline` / `Diesel`).
* **`Truck`:** Extends `Vehicle` with load capacity metrics (`Load Capacity` in tons).
* **`Motorcycle`:** Extends `Vehicle` with cubic capacity (`Engine Displacement` in cc) and a specialized `Is Two-Stroke` structural boolean layout.
* **`Inspection`:** A standalone domain model capturing single diagnostic logs: inspection date, mileage, eco group, inspector name, braking efficiency percentages, and safety checkboxes.

### 2. Interface Contracts (`Interface/`)
Central abstractions that govern application communication and UI rendering pipelines:
* **`ICommand`:** Exposes the pure architectural interface for state operations via `.Execute()` and `.Undo()`.
* **`IDisplayable`:** Contract ensuring models can cleanly format and display their metadata fields inside the data grids and informational dialog viewports.

### 3. The Command Pattern Engine (`Commands/`)
To eliminate dirty state tracking inside the UI forms, all destructive and creative mutations are encapsulated inside dedicated behavioral Command objects:
* **`AddVehicleCommand`:** Encapsulates the transactional registration of a polymorphic vehicle asset into the repository layer.
* **`AddInspectionCommand`:** Handles the validation and addition of a newly approved technical review record linked to a targeted vehicle.
* **`RemoveAllVehiclesCommand`:** Safely wipes the active workspace collection while logging the state for global reversion.
* **`UndoCommand`:** Interacts with the central history stacks to step the global application data state backward seamlessly.

### 4. Technical Inspection & Safety Validation Logic
Selecting a vehicle from the primary dashboard and triggering the **Open Inspections Panel** launches a context-aware secondary dialog environment. This form evaluates critical safety attributes under realistic compliance rules:
* **Mandatory Safety Diagnostics:** Structural checkboxes verifying 'Lights Checked' and 'Tires Checked'.
* **Efficiency Matrix Computations:** Validates numerical tolerances for `Brake Efficiency (%)` and `Parking Brake Efficiency (%)`.
* **Conditional LPG Safety Pipeline:** Toggling the `LPG Checkbox` dynamically exposes an additional `Gas Leak Test Passed` validation requirement.
* **The Validation Guardrail:** An inspection can **only** be added if all mandatory checkboxes are marked `true`, braking thresholds are met, and the conditional gas leak test is satisfied.

### 5. Manual XML Data Access Layer (`Services/`)
The data management pipeline avoids high reflection costs by parsing data elements manually using LINQ to XML. It writes clean schemas preserving the parent-child node relationships linking specific validation logs directly to their parent vehicle registration keys.

---

##  Repository Directory Layout

*  **`Models/`** — `Vehicle.cs`, `Car.cs`, `Truck.cs`, `Motorcycle.cs`, `Inspection.cs`
*  **`Interface/`** — `ICommand.cs`, `IDisplayable.cs`
*  **`Commands/`** — `AddVehicleCommand.cs`, `AddInspectionCommand.cs`, `RemoveAllVehiclesCommand.cs`, `UndoCommand.cs`
*  **`Services/`** — XML data persistence, loading, and structural saving engines (`XmlServices.cs`)
*  **`MainForm.cs`** — Central operational center managing registry data grids, quick statistics, and vehicle category filter pipelines.
*  **`InspectionForm.cs`** — Diagnostic workshop UI processing brake analysis sliders, conditional LPG switches, and inspection history grids.

---

## Build, Run & Verification Protocol

1. **Setup:** Launch **Visual Studio** and open the `.sln` solution deployment layout.
2. **Compilation:** Execute structural validation checks by pressing **F5** or clicking **Start**.
3. **Validation Test Run:**
   * Select a vehicle class from the dropdown menu (e.g., *Truck*), fill out its specific properties (*Load Capacity*), and tap **Add Vehicle**.
   * Run an **Undo** cycle to observe it disappearing from the database grid view, followed by an execution to restore it.
   * Highlight the vehicle, press **Open Inspections**, and simulate an inspection session by entering values into the brake percentage textboxes (minimum **50%** for service brakes and **16%** for the parking brake) to verify the conditional validation guardrails.
   * Save the operational state layer into a local file container via the **Save XML** dialog and recall it using **Load XML**.
