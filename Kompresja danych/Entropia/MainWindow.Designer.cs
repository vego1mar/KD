namespace Entropia
{
    partial class MainWindow
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
			this.wfMainWindowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.wfMainWindowTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// wfTextBoxInput
			// 
			this.wfTextBoxInput.AllowDrop = true;
			this.wfTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxInput.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxInput.Location = new System.Drawing.Point(3, 23);
			this.wfTextBoxInput.Multiline = true;
			this.wfTextBoxInput.Name = "wfTextBoxInput";
			this.wfTextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxInput.Size = new System.Drawing.Size(376, 279);
			this.wfTextBoxInput.TabIndex = 0;
			// 
			// wfButtonCalculate
			// 
			this.wfButtonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfButtonCalculate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfButtonCalculate.Location = new System.Drawing.Point(3, 308);
			this.wfButtonCalculate.Name = "wfButtonCalculate";
			this.wfButtonCalculate.Size = new System.Drawing.Size(376, 24);
			this.wfButtonCalculate.TabIndex = 1;
			this.wfButtonCalculate.Text = "Calculate";
			this.wfButtonCalculate.UseVisualStyleBackColor = true;
			this.wfButtonCalculate.Click += new System.EventHandler(this.WfButtonCalculate_Click);
			// 
			// wfTextBoxOutput
			// 
			this.wfTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxOutput.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxOutput.Location = new System.Drawing.Point(385, 23);
			this.wfTextBoxOutput.Multiline = true;
			this.wfTextBoxOutput.Name = "wfTextBoxOutput";
			this.wfTextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxOutput.Size = new System.Drawing.Size(376, 279);
			this.wfTextBoxOutput.TabIndex = 2;
			// 
			// wfLabelOutput
			// 
			this.wfLabelOutput.AutoSize = true;
			this.wfLabelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfLabelOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfLabelOutput.Location = new System.Drawing.Point(385, 0);
			this.wfLabelOutput.Name = "wfLabelOutput";
			this.wfLabelOutput.Size = new System.Drawing.Size(376, 20);
			this.wfLabelOutput.TabIndex = 3;
			this.wfLabelOutput.Text = "Output";
			// 
			// wfLabelInput
			// 
			this.wfLabelInput.AutoSize = true;
			this.wfLabelInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfLabelInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfLabelInput.Location = new System.Drawing.Point(3, 0);
			this.wfLabelInput.Name = "wfLabelInput";
			this.wfLabelInput.Size = new System.Drawing.Size(376, 20);
			this.wfLabelInput.TabIndex = 4;
			this.wfLabelInput.Text = "Input";
			// 
			// wfButtonClear
			// 
			this.wfButtonClear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfButtonClear.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfButtonClear.Location = new System.Drawing.Point(385, 308);
			this.wfButtonClear.Name = "wfButtonClear";
			this.wfButtonClear.Size = new System.Drawing.Size(376, 24);
			this.wfButtonClear.TabIndex = 5;
			this.wfButtonClear.Text = "Clear";
			this.wfButtonClear.UseVisualStyleBackColor = true;
			this.wfButtonClear.Click += new System.EventHandler(this.WfButtonClear_Click);
			// 
			// wfMainWindowTableLayoutPanel
			// 
			this.wfMainWindowTableLayoutPanel.ColumnCount = 2;
			this.wfMainWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxInput, 0, 1);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfButtonClear, 1, 2);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfLabelInput, 0, 0);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfButtonCalculate, 0, 2);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxOutput, 1, 1);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfLabelOutput, 1, 0);
			this.wfMainWindowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfMainWindowTableLayoutPanel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfMainWindowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.wfMainWindowTableLayoutPanel.Name = "wfMainWindowTableLayoutPanel";
			this.wfMainWindowTableLayoutPanel.RowCount = 3;
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.wfMainWindowTableLayoutPanel.Size = new System.Drawing.Size(764, 335);
			this.wfMainWindowTableLayoutPanel.TabIndex = 6;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 335);
			this.Controls.Add(this.wfMainWindowTableLayoutPanel);
			this.Name = "MainWindow";
			this.Text = "Entropy calculator";
			this.wfMainWindowTableLayoutPanel.ResumeLayout(false);
			this.wfMainWindowTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wfTextBoxInput;
        private System.Windows.Forms.Button wfButtonCalculate;
		private System.Windows.Forms.TextBox wfTextBoxOutput;
        private System.Windows.Forms.Label wfLabelOutput;
        private System.Windows.Forms.Label wfLabelInput;
        private System.Windows.Forms.Button wfButtonClear;
		private System.Windows.Forms.TableLayoutPanel wfMainWindowTableLayoutPanel;
	}
}

