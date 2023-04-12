
namespace SoftwareII.Forms
{
    partial class CustomerForm
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
            this.saveUpdateButton = new System.Windows.Forms.Button();
            this.editingAsLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveUpdateButton
            // 
            this.saveUpdateButton.Location = new System.Drawing.Point(154, 263);
            this.saveUpdateButton.Name = "saveUpdateButton";
            this.saveUpdateButton.Size = new System.Drawing.Size(103, 26);
            this.saveUpdateButton.TabIndex = 8;
            this.saveUpdateButton.Text = "Save";
            this.saveUpdateButton.UseVisualStyleBackColor = true;
            this.saveUpdateButton.Click += new System.EventHandler(this.saveUpdateButton_Click);
            // 
            // editingAsLabel
            // 
            this.editingAsLabel.AutoSize = true;
            this.editingAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editingAsLabel.Location = new System.Drawing.Point(149, 241);
            this.editingAsLabel.Name = "editingAsLabel";
            this.editingAsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editingAsLabel.Size = new System.Drawing.Size(74, 16);
            this.editingAsLabel.TabIndex = 40;
            this.editingAsLabel.Text = "Editing As: ";
            this.editingAsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(89, 219);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneLabel.Size = new System.Drawing.Size(60, 16);
            this.phoneLabel.TabIndex = 35;
            this.phoneLabel.Text = "Phone #:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(152, 218);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(241, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(93, 158);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countryLabel.Size = new System.Drawing.Size(56, 16);
            this.countryLabel.TabIndex = 33;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(152, 157);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(241, 20);
            this.countryTextBox.TabIndex = 5;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeLabel.Location = new System.Drawing.Point(64, 186);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.postalCodeLabel.Size = new System.Drawing.Size(85, 16);
            this.postalCodeLabel.TabIndex = 31;
            this.postalCodeLabel.Text = "Postal Code:";
            this.postalCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(152, 186);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(241, 20);
            this.postalCodeTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(116, 129);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cityLabel.Size = new System.Drawing.Size(33, 16);
            this.cityLabel.TabIndex = 29;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(152, 129);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(241, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLine2Label.Location = new System.Drawing.Point(49, 100);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLine2Label.Size = new System.Drawing.Size(100, 16);
            this.addressLine2Label.TabIndex = 27;
            this.addressLine2Label.Text = "Address Line 2:";
            this.addressLine2Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(87, 69);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressLabel.Size = new System.Drawing.Size(62, 16);
            this.addressLabel.TabIndex = 25;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(152, 68);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(241, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(41, 36);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerNameLabel.Size = new System.Drawing.Size(108, 16);
            this.customerNameLabel.TabIndex = 23;
            this.customerNameLabel.Text = "Customer Name:";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(152, 36);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(241, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(152, 100);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(241, 20);
            this.address2TextBox.TabIndex = 3;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 311);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.saveUpdateButton);
            this.Controls.Add(this.editingAsLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressLine2Label);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "CustomerForm";
            this.Text = "Customer Editor";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveUpdateButton;
        private System.Windows.Forms.Label editingAsLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
    }
}