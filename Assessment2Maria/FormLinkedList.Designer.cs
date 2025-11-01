namespace Assessment2Maria
{
    partial class formlinkedlist
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
            txtImput = new TextBox();
            btnBuild = new Button();
            btnShowForward = new Button();
            btnShowBackward = new Button();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtImput
            // 
            txtImput.Location = new Point(12, 20);
            txtImput.Name = "txtImput";
            txtImput.Size = new Size(138, 23);
            txtImput.TabIndex = 0;
            // 
            // btnBuild
            // 
            btnBuild.Location = new Point(171, 12);
            btnBuild.Name = "btnBuild";
            btnBuild.Size = new Size(137, 37);
            btnBuild.TabIndex = 1;
            btnBuild.Text = "Build List";
            btnBuild.UseVisualStyleBackColor = true;
            btnBuild.Click += btnBuild_Click;
            // 
            // btnShowForward
            // 
            btnShowForward.Location = new Point(347, 12);
            btnShowForward.Name = "btnShowForward";
            btnShowForward.Size = new Size(135, 37);
            btnShowForward.TabIndex = 2;
            btnShowForward.Text = "Show Forward";
            btnShowForward.UseVisualStyleBackColor = true;
            btnShowForward.Click += btnShowForward_Click;
            // 
            // btnShowBackward
            // 
            btnShowBackward.Location = new Point(507, 12);
            btnShowBackward.Name = "btnShowBackward";
            btnShowBackward.Size = new Size(129, 37);
            btnShowBackward.TabIndex = 3;
            btnShowBackward.Text = "Show Backward";
            btnShowBackward.UseVisualStyleBackColor = true;
            btnShowBackward.Click += btnShowBackward_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 158);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(206, 123);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(320, 50);
            lblResult.TabIndex = 5;
            lblResult.Text = "...";
            // 
            // formlinkedlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnShowBackward);
            Controls.Add(btnShowForward);
            Controls.Add(btnBuild);
            Controls.Add(txtImput);
            Name = "formlinkedlist";
            Text = "formlinkedlist";
            Load += formlinkedlist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImput;
        private Button btnBuild;
        private Button btnShowForward;
        private Button btnShowBackward;
        private Label label1;
        private Label lblResult;
    }
}