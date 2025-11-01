namespace Assessment2Maria
{
    partial class Formcar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMake = new TextBox();
            txtModel = new TextBox();
            btnCreate = new Button();
            btnClear = new Button();
            lblOutput = new Label();
            numYear = new NumericUpDown();
            numCapacity = new NumericUpDown();
            cboEngineType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 105);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 134);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Engine Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 163);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Capacity (cc)";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(100, 46);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(120, 23);
            txtMake.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(100, 73);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(120, 23);
            txtModel.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(84, 212);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create Car";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 212);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(22, 248);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(16, 15);
            lblOutput.TabIndex = 14;
            lblOutput.Text = "...";
            // 
            // numYear
            // 
            numYear.Location = new Point(99, 103);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 15;
            numYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // numCapacity
            // 
            numCapacity.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numCapacity.Location = new Point(100, 161);
            numCapacity.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 16;
            numCapacity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // cboEngineType
            // 
            cboEngineType.FormattingEnabled = true;
            cboEngineType.Location = new Point(99, 134);
            cboEngineType.Name = "cboEngineType";
            cboEngineType.Size = new Size(121, 23);
            cboEngineType.TabIndex = 17;
            // 
            // Formcar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboEngineType);
            Controls.Add(numCapacity);
            Controls.Add(numYear);
            Controls.Add(lblOutput);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formcar";
            Text = "Formcar";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMake;
        private TextBox txtModel;
        private Button btnCreate;
        private Button btnClear;
        private Label lblOutput;
        private NumericUpDown numYear;
        private NumericUpDown numCapacity;
        private ComboBox cboEngineType;
    }
}