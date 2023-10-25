namespace CC_LabMid_Question3
{
    partial class Question3
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
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneratedPasswordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePasswordButton.Location = new System.Drawing.Point(116, 155);
            this.GeneratePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(108, 46);
            this.GeneratePasswordButton.TabIndex = 0;
            this.GeneratePasswordButton.Text = "Generate";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Generator";
            // 
            // GeneratedPasswordLabel
            // 
            this.GeneratedPasswordLabel.AutoSize = true;
            this.GeneratedPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratedPasswordLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.GeneratedPasswordLabel.Location = new System.Drawing.Point(95, 251);
            this.GeneratedPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GeneratedPasswordLabel.Name = "GeneratedPasswordLabel";
            this.GeneratedPasswordLabel.Size = new System.Drawing.Size(0, 26);
            this.GeneratedPasswordLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ayesha Siddiqua(FA20-BCS-072 )";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(366, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeneratedPasswordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Question3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Question3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GeneratedPasswordLabel;
        private System.Windows.Forms.Label label2;
    }
}

