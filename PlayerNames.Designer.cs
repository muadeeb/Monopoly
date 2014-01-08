namespace Monopoly
{
    partial class PlayerNames
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Radio2);
            this.panel1.Controls.Add(this.Radio1);
            this.panel1.Location = new System.Drawing.Point(38, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 22);
            this.panel1.TabIndex = 0;
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.Location = new System.Drawing.Point(3, 3);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(17, 16);
            this.Radio1.TabIndex = 0;
            this.Radio1.TabStop = true;
            this.Radio1.UseVisualStyleBackColor = true;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.Location = new System.Drawing.Point(89, 3);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(17, 16);
            this.Radio2.TabIndex = 1;
            this.Radio2.TabStop = true;
            this.Radio2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Human";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 3;
            // 
            // PlayerNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 241);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerNames";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Enter Player Names";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PlayerNames_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}