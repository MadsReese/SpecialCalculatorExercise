namespace Presentation
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radioButtonPi = new System.Windows.Forms.RadioButton();
            this.radioButtonPrime = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(193, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 55);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButtonPi
            // 
            this.radioButtonPi.AutoSize = true;
            this.radioButtonPi.Location = new System.Drawing.Point(12, 50);
            this.radioButtonPi.Name = "radioButtonPi";
            this.radioButtonPi.Size = new System.Drawing.Size(62, 29);
            this.radioButtonPi.TabIndex = 1;
            this.radioButtonPi.TabStop = true;
            this.radioButtonPi.Text = "Pi";
            this.radioButtonPi.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrime
            // 
            this.radioButtonPrime.AutoSize = true;
            this.radioButtonPrime.Location = new System.Drawing.Point(12, 85);
            this.radioButtonPrime.Name = "radioButtonPrime";
            this.radioButtonPrime.Size = new System.Drawing.Size(98, 29);
            this.radioButtonPrime.TabIndex = 2;
            this.radioButtonPrime.TabStop = true;
            this.radioButtonPrime.Text = "Prime";
            this.radioButtonPrime.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(430, 31);
            this.txtInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 183);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radioButtonPrime);
            this.Controls.Add(this.radioButtonPi);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radioButtonPi;
        private System.Windows.Forms.RadioButton radioButtonPrime;
        private System.Windows.Forms.TextBox txtInput;
    }
}

