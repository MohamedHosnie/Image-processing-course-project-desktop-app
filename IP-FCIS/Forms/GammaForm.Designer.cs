namespace IP_FCIS.Forms
{
    partial class GammaForm
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
            this.numericGamma = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackGamma = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adjusted = new System.Windows.Forms.PictureBox();
            this.Original = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adjusted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(495, 348);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(495, 319);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericGamma
            // 
            this.numericGamma.DecimalPlaces = 2;
            this.numericGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericGamma.Location = new System.Drawing.Point(399, 323);
            this.numericGamma.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericGamma.Name = "numericGamma";
            this.numericGamma.Size = new System.Drawing.Size(63, 20);
            this.numericGamma.TabIndex = 21;
            this.numericGamma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGamma.ValueChanged += new System.EventHandler(this.numericGamma_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gamma";
            // 
            // trackGamma
            // 
            this.trackGamma.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackGamma.LargeChange = 1;
            this.trackGamma.Location = new System.Drawing.Point(115, 323);
            this.trackGamma.Maximum = 200;
            this.trackGamma.Minimum = 1;
            this.trackGamma.Name = "trackGamma";
            this.trackGamma.Size = new System.Drawing.Size(278, 45);
            this.trackGamma.TabIndex = 17;
            this.trackGamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackGamma.Value = 100;
            this.trackGamma.ValueChanged += new System.EventHandler(this.trackGamma_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Adjusted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Original";
            // 
            // Adjusted
            // 
            this.Adjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adjusted.Location = new System.Drawing.Point(291, 40);
            this.Adjusted.Name = "Adjusted";
            this.Adjusted.Size = new System.Drawing.Size(250, 250);
            this.Adjusted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adjusted.TabIndex = 14;
            this.Adjusted.TabStop = false;
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original.Location = new System.Drawing.Point(35, 40);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(250, 250);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 13;
            this.Original.TabStop = false;
            // 
            // GammaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(582, 394);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericGamma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackGamma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adjusted);
            this.Controls.Add(this.Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GammaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gamma Correction";
            this.Load += new System.EventHandler(this.GammaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adjusted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericGamma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackGamma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Adjusted;
        private System.Windows.Forms.PictureBox Original;
    }
}