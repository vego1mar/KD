namespace UnaryCoding
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
			this.wfLabelCoder = new System.Windows.Forms.Label();
			this.wfTextBoxCoderInput = new System.Windows.Forms.TextBox();
			this.wfTextBoxCoderOutput = new System.Windows.Forms.TextBox();
			this.wfTextBoxDecoderOutput = new System.Windows.Forms.TextBox();
			this.wfTextBoxDecoderInput = new System.Windows.Forms.TextBox();
			this.wfLabelDecoder = new System.Windows.Forms.Label();
			this.wfButtonDecode = new System.Windows.Forms.Button();
			this.wfMainWindowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.wfDecoderFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.wfMainWindowTableLayoutPanel.SuspendLayout();
			this.wfDecoderFlowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// wfLabelCoder
			// 
			this.wfLabelCoder.AutoSize = true;
			this.wfLabelCoder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfLabelCoder.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfLabelCoder.Location = new System.Drawing.Point(3, 0);
			this.wfLabelCoder.Name = "wfLabelCoder";
			this.wfLabelCoder.Size = new System.Drawing.Size(313, 40);
			this.wfLabelCoder.TabIndex = 0;
			this.wfLabelCoder.Text = "Coder";
			// 
			// wfTextBoxCoderInput
			// 
			this.wfTextBoxCoderInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxCoderInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxCoderInput.Location = new System.Drawing.Point(3, 43);
			this.wfTextBoxCoderInput.Multiline = true;
			this.wfTextBoxCoderInput.Name = "wfTextBoxCoderInput";
			this.wfTextBoxCoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxCoderInput.Size = new System.Drawing.Size(313, 144);
			this.wfTextBoxCoderInput.TabIndex = 1;
			this.wfTextBoxCoderInput.TextChanged += new System.EventHandler(this.WfTextBoxCoderInput_TextChanged);
			// 
			// wfTextBoxCoderOutput
			// 
			this.wfTextBoxCoderOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxCoderOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxCoderOutput.Location = new System.Drawing.Point(3, 203);
			this.wfTextBoxCoderOutput.Multiline = true;
			this.wfTextBoxCoderOutput.Name = "wfTextBoxCoderOutput";
			this.wfTextBoxCoderOutput.ReadOnly = true;
			this.wfTextBoxCoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxCoderOutput.Size = new System.Drawing.Size(313, 145);
			this.wfTextBoxCoderOutput.TabIndex = 2;
			// 
			// wfTextBoxDecoderOutput
			// 
			this.wfTextBoxDecoderOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxDecoderOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxDecoderOutput.Location = new System.Drawing.Point(322, 203);
			this.wfTextBoxDecoderOutput.Multiline = true;
			this.wfTextBoxDecoderOutput.Name = "wfTextBoxDecoderOutput";
			this.wfTextBoxDecoderOutput.ReadOnly = true;
			this.wfTextBoxDecoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxDecoderOutput.Size = new System.Drawing.Size(313, 145);
			this.wfTextBoxDecoderOutput.TabIndex = 5;
			// 
			// wfTextBoxDecoderInput
			// 
			this.wfTextBoxDecoderInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfTextBoxDecoderInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfTextBoxDecoderInput.Location = new System.Drawing.Point(322, 43);
			this.wfTextBoxDecoderInput.Multiline = true;
			this.wfTextBoxDecoderInput.Name = "wfTextBoxDecoderInput";
			this.wfTextBoxDecoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.wfTextBoxDecoderInput.Size = new System.Drawing.Size(313, 144);
			this.wfTextBoxDecoderInput.TabIndex = 4;
			// 
			// wfLabelDecoder
			// 
			this.wfLabelDecoder.AutoSize = true;
			this.wfLabelDecoder.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfLabelDecoder.Location = new System.Drawing.Point(13, 0);
			this.wfLabelDecoder.Name = "wfLabelDecoder";
			this.wfLabelDecoder.Size = new System.Drawing.Size(64, 17);
			this.wfLabelDecoder.TabIndex = 3;
			this.wfLabelDecoder.Text = "Decoder";
			// 
			// wfButtonDecode
			// 
			this.wfButtonDecode.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wfButtonDecode.Location = new System.Drawing.Point(83, 3);
			this.wfButtonDecode.Name = "wfButtonDecode";
			this.wfButtonDecode.Size = new System.Drawing.Size(103, 23);
			this.wfButtonDecode.TabIndex = 6;
			this.wfButtonDecode.Text = "Decode";
			this.wfButtonDecode.UseVisualStyleBackColor = true;
			this.wfButtonDecode.Click += new System.EventHandler(this.WfButtonDecode_Click);
			// 
			// wfMainWindowTableLayoutPanel
			// 
			this.wfMainWindowTableLayoutPanel.ColumnCount = 2;
			this.wfMainWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfDecoderFlowLayoutPanel, 1, 0);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfLabelCoder, 0, 0);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxCoderInput, 0, 1);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxDecoderInput, 1, 1);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxDecoderOutput, 1, 3);
			this.wfMainWindowTableLayoutPanel.Controls.Add(this.wfTextBoxCoderOutput, 0, 3);
			this.wfMainWindowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfMainWindowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.wfMainWindowTableLayoutPanel.Name = "wfMainWindowTableLayoutPanel";
			this.wfMainWindowTableLayoutPanel.RowCount = 4;
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.wfMainWindowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.wfMainWindowTableLayoutPanel.Size = new System.Drawing.Size(638, 351);
			this.wfMainWindowTableLayoutPanel.TabIndex = 7;
			// 
			// wfDecoderFlowLayoutPanel
			// 
			this.wfDecoderFlowLayoutPanel.Controls.Add(this.wfLabelDecoder);
			this.wfDecoderFlowLayoutPanel.Controls.Add(this.wfButtonDecode);
			this.wfDecoderFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wfDecoderFlowLayoutPanel.Location = new System.Drawing.Point(322, 3);
			this.wfDecoderFlowLayoutPanel.Name = "wfDecoderFlowLayoutPanel";
			this.wfDecoderFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.wfDecoderFlowLayoutPanel.Size = new System.Drawing.Size(313, 34);
			this.wfDecoderFlowLayoutPanel.TabIndex = 8;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 351);
			this.Controls.Add(this.wfMainWindowTableLayoutPanel);
			this.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainWindow";
			this.Text = "Unary coding";
			this.wfMainWindowTableLayoutPanel.ResumeLayout(false);
			this.wfMainWindowTableLayoutPanel.PerformLayout();
			this.wfDecoderFlowLayoutPanel.ResumeLayout(false);
			this.wfDecoderFlowLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label wfLabelCoder;
		private System.Windows.Forms.TextBox wfTextBoxCoderInput;
		private System.Windows.Forms.TextBox wfTextBoxCoderOutput;
		private System.Windows.Forms.TextBox wfTextBoxDecoderOutput;
		private System.Windows.Forms.TextBox wfTextBoxDecoderInput;
		private System.Windows.Forms.Label wfLabelDecoder;
        private System.Windows.Forms.Button wfButtonDecode;
		private System.Windows.Forms.TableLayoutPanel wfMainWindowTableLayoutPanel;
		private System.Windows.Forms.FlowLayoutPanel wfDecoderFlowLayoutPanel;
	}
}

