namespace CapacitorView
{
    partial class MainForm
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
            this.CapacitorsGroupBox = new System.Windows.Forms.GroupBox();
            this.DataCapacitorsView = new System.Windows.Forms.DataGridView();
            this.AddCapacitorButton = new System.Windows.Forms.Button();
            this.DeleteCapacitorButton = new System.Windows.Forms.Button();
            this.AddRandomCapacitorButton = new System.Windows.Forms.Button();
            this.SearchCapacitorButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadCapacitor = new System.Windows.Forms.Button();
            this.CapacitorsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCapacitorsView)).BeginInit();
            this.SuspendLayout();
            // 
            // CapacitorsGroupBox
            // 
            this.CapacitorsGroupBox.Controls.Add(this.DataCapacitorsView);
            this.CapacitorsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CapacitorsGroupBox.Name = "CapacitorsGroupBox";
            this.CapacitorsGroupBox.Size = new System.Drawing.Size(548, 213);
            this.CapacitorsGroupBox.TabIndex = 0;
            this.CapacitorsGroupBox.TabStop = false;
            this.CapacitorsGroupBox.Text = "Значения диэлектрической проницаемости, емкости и типа конденсатора";
            // 
            // DataCapacitorsView
            // 
            this.DataCapacitorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCapacitorsView.Location = new System.Drawing.Point(7, 20);
            this.DataCapacitorsView.Name = "DataCapacitorsView";
            this.DataCapacitorsView.ReadOnly = true;
            this.DataCapacitorsView.RowHeadersVisible = false;
            this.DataCapacitorsView.Size = new System.Drawing.Size(535, 187);
            this.DataCapacitorsView.TabIndex = 0;
            // 
            // AddCapacitorButton
            // 
            this.AddCapacitorButton.Location = new System.Drawing.Point(13, 233);
            this.AddCapacitorButton.Name = "AddCapacitorButton";
            this.AddCapacitorButton.Size = new System.Drawing.Size(85, 45);
            this.AddCapacitorButton.TabIndex = 1;
            this.AddCapacitorButton.Text = "Добавить конденсатор";
            this.AddCapacitorButton.UseVisualStyleBackColor = true;
            this.AddCapacitorButton.Click += new System.EventHandler(this.AddCapacitorButton_Click);
            // 
            // DeleteCapacitorButton
            // 
            this.DeleteCapacitorButton.Location = new System.Drawing.Point(104, 234);
            this.DeleteCapacitorButton.Name = "DeleteCapacitorButton";
            this.DeleteCapacitorButton.Size = new System.Drawing.Size(85, 45);
            this.DeleteCapacitorButton.TabIndex = 2;
            this.DeleteCapacitorButton.Text = "Удалить конденсатор";
            this.DeleteCapacitorButton.UseVisualStyleBackColor = true;
            this.DeleteCapacitorButton.Click += new System.EventHandler(this.DeleteCapacitorButton_Click);
            // 
            // AddRandomCapacitorButton
            // 
            this.AddRandomCapacitorButton.Location = new System.Drawing.Point(195, 234);
            this.AddRandomCapacitorButton.Name = "AddRandomCapacitorButton";
            this.AddRandomCapacitorButton.Size = new System.Drawing.Size(85, 45);
            this.AddRandomCapacitorButton.TabIndex = 3;
            this.AddRandomCapacitorButton.Text = "Случайный конденсатор";
            this.AddRandomCapacitorButton.UseVisualStyleBackColor = true;
            // 
            // SearchCapacitorButton
            // 
            this.SearchCapacitorButton.Location = new System.Drawing.Point(287, 234);
            this.SearchCapacitorButton.Name = "SearchCapacitorButton";
            this.SearchCapacitorButton.Size = new System.Drawing.Size(90, 45);
            this.SearchCapacitorButton.TabIndex = 4;
            this.SearchCapacitorButton.Text = "Поиск конденсатора";
            this.SearchCapacitorButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(384, 234);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 45);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadCapacitor
            // 
            this.LoadCapacitor.Location = new System.Drawing.Point(476, 234);
            this.LoadCapacitor.Name = "LoadCapacitor";
            this.LoadCapacitor.Size = new System.Drawing.Size(85, 45);
            this.LoadCapacitor.TabIndex = 6;
            this.LoadCapacitor.Text = "Загрузить";
            this.LoadCapacitor.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 290);
            this.Controls.Add(this.LoadCapacitor);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchCapacitorButton);
            this.Controls.Add(this.AddRandomCapacitorButton);
            this.Controls.Add(this.DeleteCapacitorButton);
            this.Controls.Add(this.AddCapacitorButton);
            this.Controls.Add(this.CapacitorsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Виды конденсаторов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CapacitorsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCapacitorsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CapacitorsGroupBox;
        private System.Windows.Forms.DataGridView DataCapacitorsView;
        private System.Windows.Forms.Button AddCapacitorButton;
        private System.Windows.Forms.Button DeleteCapacitorButton;
        private System.Windows.Forms.Button AddRandomCapacitorButton;
        private System.Windows.Forms.Button SearchCapacitorButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadCapacitor;
    }
}

