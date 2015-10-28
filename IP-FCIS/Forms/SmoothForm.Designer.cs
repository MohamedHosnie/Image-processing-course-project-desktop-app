namespace IP_FCIS.Forms
{
    partial class SmoothForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dropListOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MeanPanel = new System.Windows.Forms.Panel();
            this.meanSmooth = new System.Windows.Forms.Button();
            this.meanOriginy = new System.Windows.Forms.TextBox();
            this.meanOrigix = new System.Windows.Forms.TextBox();
            this.meanHeight = new System.Windows.Forms.TextBox();
            this.meanWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gaussianPanel = new System.Windows.Forms.Panel();
            this.guassianButton = new System.Windows.Forms.Button();
            this.gaussianSize = new System.Windows.Forms.TextBox();
            this.sigma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.MeanPanel.SuspendLayout();
            this.gaussianPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Original.Location = new System.Drawing.Point(35, 40);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(250, 250);
            this.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Original.TabIndex = 14;
            this.Original.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Original";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(291, 40);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 28;
            this.pictureBoxResult.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Adjusted";
            // 
            // dropListOperation
            // 
            this.dropListOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropListOperation.FormattingEnabled = true;
            this.dropListOperation.Items.AddRange(new object[] {
            "Mean Filter",
            "Gaussian Filter "});
            this.dropListOperation.Location = new System.Drawing.Point(87, 308);
            this.dropListOperation.Name = "dropListOperation";
            this.dropListOperation.Size = new System.Drawing.Size(122, 21);
            this.dropListOperation.TabIndex = 33;
            this.dropListOperation.SelectedIndexChanged += new System.EventHandler(this.dropListOperation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mask";
            // 
            // MeanPanel
            // 
            this.MeanPanel.Controls.Add(this.meanSmooth);
            this.MeanPanel.Controls.Add(this.meanOriginy);
            this.MeanPanel.Controls.Add(this.meanOrigix);
            this.MeanPanel.Controls.Add(this.meanHeight);
            this.MeanPanel.Controls.Add(this.meanWidth);
            this.MeanPanel.Controls.Add(this.label8);
            this.MeanPanel.Controls.Add(this.label7);
            this.MeanPanel.Controls.Add(this.label3);
            this.MeanPanel.Controls.Add(this.label2);
            this.MeanPanel.Location = new System.Drawing.Point(225, 316);
            this.MeanPanel.Name = "MeanPanel";
            this.MeanPanel.Size = new System.Drawing.Size(328, 109);
            this.MeanPanel.TabIndex = 35;
            this.MeanPanel.Visible = false;
            // 
            // meanSmooth
            // 
            this.meanSmooth.Location = new System.Drawing.Point(233, 83);
            this.meanSmooth.Name = "meanSmooth";
            this.meanSmooth.Size = new System.Drawing.Size(75, 23);
            this.meanSmooth.TabIndex = 37;
            this.meanSmooth.Text = "Blur";
            this.meanSmooth.UseVisualStyleBackColor = true;
            this.meanSmooth.Click += new System.EventHandler(this.meanSmooth_Click);
            // 
            // meanOriginy
            // 
            this.meanOriginy.Location = new System.Drawing.Point(240, 50);
            this.meanOriginy.Name = "meanOriginy";
            this.meanOriginy.Size = new System.Drawing.Size(68, 20);
            this.meanOriginy.TabIndex = 43;
            // 
            // meanOrigix
            // 
            this.meanOrigix.Location = new System.Drawing.Point(78, 47);
            this.meanOrigix.Name = "meanOrigix";
            this.meanOrigix.Size = new System.Drawing.Size(66, 20);
            this.meanOrigix.TabIndex = 42;
            // 
            // meanHeight
            // 
            this.meanHeight.Location = new System.Drawing.Point(240, 9);
            this.meanHeight.Name = "meanHeight";
            this.meanHeight.Size = new System.Drawing.Size(68, 20);
            this.meanHeight.TabIndex = 41;
            // 
            // meanWidth
            // 
            this.meanWidth.Location = new System.Drawing.Point(78, 9);
            this.meanWidth.Name = "meanWidth";
            this.meanWidth.Size = new System.Drawing.Size(66, 20);
            this.meanWidth.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "OriginalY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "OriginalX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Width";
            // 
            // gaussianPanel
            // 
            this.gaussianPanel.Controls.Add(this.guassianButton);
            this.gaussianPanel.Controls.Add(this.gaussianSize);
            this.gaussianPanel.Controls.Add(this.sigma);
            this.gaussianPanel.Controls.Add(this.label10);
            this.gaussianPanel.Controls.Add(this.label9);
            this.gaussianPanel.Location = new System.Drawing.Point(284, 316);
            this.gaussianPanel.Name = "gaussianPanel";
            this.gaussianPanel.Size = new System.Drawing.Size(269, 122);
            this.gaussianPanel.TabIndex = 36;
            this.gaussianPanel.Visible = false;
            // 
            // guassianButton
            // 
            this.guassianButton.Location = new System.Drawing.Point(174, 83);
            this.guassianButton.Name = "guassianButton";
            this.guassianButton.Size = new System.Drawing.Size(75, 23);
            this.guassianButton.TabIndex = 21;
            this.guassianButton.Text = "Blur";
            this.guassianButton.UseVisualStyleBackColor = true;
            this.guassianButton.Click += new System.EventHandler(this.guassianButton_Click);
            // 
            // gaussianSize
            // 
            this.gaussianSize.Location = new System.Drawing.Point(82, 46);
            this.gaussianSize.Name = "gaussianSize";
            this.gaussianSize.Size = new System.Drawing.Size(100, 20);
            this.gaussianSize.TabIndex = 20;
            // 
            // sigma
            // 
            this.sigma.Location = new System.Drawing.Point(82, 9);
            this.sigma.Name = "sigma";
            this.sigma.Size = new System.Drawing.Size(100, 20);
            this.sigma.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mask Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sigma ";
            // 
            // SmoothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.gaussianPanel);
            this.Controls.Add(this.MeanPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropListOperation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmoothForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smoothing";
            this.Load += new System.EventHandler(this.SmoothForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.MeanPanel.ResumeLayout(false);
            this.MeanPanel.PerformLayout();
            this.gaussianPanel.ResumeLayout(false);
            this.gaussianPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Original;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropListOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MeanPanel;
        private System.Windows.Forms.TextBox meanHeight;
        private System.Windows.Forms.TextBox meanWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meanOriginy;
        private System.Windows.Forms.TextBox meanOrigix;
        private System.Windows.Forms.Panel gaussianPanel;
        private System.Windows.Forms.Button guassianButton;
        private System.Windows.Forms.TextBox gaussianSize;
        private System.Windows.Forms.TextBox sigma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button meanSmooth;
    }
}