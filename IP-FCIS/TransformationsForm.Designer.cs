namespace IP_FCIS
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
            this.ScaleX = new System.Windows.Forms.TextBox();
            this.ScaleY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ScaleOK = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            // 
            // ScaleX
            // 
            this.ScaleX.Location = new System.Drawing.Point(30, 29);
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(85, 20);
            this.ScaleX.TabIndex = 0;
            // 
            // ScaleY
            // 
            this.ScaleY.Location = new System.Drawing.Point(141, 29);
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(80, 20);
            this.ScaleY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // ScaleOK
            // 
            this.ScaleOK.Location = new System.Drawing.Point(234, 27);
            this.ScaleOK.Name = "ScaleOK";
            this.ScaleOK.Size = new System.Drawing.Size(75, 23);
            this.ScaleOK.TabIndex = 2;
            this.ScaleOK.Text = "Scale";
            this.ScaleOK.UseVisualStyleBackColor = true;
            this.ScaleOK.Click += new System.EventHandler(this.ScaleOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScaleX);
            this.groupBox1.Controls.Add(this.ScaleOK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ScaleY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RotateAngle);
            this.groupBox2.Controls.Add(this.RotateOK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotate";
            // 
            // RotateAngle
            // 
            this.RotateAngle.Location = new System.Drawing.Point(51, 29);
            this.RotateAngle.Name = "RotateAngle";
            this.RotateAngle.Size = new System.Drawing.Size(170, 20);
            this.RotateAngle.TabIndex = 3;
            // 
            // RotateOK
            // 
            this.RotateOK.Location = new System.Drawing.Point(234, 27);
            this.RotateOK.Name = "RotateOK";
            this.RotateOK.Size = new System.Drawing.Size(75, 23);
            this.RotateOK.TabIndex = 4;
            this.RotateOK.Text = "Rotate";
            this.RotateOK.UseVisualStyleBackColor = true;
            this.RotateOK.Click += new System.EventHandler(this.RotateOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angle:";
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
            this.ShearX.Location = new System.Drawing.Point(30, 29);
            this.ShearX.Name = "ShearX";
            this.ShearX.Size = new System.Drawing.Size(85, 20);
            this.ShearX.TabIndex = 5;
            // 
            // ShearOK
            // 
            this.ShearOK.Location = new System.Drawing.Point(234, 27);
            this.ShearOK.Name = "ShearOK";
            this.ShearOK.Size = new System.Drawing.Size(75, 23);
            this.ShearOK.TabIndex = 7;
            this.ShearOK.Text = "Shear";
            this.ShearOK.UseVisualStyleBackColor = true;
            this.ShearOK.Click += new System.EventHandler(this.ShearOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X:";
            // 
            // ShearY
            // 
            this.ShearY.Location = new System.Drawing.Point(141, 29);
            this.ShearY.Name = "ShearY";
            this.ShearY.Size = new System.Drawing.Size(80, 20);
            this.ShearY.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y:";
            // 
            // TransformOK
            // 
            this.TransformOK.Location = new System.Drawing.Point(177, 249);
            this.TransformOK.Name = "TransformOK";
            this.TransformOK.Size = new System.Drawing.Size(75, 23);
            this.TransformOK.TabIndex = 8;
            this.TransformOK.Text = "Transform";
            this.TransformOK.UseVisualStyleBackColor = true;
            this.TransformOK.Click += new System.EventHandler(this.TransformOK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(258, 249);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // TransformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(345, 279);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScaleX;
        private System.Windows.Forms.TextBox ScaleY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ScaleOK;
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
    }
}