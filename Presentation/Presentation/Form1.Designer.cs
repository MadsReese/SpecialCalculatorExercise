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
            this.btnCalculate.Location = new System.Drawing.Point(96, 31);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(68, 29);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Button1_ClickAsync);
            // 
            // radioButtonPi
            // 
            this.radioButtonPi.AutoSize = true;
            this.radioButtonPi.Location = new System.Drawing.Point(6, 26);
            this.radioButtonPi.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPi.Name = "radioButtonPi";
            this.radioButtonPi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonPi.TabIndex = 1;
            this.radioButtonPi.TabStop = true;
            this.radioButtonPi.Text = "Pi";
            this.radioButtonPi.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrime
            // 
            this.radioButtonPrime.AutoSize = true;
            this.radioButtonPrime.Location = new System.Drawing.Point(6, 44);
            this.radioButtonPrime.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPrime.Name = "radioButtonPrime";
            this.radioButtonPrime.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPrime.TabIndex = 2;
            this.radioButtonPrime.TabStop = true;
            this.radioButtonPrime.Text = "Prime";
            this.radioButtonPrime.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 7);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(217, 20);
            this.txtInput.TabIndex = 3;
            //this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 95);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radioButtonPrime);
            this.Controls.Add(this.radioButtonPi);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(2);
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