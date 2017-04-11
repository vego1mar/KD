namespace HuffmanCoding
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
            this.wfMainWindowTabControl = new System.Windows.Forms.TabControl();
            this.wfMainWindowEncoderTabPage = new System.Windows.Forms.TabPage();
            this.wfMainWindowEncoderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.wfMainWindowEncoderEncodeButton = new System.Windows.Forms.Button();
            this.wfMainWindowEncoderTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowEncoderOutputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowEncoderEncoderOutputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowDecoderTabPage = new System.Windows.Forms.TabPage();
            this.wfMainWindowDecoderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.wfMainWindowDecoderInputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowDecoderDecodeButton = new System.Windows.Forms.Button();
            this.wfMainWindowDecoderOutputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowDecoderOutputAreaTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowTabControl.SuspendLayout();
            this.wfMainWindowEncoderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowEncoderSplitContainer)).BeginInit();
            this.wfMainWindowEncoderSplitContainer.Panel1.SuspendLayout();
            this.wfMainWindowEncoderSplitContainer.Panel2.SuspendLayout();
            this.wfMainWindowEncoderSplitContainer.SuspendLayout();
            this.wfMainWindowDecoderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowDecoderSplitContainer)).BeginInit();
            this.wfMainWindowDecoderSplitContainer.Panel1.SuspendLayout();
            this.wfMainWindowDecoderSplitContainer.Panel2.SuspendLayout();
            this.wfMainWindowDecoderSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // wfMainWindowTabControl
            // 
            this.wfMainWindowTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.wfMainWindowTabControl.Controls.Add(this.wfMainWindowEncoderTabPage);
            this.wfMainWindowTabControl.Controls.Add(this.wfMainWindowDecoderTabPage);
            this.wfMainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowTabControl.ItemSize = new System.Drawing.Size(54, 20);
            this.wfMainWindowTabControl.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowTabControl.Name = "wfMainWindowTabControl";
            this.wfMainWindowTabControl.SelectedIndex = 0;
            this.wfMainWindowTabControl.Size = new System.Drawing.Size(854, 406);
            this.wfMainWindowTabControl.TabIndex = 0;
            // 
            // wfMainWindowEncoderTabPage
            // 
            this.wfMainWindowEncoderTabPage.Controls.Add(this.wfMainWindowEncoderSplitContainer);
            this.wfMainWindowEncoderTabPage.Location = new System.Drawing.Point(4, 24);
            this.wfMainWindowEncoderTabPage.Name = "wfMainWindowEncoderTabPage";
            this.wfMainWindowEncoderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wfMainWindowEncoderTabPage.Size = new System.Drawing.Size(846, 378);
            this.wfMainWindowEncoderTabPage.TabIndex = 0;
            this.wfMainWindowEncoderTabPage.Text = "Encoder";
            this.wfMainWindowEncoderTabPage.UseVisualStyleBackColor = true;
            // 
            // wfMainWindowEncoderSplitContainer
            // 
            this.wfMainWindowEncoderSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowEncoderSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.wfMainWindowEncoderSplitContainer.Name = "wfMainWindowEncoderSplitContainer";
            // 
            // wfMainWindowEncoderSplitContainer.Panel1
            // 
            this.wfMainWindowEncoderSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wfMainWindowEncoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowEncoderEncodeButton);
            this.wfMainWindowEncoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowEncoderTextBox);
            // 
            // wfMainWindowEncoderSplitContainer.Panel2
            // 
            this.wfMainWindowEncoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowEncoderOutputTextBox);
            this.wfMainWindowEncoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowEncoderEncoderOutputTextBox);
            this.wfMainWindowEncoderSplitContainer.Size = new System.Drawing.Size(840, 372);
            this.wfMainWindowEncoderSplitContainer.SplitterDistance = 397;
            this.wfMainWindowEncoderSplitContainer.TabIndex = 0;
            // 
            // wfMainWindowEncoderEncodeButton
            // 
            this.wfMainWindowEncoderEncodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowEncoderEncodeButton.Location = new System.Drawing.Point(0, 329);
            this.wfMainWindowEncoderEncodeButton.Name = "wfMainWindowEncoderEncodeButton";
            this.wfMainWindowEncoderEncodeButton.Size = new System.Drawing.Size(397, 43);
            this.wfMainWindowEncoderEncodeButton.TabIndex = 0;
            this.wfMainWindowEncoderEncodeButton.Text = "Encode";
            this.wfMainWindowEncoderEncodeButton.UseVisualStyleBackColor = true;
            this.wfMainWindowEncoderEncodeButton.Click += new System.EventHandler(this.wfMainWindowEncoderEncodeButton_Click);
            // 
            // wfMainWindowEncoderTextBox
            // 
            this.wfMainWindowEncoderTextBox.AllowDrop = true;
            this.wfMainWindowEncoderTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowEncoderTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowEncoderTextBox.Multiline = true;
            this.wfMainWindowEncoderTextBox.Name = "wfMainWindowEncoderTextBox";
            this.wfMainWindowEncoderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowEncoderTextBox.Size = new System.Drawing.Size(397, 329);
            this.wfMainWindowEncoderTextBox.TabIndex = 0;
            this.wfMainWindowEncoderTextBox.Text = "Ala ma kota, a kot ma Alę 64-bitową.";
            // 
            // wfMainWindowEncoderOutputTextBox
            // 
            this.wfMainWindowEncoderOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowEncoderOutputTextBox.Location = new System.Drawing.Point(0, 20);
            this.wfMainWindowEncoderOutputTextBox.Multiline = true;
            this.wfMainWindowEncoderOutputTextBox.Name = "wfMainWindowEncoderOutputTextBox";
            this.wfMainWindowEncoderOutputTextBox.ReadOnly = true;
            this.wfMainWindowEncoderOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowEncoderOutputTextBox.Size = new System.Drawing.Size(439, 352);
            this.wfMainWindowEncoderOutputTextBox.TabIndex = 1;
            // 
            // wfMainWindowEncoderEncoderOutputTextBox
            // 
            this.wfMainWindowEncoderEncoderOutputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.wfMainWindowEncoderEncoderOutputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowEncoderEncoderOutputTextBox.Enabled = false;
            this.wfMainWindowEncoderEncoderOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowEncoderEncoderOutputTextBox.Name = "wfMainWindowEncoderEncoderOutputTextBox";
            this.wfMainWindowEncoderEncoderOutputTextBox.ReadOnly = true;
            this.wfMainWindowEncoderEncoderOutputTextBox.Size = new System.Drawing.Size(439, 20);
            this.wfMainWindowEncoderEncoderOutputTextBox.TabIndex = 0;
            this.wfMainWindowEncoderEncoderOutputTextBox.Text = "Encoder output";
            // 
            // wfMainWindowDecoderTabPage
            // 
            this.wfMainWindowDecoderTabPage.Controls.Add(this.wfMainWindowDecoderSplitContainer);
            this.wfMainWindowDecoderTabPage.Location = new System.Drawing.Point(4, 24);
            this.wfMainWindowDecoderTabPage.Name = "wfMainWindowDecoderTabPage";
            this.wfMainWindowDecoderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wfMainWindowDecoderTabPage.Size = new System.Drawing.Size(846, 378);
            this.wfMainWindowDecoderTabPage.TabIndex = 1;
            this.wfMainWindowDecoderTabPage.Text = "Decoder";
            this.wfMainWindowDecoderTabPage.UseVisualStyleBackColor = true;
            // 
            // wfMainWindowDecoderSplitContainer
            // 
            this.wfMainWindowDecoderSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowDecoderSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.wfMainWindowDecoderSplitContainer.Name = "wfMainWindowDecoderSplitContainer";
            // 
            // wfMainWindowDecoderSplitContainer.Panel1
            // 
            this.wfMainWindowDecoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowDecoderDecodeButton);
            this.wfMainWindowDecoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowDecoderInputTextBox);
            // 
            // wfMainWindowDecoderSplitContainer.Panel2
            // 
            this.wfMainWindowDecoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowDecoderOutputAreaTextBox);
            this.wfMainWindowDecoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowDecoderOutputTextBox);
            this.wfMainWindowDecoderSplitContainer.Size = new System.Drawing.Size(840, 372);
            this.wfMainWindowDecoderSplitContainer.SplitterDistance = 395;
            this.wfMainWindowDecoderSplitContainer.TabIndex = 0;
            // 
            // wfMainWindowDecoderInputTextBox
            // 
            this.wfMainWindowDecoderInputTextBox.AllowDrop = true;
            this.wfMainWindowDecoderInputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowDecoderInputTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowDecoderInputTextBox.Multiline = true;
            this.wfMainWindowDecoderInputTextBox.Name = "wfMainWindowDecoderInputTextBox";
            this.wfMainWindowDecoderInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowDecoderInputTextBox.Size = new System.Drawing.Size(395, 331);
            this.wfMainWindowDecoderInputTextBox.TabIndex = 0;
            // 
            // wfMainWindowDecoderDecodeButton
            // 
            this.wfMainWindowDecoderDecodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowDecoderDecodeButton.Location = new System.Drawing.Point(0, 331);
            this.wfMainWindowDecoderDecodeButton.Name = "wfMainWindowDecoderDecodeButton";
            this.wfMainWindowDecoderDecodeButton.Size = new System.Drawing.Size(395, 41);
            this.wfMainWindowDecoderDecodeButton.TabIndex = 1;
            this.wfMainWindowDecoderDecodeButton.Text = "Decode";
            this.wfMainWindowDecoderDecodeButton.UseVisualStyleBackColor = true;
            this.wfMainWindowDecoderDecodeButton.Click += new System.EventHandler(this.wfMainWindowDecoderDecodeButton_Click);
            // 
            // wfMainWindowDecoderOutputTextBox
            // 
            this.wfMainWindowDecoderOutputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.wfMainWindowDecoderOutputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowDecoderOutputTextBox.Enabled = false;
            this.wfMainWindowDecoderOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowDecoderOutputTextBox.Name = "wfMainWindowDecoderOutputTextBox";
            this.wfMainWindowDecoderOutputTextBox.ReadOnly = true;
            this.wfMainWindowDecoderOutputTextBox.Size = new System.Drawing.Size(441, 20);
            this.wfMainWindowDecoderOutputTextBox.TabIndex = 1;
            this.wfMainWindowDecoderOutputTextBox.Text = "Decoder output";
            // 
            // wfMainWindowDecoderOutputAreaTextBox
            // 
            this.wfMainWindowDecoderOutputAreaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowDecoderOutputAreaTextBox.Location = new System.Drawing.Point(0, 20);
            this.wfMainWindowDecoderOutputAreaTextBox.Multiline = true;
            this.wfMainWindowDecoderOutputAreaTextBox.Name = "wfMainWindowDecoderOutputAreaTextBox";
            this.wfMainWindowDecoderOutputAreaTextBox.ReadOnly = true;
            this.wfMainWindowDecoderOutputAreaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowDecoderOutputAreaTextBox.Size = new System.Drawing.Size(441, 352);
            this.wfMainWindowDecoderOutputAreaTextBox.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 406);
            this.Controls.Add(this.wfMainWindowTabControl);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Huffman coding";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.wfMainWindowTabControl.ResumeLayout(false);
            this.wfMainWindowEncoderTabPage.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel1.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel1.PerformLayout();
            this.wfMainWindowEncoderSplitContainer.Panel2.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowEncoderSplitContainer)).EndInit();
            this.wfMainWindowEncoderSplitContainer.ResumeLayout(false);
            this.wfMainWindowDecoderTabPage.ResumeLayout(false);
            this.wfMainWindowDecoderSplitContainer.Panel1.ResumeLayout(false);
            this.wfMainWindowDecoderSplitContainer.Panel1.PerformLayout();
            this.wfMainWindowDecoderSplitContainer.Panel2.ResumeLayout(false);
            this.wfMainWindowDecoderSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowDecoderSplitContainer)).EndInit();
            this.wfMainWindowDecoderSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TabControl wfMainWindowTabControl;
        private System.Windows.Forms.TabPage wfMainWindowEncoderTabPage;
        private System.Windows.Forms.TabPage wfMainWindowDecoderTabPage;
        private System.Windows.Forms.SplitContainer wfMainWindowEncoderSplitContainer;
        private System.Windows.Forms.Button wfMainWindowEncoderEncodeButton;
        private System.Windows.Forms.TextBox wfMainWindowEncoderTextBox;
        private System.Windows.Forms.TextBox wfMainWindowEncoderOutputTextBox;
        private System.Windows.Forms.TextBox wfMainWindowEncoderEncoderOutputTextBox;
        private System.Windows.Forms.SplitContainer wfMainWindowDecoderSplitContainer;
        private System.Windows.Forms.Button wfMainWindowDecoderDecodeButton;
        private System.Windows.Forms.TextBox wfMainWindowDecoderInputTextBox;
        private System.Windows.Forms.TextBox wfMainWindowDecoderOutputAreaTextBox;
        private System.Windows.Forms.TextBox wfMainWindowDecoderOutputTextBox;
        }
    }

