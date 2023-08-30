namespace Paint_Group_Project
{
    partial class Paint_Group_Project
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cercle1 = new System.Windows.Forms.RadioButton();
            this.Rectangle2 = new System.Windows.Forms.RadioButton();
            this.Square4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2144, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPaintToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(99, 38);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(81, 38);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // newPaintToolStripMenuItem
            // 
            this.newPaintToolStripMenuItem.Name = "newPaintToolStripMenuItem";
            this.newPaintToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.newPaintToolStripMenuItem.Text = "New Paint";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Cercle1
            // 
            this.Cercle1.AutoSize = true;
            this.Cercle1.Location = new System.Drawing.Point(1345, 11);
            this.Cercle1.Name = "Cercle1";
            this.Cercle1.Size = new System.Drawing.Size(105, 29);
            this.Cercle1.TabIndex = 2;
            this.Cercle1.TabStop = true;
            this.Cercle1.Text = "Cercle";
            this.Cercle1.UseVisualStyleBackColor = true;
            // 
            // Rectangle2
            // 
            this.Rectangle2.AutoSize = true;
            this.Rectangle2.Location = new System.Drawing.Point(1504, 11);
            this.Rectangle2.Name = "Rectangle2";
            this.Rectangle2.Size = new System.Drawing.Size(140, 29);
            this.Rectangle2.TabIndex = 3;
            this.Rectangle2.TabStop = true;
            this.Rectangle2.Text = "Rectangle";
            this.Rectangle2.UseVisualStyleBackColor = true;
            // 
            // Square4
            // 
            this.Square4.AutoSize = true;
            this.Square4.Location = new System.Drawing.Point(1690, 11);
            this.Square4.Name = "Square4";
            this.Square4.Size = new System.Drawing.Size(112, 29);
            this.Square4.TabIndex = 5;
            this.Square4.TabStop = true;
            this.Square4.Text = "Square";
            this.Square4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1053, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pen Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paint_Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2144, 1182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Square4);
            this.Controls.Add(this.Rectangle2);
            this.Controls.Add(this.Cercle1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Paint_Group_Project";
            this.Text = "Paint_Group_Project";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_Group_Project_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_Group_Project_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton Cercle1;
        private System.Windows.Forms.RadioButton Rectangle2;
        private System.Windows.Forms.RadioButton Square4;
        private System.Windows.Forms.Button button1;
    }
}

