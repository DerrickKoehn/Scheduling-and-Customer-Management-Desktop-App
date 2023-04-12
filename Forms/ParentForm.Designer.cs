
namespace SoftwareII
{
	partial class ParentForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripUsernameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apptTypeMonthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleByConsultantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.menuStripUsernameTextBox,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "text";
            this.menuStrip.Visible = false;
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // menuStripUsernameTextBox
            // 
            this.menuStripUsernameTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuStripUsernameTextBox.BackColor = System.Drawing.Color.White;
            this.menuStripUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripUsernameTextBox.Name = "menuStripUsernameTextBox";
            this.menuStripUsernameTextBox.ReadOnly = true;
            this.menuStripUsernameTextBox.ShortcutsEnabled = false;
            this.menuStripUsernameTextBox.Size = new System.Drawing.Size(150, 23);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apptTypeMonthMenuItem,
            this.scheduleByConsultantToolStripMenuItem,
            this.customReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // apptTypeMonthMenuItem
            // 
            this.apptTypeMonthMenuItem.Name = "apptTypeMonthMenuItem";
            this.apptTypeMonthMenuItem.Size = new System.Drawing.Size(263, 22);
            this.apptTypeMonthMenuItem.Text = "Appointment Type Count by Month";
            this.apptTypeMonthMenuItem.Click += new System.EventHandler(this.apptTypeMonthMenuItem_Click);
            // 
            // scheduleByConsultantToolStripMenuItem
            // 
            this.scheduleByConsultantToolStripMenuItem.Name = "scheduleByConsultantToolStripMenuItem";
            this.scheduleByConsultantToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.scheduleByConsultantToolStripMenuItem.Text = "Schedule By Consultant";
            this.scheduleByConsultantToolStripMenuItem.Click += new System.EventHandler(this.scheduleByConsultantToolStripMenuItem_Click);
            // 
            // customReportToolStripMenuItem
            // 
            this.customReportToolStripMenuItem.Name = "customReportToolStripMenuItem";
            this.customReportToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.customReportToolStripMenuItem.Text = "Total Login Attempts";
            this.customReportToolStripMenuItem.Click += new System.EventHandler(this.customReportToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ParentForm";
            this.Text = "Scheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox menuStripUsernameTextBox;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apptTypeMonthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleByConsultantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customReportToolStripMenuItem;
    }
}

