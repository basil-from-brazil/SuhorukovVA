namespace CapacitorView
{
    partial class CapacitorSearchForm
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
            this.CapacitorsSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.DataSearchCapacitorsView = new System.Windows.Forms.DataGridView();
            this.DielectricPermittivityRadioButton = new System.Windows.Forms.RadioButton();
            this.CapacityRadioButton = new System.Windows.Forms.RadioButton();
            this.CapacitorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchParameterTextBox = new System.Windows.Forms.TextBox();
            this.SearchParameterLabel = new System.Windows.Forms.Label();
            this.SearchCapacitorButton = new System.Windows.Forms.Button();
            this.CloseCapacitorSearchButton = new System.Windows.Forms.Button();
            this.CapacitorsSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchCapacitorsView)).BeginInit();
            this.SuspendLayout();
            // 
            // CapacitorsSearchGroupBox
            // 
            this.CapacitorsSearchGroupBox.Controls.Add(this.DataSearchCapacitorsView);
            this.CapacitorsSearchGroupBox.Location = new System.Drawing.Point(217, 12);
            this.CapacitorsSearchGroupBox.Name = "CapacitorsSearchGroupBox";
            this.CapacitorsSearchGroupBox.Size = new System.Drawing.Size(548, 213);
            this.CapacitorsSearchGroupBox.TabIndex = 1;
            this.CapacitorsSearchGroupBox.TabStop = false;
            this.CapacitorsSearchGroupBox.Text = "Найденные конденсаторы";
            // 
            // DataSearchCapacitorsView
            // 
            this.DataSearchCapacitorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSearchCapacitorsView.Location = new System.Drawing.Point(7, 20);
            this.DataSearchCapacitorsView.Name = "DataSearchCapacitorsView";
            this.DataSearchCapacitorsView.ReadOnly = true;
            this.DataSearchCapacitorsView.RowHeadersVisible = false;
            this.DataSearchCapacitorsView.Size = new System.Drawing.Size(535, 187);
            this.DataSearchCapacitorsView.TabIndex = 0;
            // 
            // DielectricPermittivityRadioButton
            // 
            this.DielectricPermittivityRadioButton.AutoSize = true;
            this.DielectricPermittivityRadioButton.Location = new System.Drawing.Point(13, 12);
            this.DielectricPermittivityRadioButton.Name = "DielectricPermittivityRadioButton";
            this.DielectricPermittivityRadioButton.Size = new System.Drawing.Size(198, 17);
            this.DielectricPermittivityRadioButton.TabIndex = 2;
            this.DielectricPermittivityRadioButton.TabStop = true;
            this.DielectricPermittivityRadioButton.Text = "Диэлектрическая проницаемость";
            this.DielectricPermittivityRadioButton.UseVisualStyleBackColor = true;
            // 
            // CapacityRadioButton
            // 
            this.CapacityRadioButton.AutoSize = true;
            this.CapacityRadioButton.Location = new System.Drawing.Point(13, 36);
            this.CapacityRadioButton.Name = "CapacityRadioButton";
            this.CapacityRadioButton.Size = new System.Drawing.Size(69, 17);
            this.CapacityRadioButton.TabIndex = 3;
            this.CapacityRadioButton.TabStop = true;
            this.CapacityRadioButton.Text = "Емкость";
            this.CapacityRadioButton.UseVisualStyleBackColor = true;
            this.CapacityRadioButton.CheckedChanged += new System.EventHandler(this.CapacityRadioButton_CheckedChanged);
            // 
            // CapacitorTypeRadioButton
            // 
            this.CapacitorTypeRadioButton.AutoSize = true;
            this.CapacitorTypeRadioButton.Location = new System.Drawing.Point(13, 60);
            this.CapacitorTypeRadioButton.Name = "CapacitorTypeRadioButton";
            this.CapacitorTypeRadioButton.Size = new System.Drawing.Size(118, 17);
            this.CapacitorTypeRadioButton.TabIndex = 4;
            this.CapacitorTypeRadioButton.TabStop = true;
            this.CapacitorTypeRadioButton.Text = "Тип конденсатора";
            this.CapacitorTypeRadioButton.UseVisualStyleBackColor = true;
            this.CapacitorTypeRadioButton.CheckedChanged += new System.EventHandler(this.CapacitorTypeRadioButton_CheckedChanged);
            // 
            // SearchParameterTextBox
            // 
            this.SearchParameterTextBox.Location = new System.Drawing.Point(49, 110);
            this.SearchParameterTextBox.Name = "SearchParameterTextBox";
            this.SearchParameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchParameterTextBox.TabIndex = 5;
            // 
            // SearchParameterLabel
            // 
            this.SearchParameterLabel.AutoSize = true;
            this.SearchParameterLabel.Location = new System.Drawing.Point(10, 85);
            this.SearchParameterLabel.Name = "SearchParameterLabel";
            this.SearchParameterLabel.Size = new System.Drawing.Size(191, 13);
            this.SearchParameterLabel.TabIndex = 6;
            this.SearchParameterLabel.Text = "Введите значение и нажмите Поиск";
            // 
            // SearchCapacitorButton
            // 
            this.SearchCapacitorButton.Location = new System.Drawing.Point(13, 195);
            this.SearchCapacitorButton.Name = "SearchCapacitorButton";
            this.SearchCapacitorButton.Size = new System.Drawing.Size(75, 23);
            this.SearchCapacitorButton.TabIndex = 7;
            this.SearchCapacitorButton.Text = "Поиск";
            this.SearchCapacitorButton.UseVisualStyleBackColor = true;
            this.SearchCapacitorButton.Click += new System.EventHandler(this.SearchCapacitorButton_Click);
            // 
            // CloseCapacitorSearchButton
            // 
            this.CloseCapacitorSearchButton.Location = new System.Drawing.Point(119, 195);
            this.CloseCapacitorSearchButton.Name = "CloseCapacitorSearchButton";
            this.CloseCapacitorSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CloseCapacitorSearchButton.TabIndex = 8;
            this.CloseCapacitorSearchButton.Text = "Закрыть";
            this.CloseCapacitorSearchButton.UseVisualStyleBackColor = true;
            this.CloseCapacitorSearchButton.Click += new System.EventHandler(this.CloseCapacitorSearchButton_Click);
            // 
            // CapacitorSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 233);
            this.Controls.Add(this.CloseCapacitorSearchButton);
            this.Controls.Add(this.SearchCapacitorButton);
            this.Controls.Add(this.SearchParameterLabel);
            this.Controls.Add(this.SearchParameterTextBox);
            this.Controls.Add(this.CapacitorTypeRadioButton);
            this.Controls.Add(this.CapacityRadioButton);
            this.Controls.Add(this.DielectricPermittivityRadioButton);
            this.Controls.Add(this.CapacitorsSearchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapacitorSearchForm";
            this.Text = "Поиск конденсаторов";
            this.Load += new System.EventHandler(this.CapacitorSearchForm_Load);
            this.CapacitorsSearchGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchCapacitorsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CapacitorsSearchGroupBox;
        private System.Windows.Forms.DataGridView DataSearchCapacitorsView;
        private System.Windows.Forms.RadioButton DielectricPermittivityRadioButton;
        private System.Windows.Forms.RadioButton CapacityRadioButton;
        private System.Windows.Forms.RadioButton CapacitorTypeRadioButton;
        private System.Windows.Forms.TextBox SearchParameterTextBox;
        private System.Windows.Forms.Label SearchParameterLabel;
        private System.Windows.Forms.Button SearchCapacitorButton;
        private System.Windows.Forms.Button CloseCapacitorSearchButton;
    }
}