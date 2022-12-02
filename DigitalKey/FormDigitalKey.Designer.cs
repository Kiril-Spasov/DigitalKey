namespace DigitalKey
{
    partial class FormDigitalKey
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
            this.BtnReadDigitalKey = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReadDigitalKey
            // 
            this.BtnReadDigitalKey.Location = new System.Drawing.Point(44, 61);
            this.BtnReadDigitalKey.Name = "BtnReadDigitalKey";
            this.BtnReadDigitalKey.Size = new System.Drawing.Size(171, 54);
            this.BtnReadDigitalKey.TabIndex = 0;
            this.BtnReadDigitalKey.Text = "Read Digital Key";
            this.BtnReadDigitalKey.UseVisualStyleBackColor = true;
            this.BtnReadDigitalKey.Click += new System.EventHandler(this.BtnReadDigitalKey_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(244, 61);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(484, 344);
            this.TxtResult.TabIndex = 1;
            // 
            // FormDigitalKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnReadDigitalKey);
            this.Name = "FormDigitalKey";
            this.Text = "Digital Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReadDigitalKey;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

