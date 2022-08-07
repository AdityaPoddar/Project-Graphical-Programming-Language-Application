
namespace ASE_Shape_Programming_language
{
    partial class ShapeProgrammingLanguage
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
            this.figure = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.figure)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figure
            // 
            this.figure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.figure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.figure.Location = new System.Drawing.Point(12, 49);
            this.figure.Name = "figure";
            this.figure.Size = new System.Drawing.Size(522, 495);
            this.figure.TabIndex = 0;
            this.figure.TabStop = false;
            this.figure.Paint += new System.Windows.Forms.PaintEventHandler(this.fig_Paint);
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.instruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instruction.Location = new System.Drawing.Point(554, 49);
            this.instruction.Multiline = true;
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(294, 291);
            this.instruction.TabIndex = 1;
            // 
            // command
            // 
            this.command.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.command.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.command.Location = new System.Drawing.Point(554, 346);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(294, 22);
            this.command.TabIndex = 2;
            this.command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_KeyDown);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DodgerBlue;
            this.button.Location = new System.Drawing.Point(554, 374);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(294, 31);
            this.button.TabIndex = 3;
            this.button.Text = "Run";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.btn_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.output.ForeColor = System.Drawing.Color.Red;
            this.output.Location = new System.Drawing.Point(554, 411);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(294, 133);
            this.output.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // ShapeProgrammingLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(868, 556);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button);
            this.Controls.Add(this.command);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.figure);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShapeProgrammingLanguage";
            this.Text = "Aditya Code Runner";
            ((System.ComponentModel.ISupportInitialize)(this.figure)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox figure;
        private System.Windows.Forms.TextBox instruction;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

