namespace UnaryCoding
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
            this.wfLabelCoder = new System.Windows.Forms.Label();
            this.wfTextBoxCoderInput = new System.Windows.Forms.TextBox();
            this.wfTextBoxCoderOutput = new System.Windows.Forms.TextBox();
            this.wfTextBoxDecoderOutput = new System.Windows.Forms.TextBox();
            this.wfTextBoxDecoderInput = new System.Windows.Forms.TextBox();
            this.wfLabelDecoder = new System.Windows.Forms.Label();
            this.wfButtonDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wfLabelCoder
            // 
            this.wfLabelCoder.AutoSize = true;
            this.wfLabelCoder.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfLabelCoder.Location = new System.Drawing.Point(22, 20);
            this.wfLabelCoder.Name = "wfLabelCoder";
            this.wfLabelCoder.Size = new System.Drawing.Size(48, 17);
            this.wfLabelCoder.TabIndex = 0;
            this.wfLabelCoder.Text = "Coder";
            // 
            // wfTextBoxCoderInput
            // 
            this.wfTextBoxCoderInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxCoderInput.Location = new System.Drawing.Point(25, 51);
            this.wfTextBoxCoderInput.Multiline = true;
            this.wfTextBoxCoderInput.Name = "wfTextBoxCoderInput";
            this.wfTextBoxCoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxCoderInput.Size = new System.Drawing.Size(342, 177);
            this.wfTextBoxCoderInput.TabIndex = 1;
            this.wfTextBoxCoderInput.TextChanged += new System.EventHandler(this.wfTextBoxCoderInput_TextChanged);
            // 
            // wfTextBoxCoderOutput
            // 
            this.wfTextBoxCoderOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxCoderOutput.Location = new System.Drawing.Point(25, 262);
            this.wfTextBoxCoderOutput.Multiline = true;
            this.wfTextBoxCoderOutput.Name = "wfTextBoxCoderOutput";
            this.wfTextBoxCoderOutput.ReadOnly = true;
            this.wfTextBoxCoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxCoderOutput.Size = new System.Drawing.Size(342, 177);
            this.wfTextBoxCoderOutput.TabIndex = 2;
            // 
            // wfTextBoxDecoderOutput
            // 
            this.wfTextBoxDecoderOutput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxDecoderOutput.Location = new System.Drawing.Point(419, 262);
            this.wfTextBoxDecoderOutput.Multiline = true;
            this.wfTextBoxDecoderOutput.Name = "wfTextBoxDecoderOutput";
            this.wfTextBoxDecoderOutput.ReadOnly = true;
            this.wfTextBoxDecoderOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxDecoderOutput.Size = new System.Drawing.Size(342, 177);
            this.wfTextBoxDecoderOutput.TabIndex = 5;
            // 
            // wfTextBoxDecoderInput
            // 
            this.wfTextBoxDecoderInput.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfTextBoxDecoderInput.Location = new System.Drawing.Point(419, 51);
            this.wfTextBoxDecoderInput.Multiline = true;
            this.wfTextBoxDecoderInput.Name = "wfTextBoxDecoderInput";
            this.wfTextBoxDecoderInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfTextBoxDecoderInput.Size = new System.Drawing.Size(342, 177);
            this.wfTextBoxDecoderInput.TabIndex = 4;
            // 
            // wfLabelDecoder
            // 
            this.wfLabelDecoder.AutoSize = true;
            this.wfLabelDecoder.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfLabelDecoder.Location = new System.Drawing.Point(416, 20);
            this.wfLabelDecoder.Name = "wfLabelDecoder";
            this.wfLabelDecoder.Size = new System.Drawing.Size(64, 17);
            this.wfLabelDecoder.TabIndex = 3;
            this.wfLabelDecoder.Text = "Decoder";
            // 
            // wfButtonDecode
            // 
            this.wfButtonDecode.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wfButtonDecode.Location = new System.Drawing.Point(658, 20);
            this.wfButtonDecode.Name = "wfButtonDecode";
            this.wfButtonDecode.Size = new System.Drawing.Size(103, 23);
            this.wfButtonDecode.TabIndex = 6;
            this.wfButtonDecode.Text = "Decode";
            this.wfButtonDecode.UseVisualStyleBackColor = true;
            this.wfButtonDecode.Click += new System.EventHandler(this.wfButtonDecode_Click);
            // 
            // WfMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 478);
            this.Controls.Add(this.wfButtonDecode);
            this.Controls.Add(this.wfTextBoxDecoderOutput);
            this.Controls.Add(this.wfTextBoxDecoderInput);
            this.Controls.Add(this.wfLabelDecoder);
            this.Controls.Add(this.wfTextBoxCoderOutput);
            this.Controls.Add(this.wfTextBoxCoderInput);
            this.Controls.Add(this.wfLabelCoder);
            this.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WfMainForm";
            this.Text = "Unary coding";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label wfLabelCoder;
		private System.Windows.Forms.TextBox wfTextBoxCoderInput;
		private System.Windows.Forms.TextBox wfTextBoxCoderOutput;
		private System.Windows.Forms.TextBox wfTextBoxDecoderOutput;
		private System.Windows.Forms.TextBox wfTextBoxDecoderInput;
		private System.Windows.Forms.Label wfLabelDecoder;
        private System.Windows.Forms.Button wfButtonDecode;
        }
}

