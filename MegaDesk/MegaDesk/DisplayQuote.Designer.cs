namespace MegaDesk
{
    partial class DisplayQuote
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
            this.displayUserQuote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayUserQuote
            // 
            this.displayUserQuote.AutoSize = true;
            this.displayUserQuote.Location = new System.Drawing.Point(197, 80);
            this.displayUserQuote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayUserQuote.Name = "displayUserQuote";
            this.displayUserQuote.Size = new System.Drawing.Size(38, 15);
            this.displayUserQuote.TabIndex = 0;
            this.displayUserQuote.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Order,";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(107, 26);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(0, 15);
            this.customerNameLabel.TabIndex = 2;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayUserQuote);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label displayUserQuote;
        private Label label1;
        private Label customerNameLabel;
    }
}