namespace Assessment2Maria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            partsToolStripMenuItem = new ToolStripMenuItem();
            dGraphicsToolStripMenuItem = new ToolStripMenuItem();
            dragAndDropToolStripMenuItem = new ToolStripMenuItem();
            linkedListToolStripMenuItem = new ToolStripMenuItem();
            carAndEngineToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, partsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // partsToolStripMenuItem
            // 
            partsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dGraphicsToolStripMenuItem, dragAndDropToolStripMenuItem, linkedListToolStripMenuItem, carAndEngineToolStripMenuItem });
            partsToolStripMenuItem.Name = "partsToolStripMenuItem";
            partsToolStripMenuItem.Size = new Size(45, 20);
            partsToolStripMenuItem.Text = "parts";
            // 
            // dGraphicsToolStripMenuItem
            // 
            dGraphicsToolStripMenuItem.Name = "dGraphicsToolStripMenuItem";
            dGraphicsToolStripMenuItem.Size = new Size(180, 22);
            dGraphicsToolStripMenuItem.Text = "2D Graphics";
            dGraphicsToolStripMenuItem.Click += dGraphicsToolStripMenuItem_Click;
            // 
            // dragAndDropToolStripMenuItem
            // 
            dragAndDropToolStripMenuItem.Name = "dragAndDropToolStripMenuItem";
            dragAndDropToolStripMenuItem.Size = new Size(180, 22);
            dragAndDropToolStripMenuItem.Text = "Drag and Drop";
            dragAndDropToolStripMenuItem.Click += dragAndDropToolStripMenuItem_Click;
            // 
            // linkedListToolStripMenuItem
            // 
            linkedListToolStripMenuItem.Name = "linkedListToolStripMenuItem";
            linkedListToolStripMenuItem.Size = new Size(180, 22);
            linkedListToolStripMenuItem.Text = "Linked List";
            linkedListToolStripMenuItem.Click += linkedListToolStripMenuItem_Click;
            // 
            // carAndEngineToolStripMenuItem
            // 
            carAndEngineToolStripMenuItem.Name = "carAndEngineToolStripMenuItem";
            carAndEngineToolStripMenuItem.Size = new Size(180, 22);
            carAndEngineToolStripMenuItem.Text = "Car and Engine";
            carAndEngineToolStripMenuItem.Click += carAndEngineToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(42, 20);
            helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assessment 2 Main Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem partsToolStripMenuItem;
        private ToolStripMenuItem dGraphicsToolStripMenuItem;
        private ToolStripMenuItem dragAndDropToolStripMenuItem;
        private ToolStripMenuItem linkedListToolStripMenuItem;
        private ToolStripMenuItem carAndEngineToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
