namespace notepad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // MenuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenu
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";

            // File Menu
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.newMenuItem,
                this.saveMenuItem,
                this.viewMenuItem,
                this.exitMenuItem
            });
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Text = "File";

            // New Menu Item
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.NewNote);

            // Save Menu Item
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveNote);

            // View Notes Menu Item
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Text = "View Saved Notes";
            this.viewMenuItem.Click += new System.EventHandler(this.ViewNotes);

            // Exit Menu Item
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler((sender, e) => this.Close());

            // TextBox
            this.textBox.Multiline = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Name = "textBox";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Simple Notepad";
        }
    }
}
