
namespace SoftwareII.Forms
{
    partial class AppointmentForm
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
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.editingAsLabel = new System.Windows.Forms.Label();
            this.saveUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.customerBindingSource2;
            this.customerComboBox.DisplayMember = "CustomerName";
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(153, 32);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(241, 21);
            this.customerComboBox.TabIndex = 0;
            this.customerComboBox.ValueMember = "CustomerId";
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = typeof(SoftwareII.Classes.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SoftwareII.Classes.Customer);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(SoftwareII.Classes.Appointment);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(SoftwareII.Classes.Customer);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(79, 33);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerLabel.Size = new System.Drawing.Size(68, 16);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer:";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(153, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(241, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(32, 68);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLabel.Size = new System.Drawing.Size(115, 16);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Appointment Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(153, 95);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(241, 74);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(71, 96);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionLabel.Size = new System.Drawing.Size(79, 16);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(85, 181);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationLabel.Size = new System.Drawing.Size(62, 16);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(153, 180);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(241, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(91, 215);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactLabel.Size = new System.Drawing.Size(56, 16);
            this.contactLabel.TabIndex = 9;
            this.contactLabel.Text = "Contact:";
            this.contactLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(153, 211);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(241, 20);
            this.contactTextBox.TabIndex = 8;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(104, 244);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeLabel.Size = new System.Drawing.Size(43, 16);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(153, 240);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(241, 20);
            this.typeTextBox.TabIndex = 10;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(109, 267);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.urlLabel.Size = new System.Drawing.Size(38, 16);
            this.urlLabel.TabIndex = 13;
            this.urlLabel.Text = "URL:";
            this.urlLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(153, 266);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(241, 20);
            this.urlTextBox.TabIndex = 12;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(75, 295);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startTimeLabel.Size = new System.Drawing.Size(72, 16);
            this.startTimeLabel.TabIndex = 14;
            this.startTimeLabel.Text = "Start Time:";
            this.startTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(153, 295);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(241, 20);
            this.startTimePicker.TabIndex = 16;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(153, 323);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(241, 20);
            this.endTimePicker.TabIndex = 19;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(75, 323);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endTimeLabel.Size = new System.Drawing.Size(69, 16);
            this.endTimeLabel.TabIndex = 17;
            this.endTimeLabel.Text = "End Time:";
            this.endTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editingAsLabel
            // 
            this.editingAsLabel.AutoSize = true;
            this.editingAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editingAsLabel.Location = new System.Drawing.Point(150, 346);
            this.editingAsLabel.Name = "editingAsLabel";
            this.editingAsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editingAsLabel.Size = new System.Drawing.Size(74, 16);
            this.editingAsLabel.TabIndex = 20;
            this.editingAsLabel.Text = "Editing As: ";
            this.editingAsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(155, 368);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(103, 26);
            this.saveUpdateButton.TabIndex = 21;
            this.saveUpdateButton.Text = "Save";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.editingAsLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customerComboBox);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Editor";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label editingAsLabel;
        private System.Windows.Forms.Button saveUpdateButton;
    }
}