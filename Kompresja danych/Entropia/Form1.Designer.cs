namespace Entropia
{
    partial class WfMainForm
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
            this.wfTextBoxInput = new System.Windows.Forms.TextBox();
            this.wfButtonCalculate = new System.Windows.Forms.Button();
            this.wfTextBoxOutput = new System.Windows.Forms.TextBox();
            this.wfLabelOutput = new System.Windows.Forms.Label();
            this.wfLabelInput = new System.Windows.Forms.Label();
            this.wfButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wfTextBoxInput
            // 
            this.wfTextBoxInput.AllowDrop = true;
            this.wfTextBoxInput.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxInput.Location = new System.Drawing.Point(12, 41);
            this.wfTextBoxInput.Multiline = true;
            this.wfTextBoxInput.Name = "wfTextBoxInput";
            this.wfTextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxInput.Size = new System.Drawing.Size(346, 188);
            this.wfTextBoxInput.TabIndex = 0;
            // 
            // wfButtonCalculate
            // 
            this.wfButtonCalculate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfButtonCalculate.Location = new System.Drawing.Point(261, 243);
            this.wfButtonCalculate.Name = "wfButtonCalculate";
            this.wfButtonCalculate.Size = new System.Drawing.Size(100, 23);
            this.wfButtonCalculate.TabIndex = 1;
            this.wfButtonCalculate.Text = "Calculate";
            this.wfButtonCalculate.UseVisualStyleBackColor = true;
            this.wfButtonCalculate.Click += new System.EventHandler(this.wfButtonCalculate_Click);
            // 
            // wfTextBoxOutput
            // 
            this.wfTextBoxOutput.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxOutput.Location = new System.Drawing.Point(376, 42);
            this.wfTextBoxOutput.Multiline = true;
            this.wfTextBoxOutput.Name = "wfTextBoxOutput";
            this.wfTextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxOutput.Size = new System.Drawing.Size(261, 217);
            this.wfTextBoxOutput.TabIndex = 2;
            // 
            // wfLabelOutput
            // 
            this.wfLabelOutput.AutoSize = true;
            this.wfLabelOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfLabelOutput.Location = new System.Drawing.Point(376, 13);
            this.wfLabelOutput.Name = "wfLabelOutput";
            this.wfLabelOutput.Size = new System.Drawing.Size(49, 15);
            this.wfLabelOutput.TabIndex = 3;
            this.wfLabelOutput.Text = "Output";
            // 
            // wfLabelInput
            // 
            this.wfLabelInput.AutoSize = true;
            this.wfLabelInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfLabelInput.Location = new System.Drawing.Point(12, 13);
            this.wfLabelInput.Name = "wfLabelInput";
            this.wfLabelInput.Size = new System.Drawing.Size(42, 15);
            this.wfLabelInput.TabIndex = 4;
            this.wfLabelInput.Text = "Input";
            // 
            // wfButtonClear
            // 
            this.wfButtonClear.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfButtonClear.Location = new System.Drawing.Point(143, 243);
            this.wfButtonClear.Name = "wfButtonClear";
            this.wfButtonClear.Size = new System.Drawing.Size(100, 23);
            this.wfButtonClear.TabIndex = 5;
            this.wfButtonClear.Text = "Clear";
            this.wfButtonClear.UseVisualStyleBackColor = true;
            this.wfButtonClear.Click += new System.EventHandler(this.wfButtonClear_Click);
            // 
            // WfMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 285);
            this.Controls.Add(this.wfButtonClear);
            this.Controls.Add(this.wfLabelInput);
            this.Controls.Add(this.wfLabelOutput);
            this.Controls.Add(this.wfTextBoxOutput);
            this.Controls.Add(this.wfButtonCalculate);
            this.Controls.Add(this.wfTextBoxInput);
            this.Name = "WfMainForm";
            this.Text = "Entropy calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wfTextBoxInput;
        private System.Windows.Forms.Button wfButtonCalculate;
		private System.Windows.Forms.TextBox wfTextBoxOutput;
        private System.Windows.Forms.Label wfLabelOutput;
        private System.Windows.Forms.Label wfLabelInput;
        private System.Windows.Forms.Button wfButtonClear;
        }
}

