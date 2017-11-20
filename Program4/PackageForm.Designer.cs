namespace Program4
{
    partial class Program4Form
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.packageDetailsButton = new System.Windows.Forms.Button();
            this.sendToUOfLButton = new System.Windows.Forms.Button();
            this.sendFromUOfLButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originLabel.Location = new System.Drawing.Point(39, 30);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(63, 15);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Zip:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(12, 60);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(90, 15);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination Zip:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(34, 89);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(68, 15);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length (in):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(39, 120);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 15);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width (in):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(35, 150);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(67, 15);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height (in):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(28, 180);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(74, 15);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight (lbs):";
            // 
            // originTextBox
            // 
            this.originTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originTextBox.Location = new System.Drawing.Point(108, 30);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(84, 23);
            this.originTextBox.TabIndex = 6;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationTextBox.Location = new System.Drawing.Point(108, 60);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(84, 23);
            this.destinationTextBox.TabIndex = 7;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTextBox.Location = new System.Drawing.Point(108, 90);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(84, 23);
            this.lengthTextBox.TabIndex = 8;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTextBox.Location = new System.Drawing.Point(108, 120);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(84, 23);
            this.widthTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTextBox.Location = new System.Drawing.Point(108, 150);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(84, 23);
            this.heightTextBox.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(108, 180);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(84, 23);
            this.weightTextBox.TabIndex = 11;
            // 
            // addPackageButton
            // 
            this.addPackageButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPackageButton.Location = new System.Drawing.Point(50, 228);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(142, 32);
            this.addPackageButton.TabIndex = 12;
            this.addPackageButton.Text = "Add Package to List";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.ItemHeight = 15;
            this.packageListBox.Location = new System.Drawing.Point(270, 30);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(128, 184);
            this.packageListBox.TabIndex = 13;
            // 
            // packageDetailsButton
            // 
            this.packageDetailsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageDetailsButton.Location = new System.Drawing.Point(421, 30);
            this.packageDetailsButton.Name = "packageDetailsButton";
            this.packageDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.packageDetailsButton.TabIndex = 14;
            this.packageDetailsButton.Text = "Details";
            this.packageDetailsButton.UseVisualStyleBackColor = true;
            this.packageDetailsButton.Click += new System.EventHandler(this.packageDetailsButton_Click);
            // 
            // sendToUOfLButton
            // 
            this.sendToUOfLButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToUOfLButton.Location = new System.Drawing.Point(421, 90);
            this.sendToUOfLButton.Name = "sendToUOfLButton";
            this.sendToUOfLButton.Size = new System.Drawing.Size(75, 40);
            this.sendToUOfLButton.TabIndex = 15;
            this.sendToUOfLButton.Text = "Send to UofL";
            this.sendToUOfLButton.UseVisualStyleBackColor = true;
            this.sendToUOfLButton.Click += new System.EventHandler(this.sendToUOfLButton_Click);
            // 
            // sendFromUOfLButton
            // 
            this.sendFromUOfLButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFromUOfLButton.Location = new System.Drawing.Point(421, 168);
            this.sendFromUOfLButton.Name = "sendFromUOfLButton";
            this.sendFromUOfLButton.Size = new System.Drawing.Size(75, 40);
            this.sendFromUOfLButton.TabIndex = 16;
            this.sendFromUOfLButton.Text = "Send from UofL";
            this.sendFromUOfLButton.UseVisualStyleBackColor = true;
            this.sendFromUOfLButton.Click += new System.EventHandler(this.sendFromUOfLButton_Click);
            // 
            // Program4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 290);
            this.Controls.Add(this.sendFromUOfLButton);
            this.Controls.Add(this.sendToUOfLButton);
            this.Controls.Add(this.packageDetailsButton);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "Program4Form";
            this.Text = "Brown Parcell Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button packageDetailsButton;
        private System.Windows.Forms.Button sendToUOfLButton;
        private System.Windows.Forms.Button sendFromUOfLButton;
    }
}

