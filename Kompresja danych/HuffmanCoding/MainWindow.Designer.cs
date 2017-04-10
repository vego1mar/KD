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
            this.wfMainWindowDecoderTabPage = new System.Windows.Forms.TabPage();
            this.wfMainWindowEncoderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.wfMainWindowEncoderTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowEncoderPanel = new System.Windows.Forms.Panel();
            this.wfMainWindowEncoderEncodeButton = new System.Windows.Forms.Button();
            this.wfMainWindowEncoderEncoderOutputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowEncoderOutputTextBox = new System.Windows.Forms.TextBox();
            this.wfMainWindowTabControl.SuspendLayout();
            this.wfMainWindowEncoderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowEncoderSplitContainer)).BeginInit();
            this.wfMainWindowEncoderSplitContainer.Panel1.SuspendLayout();
            this.wfMainWindowEncoderSplitContainer.Panel2.SuspendLayout();
            this.wfMainWindowEncoderSplitContainer.SuspendLayout();
            this.wfMainWindowEncoderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wfMainWindowTabControl
            // 
            this.wfMainWindowTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.wfMainWindowTabControl.Controls.Add(this.wfMainWindowEncoderTabPage);
            this.wfMainWindowTabControl.Controls.Add(this.wfMainWindowDecoderTabPage);
            this.wfMainWindowTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowTabControl.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowTabControl.Name = "wfMainWindowTabControl";
            this.wfMainWindowTabControl.SelectedIndex = 0;
            this.wfMainWindowTabControl.Size = new System.Drawing.Size(854, 406);
            this.wfMainWindowTabControl.TabIndex = 0;
            // 
            // wfMainWindowEncoderTabPage
            // 
            this.wfMainWindowEncoderTabPage.Controls.Add(this.wfMainWindowEncoderSplitContainer);
            this.wfMainWindowEncoderTabPage.Location = new System.Drawing.Point(4, 25);
            this.wfMainWindowEncoderTabPage.Name = "wfMainWindowEncoderTabPage";
            this.wfMainWindowEncoderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wfMainWindowEncoderTabPage.Size = new System.Drawing.Size(846, 377);
            this.wfMainWindowEncoderTabPage.TabIndex = 0;
            this.wfMainWindowEncoderTabPage.Text = "Encoder";
            this.wfMainWindowEncoderTabPage.UseVisualStyleBackColor = true;
            // 
            // wfMainWindowDecoderTabPage
            // 
            this.wfMainWindowDecoderTabPage.Location = new System.Drawing.Point(4, 25);
            this.wfMainWindowDecoderTabPage.Name = "wfMainWindowDecoderTabPage";
            this.wfMainWindowDecoderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wfMainWindowDecoderTabPage.Size = new System.Drawing.Size(846, 377);
            this.wfMainWindowDecoderTabPage.TabIndex = 1;
            this.wfMainWindowDecoderTabPage.Text = "Decoder";
            this.wfMainWindowDecoderTabPage.UseVisualStyleBackColor = true;
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
            this.wfMainWindowEncoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowEncoderPanel);
            this.wfMainWindowEncoderSplitContainer.Panel1.Controls.Add(this.wfMainWindowEncoderTextBox);
            // 
            // wfMainWindowEncoderSplitContainer.Panel2
            // 
            this.wfMainWindowEncoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowEncoderOutputTextBox);
            this.wfMainWindowEncoderSplitContainer.Panel2.Controls.Add(this.wfMainWindowEncoderEncoderOutputTextBox);
            this.wfMainWindowEncoderSplitContainer.Size = new System.Drawing.Size(840, 371);
            this.wfMainWindowEncoderSplitContainer.SplitterDistance = 396;
            this.wfMainWindowEncoderSplitContainer.TabIndex = 0;
            // 
            // wfMainWindowEncoderTextBox
            // 
            this.wfMainWindowEncoderTextBox.AllowDrop = true;
            this.wfMainWindowEncoderTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowEncoderTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowEncoderTextBox.Multiline = true;
            this.wfMainWindowEncoderTextBox.Name = "wfMainWindowEncoderTextBox";
            this.wfMainWindowEncoderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowEncoderTextBox.Size = new System.Drawing.Size(396, 326);
            this.wfMainWindowEncoderTextBox.TabIndex = 0;
            this.wfMainWindowEncoderTextBox.Text = "Ala ma kota, a kot ma Alę 64-bitową.";
            // 
            // wfMainWindowEncoderPanel
            // 
            this.wfMainWindowEncoderPanel.Controls.Add(this.wfMainWindowEncoderEncodeButton);
            this.wfMainWindowEncoderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wfMainWindowEncoderPanel.Location = new System.Drawing.Point(0, 332);
            this.wfMainWindowEncoderPanel.Name = "wfMainWindowEncoderPanel";
            this.wfMainWindowEncoderPanel.Size = new System.Drawing.Size(396, 39);
            this.wfMainWindowEncoderPanel.TabIndex = 1;
            // 
            // wfMainWindowEncoderEncodeButton
            // 
            this.wfMainWindowEncoderEncodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowEncoderEncodeButton.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowEncoderEncodeButton.Name = "wfMainWindowEncoderEncodeButton";
            this.wfMainWindowEncoderEncodeButton.Size = new System.Drawing.Size(396, 39);
            this.wfMainWindowEncoderEncodeButton.TabIndex = 0;
            this.wfMainWindowEncoderEncodeButton.Text = "Encode";
            this.wfMainWindowEncoderEncodeButton.UseVisualStyleBackColor = true;
            this.wfMainWindowEncoderEncodeButton.Click += new System.EventHandler(this.wfMainWindowEncoderEncodeButton_Click);
            // 
            // wfMainWindowEncoderEncoderOutputTextBox
            // 
            this.wfMainWindowEncoderEncoderOutputTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.wfMainWindowEncoderEncoderOutputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfMainWindowEncoderEncoderOutputTextBox.Enabled = false;
            this.wfMainWindowEncoderEncoderOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.wfMainWindowEncoderEncoderOutputTextBox.Name = "wfMainWindowEncoderEncoderOutputTextBox";
            this.wfMainWindowEncoderEncoderOutputTextBox.ReadOnly = true;
            this.wfMainWindowEncoderEncoderOutputTextBox.Size = new System.Drawing.Size(440, 20);
            this.wfMainWindowEncoderEncoderOutputTextBox.TabIndex = 0;
            this.wfMainWindowEncoderEncoderOutputTextBox.Text = "Encoder output";
            // 
            // wfMainWindowEncoderOutputTextBox
            // 
            this.wfMainWindowEncoderOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMainWindowEncoderOutputTextBox.Location = new System.Drawing.Point(0, 20);
            this.wfMainWindowEncoderOutputTextBox.Multiline = true;
            this.wfMainWindowEncoderOutputTextBox.Name = "wfMainWindowEncoderOutputTextBox";
            this.wfMainWindowEncoderOutputTextBox.ReadOnly = true;
            this.wfMainWindowEncoderOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfMainWindowEncoderOutputTextBox.Size = new System.Drawing.Size(440, 351);
            this.wfMainWindowEncoderOutputTextBox.TabIndex = 1;
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
            this.wfMainWindowTabControl.ResumeLayout(false);
            this.wfMainWindowEncoderTabPage.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel1.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel1.PerformLayout();
            this.wfMainWindowEncoderSplitContainer.Panel2.ResumeLayout(false);
            this.wfMainWindowEncoderSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfMainWindowEncoderSplitContainer)).EndInit();
            this.wfMainWindowEncoderSplitContainer.ResumeLayout(false);
            this.wfMainWindowEncoderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TabControl wfMainWindowTabControl;
        private System.Windows.Forms.TabPage wfMainWindowEncoderTabPage;
        private System.Windows.Forms.TabPage wfMainWindowDecoderTabPage;
        private System.Windows.Forms.SplitContainer wfMainWindowEncoderSplitContainer;
        private System.Windows.Forms.Panel wfMainWindowEncoderPanel;
        private System.Windows.Forms.Button wfMainWindowEncoderEncodeButton;
        private System.Windows.Forms.TextBox wfMainWindowEncoderTextBox;
        private System.Windows.Forms.TextBox wfMainWindowEncoderOutputTextBox;
        private System.Windows.Forms.TextBox wfMainWindowEncoderEncoderOutputTextBox;
        }
    }

