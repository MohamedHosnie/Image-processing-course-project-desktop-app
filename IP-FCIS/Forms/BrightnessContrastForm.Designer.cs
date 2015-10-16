namespace IP_FCIS.Forms
{
    partial class BrightnessContrastForm
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
            this.Original = new System.Windows.Forms.PictureBox();
            this.Adjusted = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackContrast = new System.Windows.Forms.TrackBar();
            this.numericBrightness = new System.Windows.Forms.NumericUpDown();
            this.numericContrast = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adjusted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original.Location = new System.Drawing.Point(35, 40);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(250, 250);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 0;
            this.Original.TabStop = false;
            // 
            // Adjusted
            // 
            this.Adjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adjusted.Location = new System.Drawing.Point(291, 40);
            this.Adjusted.Name = "Adjusted";
            this.Adjusted.Size = new System.Drawing.Size(250, 250);
            this.Adjusted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adjusted.TabIndex = 1;
            this.Adjusted.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adjusted";
            // 
            // trackBrightness
            // 
            this.trackBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBrightness.LargeChange = 20;
            this.trackBrightness.Location = new System.Drawing.Point(115, 317);
            this.trackBrightness.Maximum = 150;
            this.trackBrightness.Minimum = -150;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.Size = new System.Drawing.Size(278, 45);
            this.trackBrightness.SmallChange = 5;
            this.trackBrightness.TabIndex = 4;
            this.trackBrightness.TickFrequency = 5;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBrightness.ValueChanged += new System.EventHandler(this.trackBrightness_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contrast";
            // 
            // trackContrast
            // 
            this.trackContrast.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackContrast.LargeChange = 15;
            this.trackContrast.Location = new System.Drawing.Point(115, 369);
            this.trackContrast.Maximum = 100;
            this.trackContrast.Minimum = -100;
            this.trackContrast.Name = "trackContrast";
            this.trackContrast.Size = new System.Drawing.Size(278, 45);
            this.trackContrast.SmallChange = 5;
            this.trackContrast.TabIndex = 7;
            this.trackContrast.TickFrequency = 5;
            this.trackContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackContrast.ValueChanged += new System.EventHandler(this.trackContrast_ValueChanged);
            // 
            // numericBrightness
            // 
            this.numericBrightness.Location = new System.Drawing.Point(399, 317);
            this.numericBrightness.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericBrightness.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            -2147483648});
            this.numericBrightness.Name = "numericBrightness";
            this.numericBrightness.Size = new System.Drawing.Size(63, 20);
            this.numericBrightness.TabIndex = 8;
            this.numericBrightness.ValueChanged += new System.EventHandler(this.numericBrightness_ValueChanged);
            // 
            // numericContrast
            // 
            this.numericContrast.Location = new System.Drawing.Point(399, 369);
            this.numericContrast.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericContrast.Name = "numericContrast";
            this.numericContrast.Size = new System.Drawing.Size(63, 20);
            this.numericContrast.TabIndex = 9;
            this.numericContrast.ValueChanged += new System.EventHandler(this.numericContrast_ValueChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(495, 337);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(495, 366);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BrightnessContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(582, 417);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericContrast);
            this.Controls.Add(this.numericBrightness);
            this.Controls.Add(this.trackContrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adjusted);
            this.Controls.Add(this.Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrightnessContrastForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brightness/Contrast";
            this.Load += new System.EventHandler(this.BrightnessContrastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adjusted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.PictureBox Adjusted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackContrast;
        private System.Windows.Forms.NumericUpDown numericBrightness;
        private System.Windows.Forms.NumericUpDown numericContrast;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}