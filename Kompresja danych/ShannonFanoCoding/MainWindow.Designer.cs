namespace ShannonFanoCoding
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wfSplitContainer = new System.Windows.Forms.SplitContainer();
            this.wfLeftPanelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wfMessageSourceTextBox = new System.Windows.Forms.TextBox();
            this.wfInputTextBox = new System.Windows.Forms.TextBox();
            this.wfBuildCodeButton = new System.Windows.Forms.Button();
            this.wfRightPanelTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.wfResultTextBox = new System.Windows.Forms.TextBox();
            this.wfOutputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wfSplitContainer)).BeginInit();
            this.wfSplitContainer.Panel1.SuspendLayout();
            this.wfSplitContainer.Panel2.SuspendLayout();
            this.wfSplitContainer.SuspendLayout();
            this.wfLeftPanelTableLayoutPanel.SuspendLayout();
            this.wfRightPanelTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wfSplitContainer
            // 
            this.wfSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.wfSplitContainer.Name = "wfSplitContainer";
            // 
            // wfSplitContainer.Panel1
            // 
            this.wfSplitContainer.Panel1.Controls.Add(this.wfLeftPanelTableLayoutPanel);
            // 
            // wfSplitContainer.Panel2
            // 
            this.wfSplitContainer.Panel2.Controls.Add(this.wfRightPanelTableLayoutPanel);
            this.wfSplitContainer.Size = new System.Drawing.Size(689, 337);
            this.wfSplitContainer.SplitterDistance = 328;
            this.wfSplitContainer.TabIndex = 0;
            // 
            // wfLeftPanelTableLayoutPanel
            // 
            this.wfLeftPanelTableLayoutPanel.ColumnCount = 1;
            this.wfLeftPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wfLeftPanelTableLayoutPanel.Controls.Add(this.wfMessageSourceTextBox, 0, 0);
            this.wfLeftPanelTableLayoutPanel.Controls.Add(this.wfInputTextBox, 0, 1);
            this.wfLeftPanelTableLayoutPanel.Controls.Add(this.wfBuildCodeButton, 0, 2);
            this.wfLeftPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfLeftPanelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.wfLeftPanelTableLayoutPanel.Name = "wfLeftPanelTableLayoutPanel";
            this.wfLeftPanelTableLayoutPanel.RowCount = 3;
            this.wfLeftPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.wfLeftPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wfLeftPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.wfLeftPanelTableLayoutPanel.Size = new System.Drawing.Size(328, 337);
            this.wfLeftPanelTableLayoutPanel.TabIndex = 0;
            // 
            // wfMessageSourceTextBox
            // 
            this.wfMessageSourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfMessageSourceTextBox.Location = new System.Drawing.Point(3, 3);
            this.wfMessageSourceTextBox.Multiline = true;
            this.wfMessageSourceTextBox.Name = "wfMessageSourceTextBox";
            this.wfMessageSourceTextBox.ReadOnly = true;
            this.wfMessageSourceTextBox.Size = new System.Drawing.Size(322, 19);
            this.wfMessageSourceTextBox.TabIndex = 2;
            this.wfMessageSourceTextBox.Text = "Message source";
            this.wfMessageSourceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wfInputTextBox
            // 
            this.wfInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfInputTextBox.Location = new System.Drawing.Point(3, 28);
            this.wfInputTextBox.Multiline = true;
            this.wfInputTextBox.Name = "wfInputTextBox";
            this.wfInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfInputTextBox.Size = new System.Drawing.Size(322, 276);
            this.wfInputTextBox.TabIndex = 0;
            this.wfInputTextBox.Text = "Ala ma kota, a kot ma Alę 64-bitową.";
            // 
            // wfBuildCodeButton
            // 
            this.wfBuildCodeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfBuildCodeButton.Location = new System.Drawing.Point(3, 310);
            this.wfBuildCodeButton.Name = "wfBuildCodeButton";
            this.wfBuildCodeButton.Size = new System.Drawing.Size(322, 24);
            this.wfBuildCodeButton.TabIndex = 1;
            this.wfBuildCodeButton.Text = "Build code";
            this.wfBuildCodeButton.UseVisualStyleBackColor = true;
            this.wfBuildCodeButton.Click += new System.EventHandler(this.WfBuildCodeButton_Click);
            // 
            // wfRightPanelTableLayoutPanel
            // 
            this.wfRightPanelTableLayoutPanel.ColumnCount = 1;
            this.wfRightPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wfRightPanelTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.wfRightPanelTableLayoutPanel.Controls.Add(this.wfResultTextBox, 0, 0);
            this.wfRightPanelTableLayoutPanel.Controls.Add(this.wfOutputTextBox, 0, 1);
            this.wfRightPanelTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfRightPanelTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.wfRightPanelTableLayoutPanel.Name = "wfRightPanelTableLayoutPanel";
            this.wfRightPanelTableLayoutPanel.RowCount = 2;
            this.wfRightPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.wfRightPanelTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wfRightPanelTableLayoutPanel.Size = new System.Drawing.Size(357, 337);
            this.wfRightPanelTableLayoutPanel.TabIndex = 0;
            // 
            // wfResultTextBox
            // 
            this.wfResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfResultTextBox.Location = new System.Drawing.Point(3, 3);
            this.wfResultTextBox.Multiline = true;
            this.wfResultTextBox.Name = "wfResultTextBox";
            this.wfResultTextBox.ReadOnly = true;
            this.wfResultTextBox.Size = new System.Drawing.Size(351, 19);
            this.wfResultTextBox.TabIndex = 0;
            this.wfResultTextBox.Text = "Result";
            // 
            // wfOutputTextBox
            // 
            this.wfOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfOutputTextBox.Location = new System.Drawing.Point(3, 28);
            this.wfOutputTextBox.Multiline = true;
            this.wfOutputTextBox.Name = "wfOutputTextBox";
            this.wfOutputTextBox.ReadOnly = true;
            this.wfOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.wfOutputTextBox.Size = new System.Drawing.Size(351, 306);
            this.wfOutputTextBox.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 337);
            this.Controls.Add(this.wfSplitContainer);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainWindow";
            this.Text = "Shannon-Fano coding";
            this.wfSplitContainer.Panel1.ResumeLayout(false);
            this.wfSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wfSplitContainer)).EndInit();
            this.wfSplitContainer.ResumeLayout(false);
            this.wfLeftPanelTableLayoutPanel.ResumeLayout(false);
            this.wfLeftPanelTableLayoutPanel.PerformLayout();
            this.wfRightPanelTableLayoutPanel.ResumeLayout(false);
            this.wfRightPanelTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer wfSplitContainer;
        private System.Windows.Forms.TableLayoutPanel wfLeftPanelTableLayoutPanel;
        private System.Windows.Forms.TextBox wfMessageSourceTextBox;
        private System.Windows.Forms.TextBox wfInputTextBox;
        private System.Windows.Forms.Button wfBuildCodeButton;
        private System.Windows.Forms.TableLayoutPanel wfRightPanelTableLayoutPanel;
        private System.Windows.Forms.TextBox wfResultTextBox;
        private System.Windows.Forms.TextBox wfOutputTextBox;
    }
}

