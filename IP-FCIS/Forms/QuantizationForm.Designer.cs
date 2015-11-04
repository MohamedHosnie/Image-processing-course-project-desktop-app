namespace IP_FCIS.Forms
{
    partial class QuantizationForm
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
            this.reduceButton = new System.Windows.Forms.Button();
            this.reduceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(179, 39);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(75, 23);
            this.reduceButton.TabIndex = 0;
            this.reduceButton.Text = "Reduce";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // reduceText
            // 
            this.reduceText.Location = new System.Drawing.Point(33, 41);
            this.reduceText.Name = "reduceText";
            this.reduceText.Size = new System.Drawing.Size(100, 20);
            this.reduceText.TabIndex = 1;
            // 
            // QuantizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 95);
            this.Controls.Add(this.reduceText);
            this.Controls.Add(this.reduceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuantizationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantization";
            this.Load += new System.EventHandler(this.QuantizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.TextBox reduceText;
    }
}