namespace IP_FCIS.Forms
{
    partial class TransformationsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.RWidth = new System.Windows.Forms.TextBox();
            this.RHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResizeOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RotateAngle = new System.Windows.Forms.TextBox();
            this.RotateOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShearX = new System.Windows.Forms.TextBox();
            this.ShearOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ShearY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransformOK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ScaleX = new System.Windows.Forms.TextBox();
            this.ScaleOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ScaleY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboInterpolation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // RWidth
            // 
            this.RWidth.Location = new System.Drawing.Point(50, 26);
            this.RWidth.Name = "RWidth";
            this.RWidth.Size = new System.Drawing.Size(64, 20);
            this.RWidth.TabIndex = 0;
            // 
            // RHeight
            // 
            this.RHeight.Location = new System.Drawing.Point(168, 26);
            this.RHeight.Name = "RHeight";
            this.RHeight.Size = new System.Drawing.Size(64, 20);
            this.RHeight.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height:";
            // 
            // ResizeOK
            // 
            this.ResizeOK.Location = new System.Drawing.Point(238, 24);
            this.ResizeOK.Name = "ResizeOK";
            this.ResizeOK.Size = new System.Drawing.Size(75, 23);
            this.ResizeOK.TabIndex = 2;
            this.ResizeOK.Text = "Resize";
            this.ResizeOK.UseVisualStyleBackColor = true;
            this.ResizeOK.Click += new System.EventHandler(this.ResizeOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RWidth);
            this.groupBox1.Controls.Add(this.ResizeOK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resize";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RotateAngle);
            this.groupBox2.Controls.Add(this.RotateOK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotate";
            // 
            // RotateAngle
            // 
            this.RotateAngle.Location = new System.Drawing.Point(168, 29);
            this.RotateAngle.Name = "RotateAngle";
            this.RotateAngle.Size = new System.Drawing.Size(64, 20);
            this.RotateAngle.TabIndex = 9;
            // 
            // RotateOK
            // 
            this.RotateOK.Location = new System.Drawing.Point(238, 27);
            this.RotateOK.Name = "RotateOK";
            this.RotateOK.Size = new System.Drawing.Size(75, 23);
            this.RotateOK.TabIndex = 10;
            this.RotateOK.Text = "Rotate";
            this.RotateOK.UseVisualStyleBackColor = true;
            this.RotateOK.Click += new System.EventHandler(this.RotateOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angle in degrees:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShearX);
            this.groupBox3.Controls.Add(this.ShearOK);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ShearY);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 73);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shear";
            // 
            // ShearX
            // 
            this.ShearX.Location = new System.Drawing.Point(50, 29);
            this.ShearX.Name = "ShearX";
            this.ShearX.Size = new System.Drawing.Size(64, 20);
            this.ShearX.TabIndex = 6;
            // 
            // ShearOK
            // 
            this.ShearOK.Location = new System.Drawing.Point(238, 27);
            this.ShearOK.Name = "ShearOK";
            this.ShearOK.Size = new System.Drawing.Size(75, 23);
            this.ShearOK.TabIndex = 8;
            this.ShearOK.Text = "Shear";
            this.ShearOK.UseVisualStyleBackColor = true;
            this.ShearOK.Click += new System.EventHandler(this.ShearOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X:";
            // 
            // ShearY
            // 
            this.ShearY.Location = new System.Drawing.Point(168, 29);
            this.ShearY.Name = "ShearY";
            this.ShearY.Size = new System.Drawing.Size(64, 20);
            this.ShearY.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y:";
            // 
            // TransformOK
            // 
            this.TransformOK.Location = new System.Drawing.Point(250, 360);
            this.TransformOK.Name = "TransformOK";
            this.TransformOK.Size = new System.Drawing.Size(75, 23);
            this.TransformOK.TabIndex = 11;
            this.TransformOK.Text = "Transform";
            this.TransformOK.UseVisualStyleBackColor = true;
            this.TransformOK.Click += new System.EventHandler(this.TransformOK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(169, 360);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ScaleX);
            this.groupBox4.Controls.Add(this.ScaleOK);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ScaleY);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 73);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scale";
            // 
            // ScaleX
            // 
            this.ScaleX.Location = new System.Drawing.Point(50, 29);
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(64, 20);
            this.ScaleX.TabIndex = 3;
            // 
            // ScaleOK
            // 
            this.ScaleOK.Location = new System.Drawing.Point(238, 27);
            this.ScaleOK.Name = "ScaleOK";
            this.ScaleOK.Size = new System.Drawing.Size(75, 23);
            this.ScaleOK.TabIndex = 5;
            this.ScaleOK.Text = "Scale";
            this.ScaleOK.UseVisualStyleBackColor = true;
            this.ScaleOK.Click += new System.EventHandler(this.ScaleOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X:";
            // 
            // ScaleY
            // 
            this.ScaleY.Location = new System.Drawing.Point(168, 29);
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(64, 20);
            this.ScaleY.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y:";
            // 
            // comboInterpolation
            // 
            this.comboInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterpolation.FormattingEnabled = true;
            this.comboInterpolation.Items.AddRange(new object[] {
            "None",
            "Bilinear"});
            this.comboInterpolation.Location = new System.Drawing.Point(100, 333);
            this.comboInterpolation.Name = "comboInterpolation";
            this.comboInterpolation.Size = new System.Drawing.Size(121, 21);
            this.comboInterpolation.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Interpolation: ";
            // 
            // TransformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(345, 392);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboInterpolation);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TransformOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransformationsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Geometric Transformation";
            this.Load += new System.EventHandler(this.TransformationsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RWidth;
        private System.Windows.Forms.TextBox RHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResizeOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RotateAngle;
        private System.Windows.Forms.Button RotateOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ShearX;
        private System.Windows.Forms.Button ShearOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShearY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TransformOK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ScaleX;
        private System.Windows.Forms.Button ScaleOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ScaleY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboInterpolation;
        private System.Windows.Forms.Label label8;
    }
}