namespace IP_FCIS.Forms
{
    partial class AlgebraForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericFraction = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackFraction = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondImage = new System.Windows.Forms.PictureBox();
            this.FirstImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFraction = new System.Windows.Forms.Panel();
            this.dropListImage1 = new System.Windows.Forms.ComboBox();
            this.dropListImage2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dropListOperation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericFraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.panelFraction.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(798, 342);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(798, 313);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericFraction
            // 
            this.numericFraction.DecimalPlaces = 2;
            this.numericFraction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericFraction.Location = new System.Drawing.Point(353, 14);
            this.numericFraction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFraction.Name = "numericFraction";
            this.numericFraction.Size = new System.Drawing.Size(63, 20);
            this.numericFraction.TabIndex = 21;
            this.numericFraction.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericFraction.ValueChanged += new System.EventHandler(this.numericFraction_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fraction";
            // 
            // trackFraction
            // 
            this.trackFraction.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackFraction.LargeChange = 10;
            this.trackFraction.Location = new System.Drawing.Point(69, 14);
            this.trackFraction.Maximum = 100;
            this.trackFraction.Name = "trackFraction";
            this.trackFraction.Size = new System.Drawing.Size(278, 45);
            this.trackFraction.SmallChange = 10;
            this.trackFraction.TabIndex = 17;
            this.trackFraction.TickFrequency = 10;
            this.trackFraction.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFraction.Value = 50;
            this.trackFraction.ValueChanged += new System.EventHandler(this.trackFraction_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Second Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Image";
            // 
            // SecondImage
            // 
            this.SecondImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondImage.Location = new System.Drawing.Point(291, 40);
            this.SecondImage.Name = "SecondImage";
            this.SecondImage.Size = new System.Drawing.Size(250, 250);
            this.SecondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondImage.TabIndex = 14;
            this.SecondImage.TabStop = false;
            // 
            // FirstImage
            // 
            this.FirstImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstImage.Location = new System.Drawing.Point(35, 40);
            this.FirstImage.Name = "FirstImage";
            this.FirstImage.Size = new System.Drawing.Size(250, 250);
            this.FirstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstImage.TabIndex = 13;
            this.FirstImage.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(594, 40);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 25;
            this.pictureBoxResult.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "=>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Result";
            // 
            // panelFraction
            // 
            this.panelFraction.Controls.Add(this.label3);
            this.panelFraction.Controls.Add(this.trackFraction);
            this.panelFraction.Controls.Add(this.numericFraction);
            this.panelFraction.Location = new System.Drawing.Point(291, 305);
            this.panelFraction.Name = "panelFraction";
            this.panelFraction.Size = new System.Drawing.Size(435, 60);
            this.panelFraction.TabIndex = 28;
            this.panelFraction.Visible = false;
            // 
            // dropListImage1
            // 
            this.dropListImage1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropListImage1.FormattingEnabled = true;
            this.dropListImage1.Location = new System.Drawing.Point(135, 16);
            this.dropListImage1.Name = "dropListImage1";
            this.dropListImage1.Size = new System.Drawing.Size(150, 21);
            this.dropListImage1.TabIndex = 29;
            this.dropListImage1.SelectedIndexChanged += new System.EventHandler(this.dropListImage1_SelectedIndexChanged);
            // 
            // dropListImage2
            // 
            this.dropListImage2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropListImage2.FormattingEnabled = true;
            this.dropListImage2.Location = new System.Drawing.Point(391, 16);
            this.dropListImage2.Name = "dropListImage2";
            this.dropListImage2.Size = new System.Drawing.Size(150, 21);
            this.dropListImage2.TabIndex = 30;
            this.dropListImage2.SelectedIndexChanged += new System.EventHandler(this.dropListImage2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Operation";
            // 
            // dropListOperation
            // 
            this.dropListOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropListOperation.FormattingEnabled = true;
            this.dropListOperation.Items.AddRange(new object[] {
            "Add",
            "Subtract"});
            this.dropListOperation.Location = new System.Drawing.Point(110, 318);
            this.dropListOperation.Name = "dropListOperation";
            this.dropListOperation.Size = new System.Drawing.Size(142, 21);
            this.dropListOperation.TabIndex = 32;
            this.dropListOperation.SelectedIndexChanged += new System.EventHandler(this.dropListOperation_SelectedIndexChanged);
            // 
            // AlgebraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 385);
            this.Controls.Add(this.dropListOperation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropListImage2);
            this.Controls.Add(this.dropListImage1);
            this.Controls.Add(this.panelFraction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondImage);
            this.Controls.Add(this.FirstImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlgebraForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Algebra";
            this.Load += new System.EventHandler(this.AlgebraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericFraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.panelFraction.ResumeLayout(false);
            this.panelFraction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericFraction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackFraction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SecondImage;
        private System.Windows.Forms.PictureBox FirstImage;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFraction;
        private System.Windows.Forms.ComboBox dropListImage1;
        private System.Windows.Forms.ComboBox dropListImage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropListOperation;
    }
}