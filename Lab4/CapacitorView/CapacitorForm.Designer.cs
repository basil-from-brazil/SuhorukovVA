namespace CapacitorView
{
    partial class CapacitorForm
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
            this.DielectricPermittivityLabel = new System.Windows.Forms.Label();
            this.DielectricPermittivityTextBox = new System.Windows.Forms.TextBox();
            this.CapacitorTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.SphericalCapacitorRadioButton = new System.Windows.Forms.RadioButton();
            this.CylindricalCapacitorRadioButton = new System.Windows.Forms.RadioButton();
            this.PlateCapacitorRadioButton = new System.Windows.Forms.RadioButton();
            this.PlateAreaTextBox = new System.Windows.Forms.TextBox();
            this.PlateAreaLabel = new System.Windows.Forms.Label();
            this.GapBetweenPlatesTextBox = new System.Windows.Forms.TextBox();
            this.GapBetweenPlatesLabel = new System.Windows.Forms.Label();
            this.HeightOfCylinderLabel = new System.Windows.Forms.Label();
            this.HeightOfCylinderTextBox = new System.Windows.Forms.TextBox();
            this.InterRadiusTextBox = new System.Windows.Forms.TextBox();
            this.InterRadiusLabel = new System.Windows.Forms.Label();
            this.ExterRadiusLabel = new System.Windows.Forms.Label();
            this.ExterRadiusTextBox = new System.Windows.Forms.TextBox();
            this.OKCapacitorButton = new System.Windows.Forms.Button();
            this.CancelCapacitorButton = new System.Windows.Forms.Button();
            this.CapacitorTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DielectricPermittivityLabel
            // 
            this.DielectricPermittivityLabel.AutoSize = true;
            this.DielectricPermittivityLabel.Location = new System.Drawing.Point(21, 11);
            this.DielectricPermittivityLabel.Name = "DielectricPermittivityLabel";
            this.DielectricPermittivityLabel.Size = new System.Drawing.Size(204, 13);
            this.DielectricPermittivityLabel.TabIndex = 1;
            this.DielectricPermittivityLabel.Text = "Диэлектрическая проницаемость, о.е.";
            // 
            // DielectricPermittivityTextBox
            // 
            this.DielectricPermittivityTextBox.Location = new System.Drawing.Point(231, 8);
            this.DielectricPermittivityTextBox.Name = "DielectricPermittivityTextBox";
            this.DielectricPermittivityTextBox.Size = new System.Drawing.Size(100, 20);
            this.DielectricPermittivityTextBox.TabIndex = 2;
            this.DielectricPermittivityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // CapacitorTypeGroupBox
            // 
            this.CapacitorTypeGroupBox.Controls.Add(this.SphericalCapacitorRadioButton);
            this.CapacitorTypeGroupBox.Controls.Add(this.CylindricalCapacitorRadioButton);
            this.CapacitorTypeGroupBox.Controls.Add(this.PlateCapacitorRadioButton);
            this.CapacitorTypeGroupBox.Location = new System.Drawing.Point(24, 28);
            this.CapacitorTypeGroupBox.Name = "CapacitorTypeGroupBox";
            this.CapacitorTypeGroupBox.Size = new System.Drawing.Size(307, 45);
            this.CapacitorTypeGroupBox.TabIndex = 3;
            this.CapacitorTypeGroupBox.TabStop = false;
            this.CapacitorTypeGroupBox.Text = "Тип конденсатора";
            // 
            // SphericalCapacitorRadioButton
            // 
            this.SphericalCapacitorRadioButton.AutoSize = true;
            this.SphericalCapacitorRadioButton.Location = new System.Drawing.Point(208, 19);
            this.SphericalCapacitorRadioButton.Name = "SphericalCapacitorRadioButton";
            this.SphericalCapacitorRadioButton.Size = new System.Drawing.Size(93, 17);
            this.SphericalCapacitorRadioButton.TabIndex = 2;
            this.SphericalCapacitorRadioButton.TabStop = true;
            this.SphericalCapacitorRadioButton.Text = "Сферический";
            this.SphericalCapacitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // CylindricalCapacitorRadioButton
            // 
            this.CylindricalCapacitorRadioButton.AutoSize = true;
            this.CylindricalCapacitorRadioButton.Location = new System.Drawing.Point(91, 19);
            this.CylindricalCapacitorRadioButton.Name = "CylindricalCapacitorRadioButton";
            this.CylindricalCapacitorRadioButton.Size = new System.Drawing.Size(110, 17);
            this.CylindricalCapacitorRadioButton.TabIndex = 1;
            this.CylindricalCapacitorRadioButton.TabStop = true;
            this.CylindricalCapacitorRadioButton.Text = "Цилиндрический";
            this.CylindricalCapacitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlateCapacitorRadioButton
            // 
            this.PlateCapacitorRadioButton.AutoSize = true;
            this.PlateCapacitorRadioButton.Location = new System.Drawing.Point(9, 19);
            this.PlateCapacitorRadioButton.Name = "PlateCapacitorRadioButton";
            this.PlateCapacitorRadioButton.Size = new System.Drawing.Size(69, 17);
            this.PlateCapacitorRadioButton.TabIndex = 0;
            this.PlateCapacitorRadioButton.TabStop = true;
            this.PlateCapacitorRadioButton.Text = "Плоский";
            this.PlateCapacitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlateAreaTextBox
            // 
            this.PlateAreaTextBox.Location = new System.Drawing.Point(8, 106);
            this.PlateAreaTextBox.Name = "PlateAreaTextBox";
            this.PlateAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlateAreaTextBox.TabIndex = 4;
            this.PlateAreaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // PlateAreaLabel
            // 
            this.PlateAreaLabel.AutoSize = true;
            this.PlateAreaLabel.Location = new System.Drawing.Point(16, 74);
            this.PlateAreaLabel.Name = "PlateAreaLabel";
            this.PlateAreaLabel.Size = new System.Drawing.Size(75, 26);
            this.PlateAreaLabel.TabIndex = 5;
            this.PlateAreaLabel.Text = "Площадь\r\nобкладок, м2\r\n";
            this.PlateAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GapBetweenPlatesTextBox
            // 
            this.GapBetweenPlatesTextBox.Location = new System.Drawing.Point(8, 158);
            this.GapBetweenPlatesTextBox.Name = "GapBetweenPlatesTextBox";
            this.GapBetweenPlatesTextBox.Size = new System.Drawing.Size(100, 20);
            this.GapBetweenPlatesTextBox.TabIndex = 6;
            this.GapBetweenPlatesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // GapBetweenPlatesLabel
            // 
            this.GapBetweenPlatesLabel.AutoSize = true;
            this.GapBetweenPlatesLabel.Location = new System.Drawing.Point(17, 129);
            this.GapBetweenPlatesLabel.Name = "GapBetweenPlatesLabel";
            this.GapBetweenPlatesLabel.Size = new System.Drawing.Size(83, 26);
            this.GapBetweenPlatesLabel.TabIndex = 7;
            this.GapBetweenPlatesLabel.Text = "Зазор между\r\nобкладками, м";
            this.GapBetweenPlatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightOfCylinderLabel
            // 
            this.HeightOfCylinderLabel.AutoSize = true;
            this.HeightOfCylinderLabel.Location = new System.Drawing.Point(143, 81);
            this.HeightOfCylinderLabel.Name = "HeightOfCylinderLabel";
            this.HeightOfCylinderLabel.Size = new System.Drawing.Size(59, 13);
            this.HeightOfCylinderLabel.TabIndex = 8;
            this.HeightOfCylinderLabel.Text = "Высота, м";
            // 
            // HeightOfCylinderTextBox
            // 
            this.HeightOfCylinderTextBox.Location = new System.Drawing.Point(125, 106);
            this.HeightOfCylinderTextBox.Name = "HeightOfCylinderTextBox";
            this.HeightOfCylinderTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightOfCylinderTextBox.TabIndex = 9;
            this.HeightOfCylinderTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // InterRadiusTextBox
            // 
            this.InterRadiusTextBox.Location = new System.Drawing.Point(237, 106);
            this.InterRadiusTextBox.Name = "InterRadiusTextBox";
            this.InterRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.InterRadiusTextBox.TabIndex = 10;
            this.InterRadiusTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // InterRadiusLabel
            // 
            this.InterRadiusLabel.AutoSize = true;
            this.InterRadiusLabel.Location = new System.Drawing.Point(230, 82);
            this.InterRadiusLabel.Name = "InterRadiusLabel";
            this.InterRadiusLabel.Size = new System.Drawing.Size(118, 13);
            this.InterRadiusLabel.TabIndex = 11;
            this.InterRadiusLabel.Text = "Внутренний радиус, м";
            // 
            // ExterRadiusLabel
            // 
            this.ExterRadiusLabel.AutoSize = true;
            this.ExterRadiusLabel.Location = new System.Drawing.Point(127, 134);
            this.ExterRadiusLabel.Name = "ExterRadiusLabel";
            this.ExterRadiusLabel.Size = new System.Drawing.Size(104, 13);
            this.ExterRadiusLabel.TabIndex = 12;
            this.ExterRadiusLabel.Text = "Внешний радиус, м";
            // 
            // ExterRadiusTextBox
            // 
            this.ExterRadiusTextBox.Location = new System.Drawing.Point(128, 157);
            this.ExterRadiusTextBox.Name = "ExterRadiusTextBox";
            this.ExterRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExterRadiusTextBox.TabIndex = 13;
            this.ExterRadiusTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // OKCapacitorButton
            // 
            this.OKCapacitorButton.Location = new System.Drawing.Point(182, 188);
            this.OKCapacitorButton.Name = "OKCapacitorButton";
            this.OKCapacitorButton.Size = new System.Drawing.Size(75, 23);
            this.OKCapacitorButton.TabIndex = 14;
            this.OKCapacitorButton.Text = "ОК";
            this.OKCapacitorButton.UseVisualStyleBackColor = true;
            // 
            // CancelCapacitorButton
            // 
            this.CancelCapacitorButton.Location = new System.Drawing.Point(263, 188);
            this.CancelCapacitorButton.Name = "CancelCapacitorButton";
            this.CancelCapacitorButton.Size = new System.Drawing.Size(75, 23);
            this.CancelCapacitorButton.TabIndex = 15;
            this.CancelCapacitorButton.Text = "Отмена";
            this.CancelCapacitorButton.UseVisualStyleBackColor = true;
            // 
            // CapacitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 219);
            this.Controls.Add(this.CancelCapacitorButton);
            this.Controls.Add(this.OKCapacitorButton);
            this.Controls.Add(this.ExterRadiusTextBox);
            this.Controls.Add(this.ExterRadiusLabel);
            this.Controls.Add(this.InterRadiusLabel);
            this.Controls.Add(this.InterRadiusTextBox);
            this.Controls.Add(this.HeightOfCylinderTextBox);
            this.Controls.Add(this.HeightOfCylinderLabel);
            this.Controls.Add(this.GapBetweenPlatesLabel);
            this.Controls.Add(this.GapBetweenPlatesTextBox);
            this.Controls.Add(this.PlateAreaLabel);
            this.Controls.Add(this.PlateAreaTextBox);
            this.Controls.Add(this.CapacitorTypeGroupBox);
            this.Controls.Add(this.DielectricPermittivityTextBox);
            this.Controls.Add(this.DielectricPermittivityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapacitorForm";
            this.Text = "Добавление конденсатора";
            this.CapacitorTypeGroupBox.ResumeLayout(false);
            this.CapacitorTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DielectricPermittivityLabel;
        private System.Windows.Forms.TextBox DielectricPermittivityTextBox;
        private System.Windows.Forms.GroupBox CapacitorTypeGroupBox;
        private System.Windows.Forms.RadioButton PlateCapacitorRadioButton;
        private System.Windows.Forms.RadioButton CylindricalCapacitorRadioButton;
        private System.Windows.Forms.RadioButton SphericalCapacitorRadioButton;
        private System.Windows.Forms.TextBox PlateAreaTextBox;
        private System.Windows.Forms.Label PlateAreaLabel;
        private System.Windows.Forms.TextBox GapBetweenPlatesTextBox;
        private System.Windows.Forms.Label GapBetweenPlatesLabel;
        private System.Windows.Forms.Label HeightOfCylinderLabel;
        private System.Windows.Forms.TextBox HeightOfCylinderTextBox;
        private System.Windows.Forms.TextBox InterRadiusTextBox;
        private System.Windows.Forms.Label InterRadiusLabel;
        private System.Windows.Forms.Label ExterRadiusLabel;
        private System.Windows.Forms.TextBox ExterRadiusTextBox;
        private System.Windows.Forms.Button OKCapacitorButton;
        private System.Windows.Forms.Button CancelCapacitorButton;
    }
}