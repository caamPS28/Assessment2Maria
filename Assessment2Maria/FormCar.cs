using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2Maria
{
    public partial class Formcar : Form
    {
        public Formcar()
        {
            InitializeComponent();
            this.Text = "Nested Classes Cars and engine";
            this.StartPosition = FormStartPosition.CenterParent;

            cboEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEngineType.Items.AddRange(Enum.GetNames(typeof(Car.EngineType)));
            if (cboEngineType.Items.Count > 0) cboEngineType.SelectedIndex = 0;

            lblOutput.Text = "Fill the fields and click create car";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string make = (txtMake.Text ?? "").Trim();
            string model = (txtModel.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Please enter both Make and Model.", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMake.Focus();
                return;
            }

            // Make sure we have a valid engine type
            var typeName = cboEngineType.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(typeName) ||
                !Enum.TryParse<Car.EngineType>(typeName, out var engineType))
            {
                MessageBox.Show("Please select an engine type.", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build nested Engine (no Power)
            var engine = new Car.Engine(
                type: engineType,
                CapacityCc: (int)numCapacity.Value
            );

            // Build Car
            var car = new Car(
                make: make,
                model: model,
                year: (int)numYear.Value,
                engine: engine
            );

            lblOutput.Text = car.ToMultilineString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMake.Clear();
            txtModel.Clear();
            numYear.Value = 2020;
            cboEngineType.SelectedIndex = 0;
            numCapacity.Value = 2000;
            lblOutput.Text = "Cleared, Enter details and click Create Car";
            txtMake.Focus();
        }
    }
    // ===========================
    //  NESTED CLASSES EXERCISE
    //  Outer: Car
    //  Inner: Engine (class) + EngineType (enum)
    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public Engine EngineSpec { get; }

        public Car(string make, string model, int year, Engine engine)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineSpec = engine ?? throw new ArgumentNullException(nameof(engine));
        }
        //nested enum, engine categories
        public enum EngineType { Petrol, Diesel, Hybrid, Electric }

        // Nested class (engine details live inside Car’s definition)
        public class Engine
        {
            public EngineType Type { get;}
            public int CapacityCc { get; }

            public Engine(EngineType type, int CapacityCc)
            {
                Type = type;
                CapacityCc = Math.Max(0, CapacityCc);

            }
            public override string ToString()
            {
                return $"{Type} | {CapacityCc} cc";
            }

        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} | {EngineSpec}";
        }
         public string ToMultilineString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make:    {Make}");
            sb.AppendLine($"Model:   {Model}");
            sb.AppendLine($"Year:    {Year}");
            sb.AppendLine($"Engine:  {EngineSpec.Type}");
            sb.AppendLine($"Capacity:{EngineSpec.CapacityCc} cc");
            return sb.ToString();
        }
    }
}
