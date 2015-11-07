namespace IP_FCIS.Forms
{
    partial class CustomFilterForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Original = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.filterHeight = new System.Windows.Forms.TextBox();
            this.filterWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterGrid = new System.Windows.Forms.DataGridView();
            this.preview_button = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxpost = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Adjusted";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(341, 40);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 32;
            this.pictureBoxResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Original";
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original.Location = new System.Drawing.Point(35, 40);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(300, 300);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 30;
            this.Original.TabStop = false;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(95, 431);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(55, 22);
            this.enterButton.TabIndex = 34;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterHeight
            // 
            this.filterHeight.Location = new System.Drawing.Point(84, 405);
            this.filterHeight.Name = "filterHeight";
            this.filterHeight.Size = new System.Drawing.Size(66, 20);
            this.filterHeight.TabIndex = 45;
            // 
            // filterWidth
            // 
            this.filterWidth.Location = new System.Drawing.Point(84, 379);
            this.filterWidth.Name = "filterWidth";
            this.filterWidth.Size = new System.Drawing.Size(66, 20);
            this.filterWidth.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Width";
            // 
            // filterGrid
            // 
            this.filterGrid.AllowUserToAddRows = false;
            this.filterGrid.AllowUserToDeleteRows = false;
            this.filterGrid.AllowUserToResizeColumns = false;
            this.filterGrid.AllowUserToResizeRows = false;
            this.filterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.filterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.filterGrid.Location = new System.Drawing.Point(170, 379);
            this.filterGrid.MultiSelect = false;
            this.filterGrid.Name = "filterGrid";
            this.filterGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.filterGrid.Size = new System.Drawing.Size(471, 258);
            this.filterGrid.TabIndex = 0;
            // 
            // preview_button
            // 
            this.preview_button.Location = new System.Drawing.Point(582, 350);
            this.preview_button.Name = "preview_button";
            this.preview_button.Size = new System.Drawing.Size(59, 24);
            this.preview_button.TabIndex = 47;
            this.preview_button.Text = "Preview";
            this.preview_button.UseVisualStyleBackColor = true;
            this.preview_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(582, 643);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(59, 24);
            this.buttonOK.TabIndex = 48;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Post Processing";
            // 
            // comboBoxpost
            // 
            this.comboBoxpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxpost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxpost.FormattingEnabled = true;
            this.comboBoxpost.Items.AddRange(new object[] {
            "None",
            "Cut Off",
            "Normalization",
            "Absolute"});
            this.comboBoxpost.Location = new System.Drawing.Point(35, 592);
            this.comboBoxpost.Name = "comboBoxpost";
            this.comboBoxpost.Size = new System.Drawing.Size(129, 21);
            this.comboBoxpost.TabIndex = 50;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(517, 643);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(59, 24);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // CustomFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(675, 682);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxpost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.filterGrid);
            this.Controls.Add(this.preview_button);
            this.Controls.Add(this.filterHeight);
            this.Controls.Add(this.filterWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomFilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Filter";
            this.Load += new System.EventHandler(this.SharpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox filterHeight;
        private System.Windows.Forms.TextBox filterWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView filterGrid;
        private System.Windows.Forms.Button preview_button;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxpost;
        private System.Windows.Forms.Button buttonCancel;
    }
}