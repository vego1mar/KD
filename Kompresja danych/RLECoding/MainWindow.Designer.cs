namespace RLECoding
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
            this.tlaypMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.txbInputFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnBuildRleCode = new System.Windows.Forms.Button();
            this.txbRleOutputCode = new System.Windows.Forms.TextBox();
            this.txbSummaryInputFile = new System.Windows.Forms.TextBox();
            this.txbSummaryOutputFile = new System.Windows.Forms.TextBox();
            this.tlaypMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlaypMainWindow
            // 
            this.tlaypMainWindow.ColumnCount = 2;
            this.tlaypMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlaypMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlaypMainWindow.Controls.Add(this.txbInputFile, 0, 0);
            this.tlaypMainWindow.Controls.Add(this.btnBrowseFile, 0, 2);
            this.tlaypMainWindow.Controls.Add(this.btnBuildRleCode, 1, 2);
            this.tlaypMainWindow.Controls.Add(this.txbRleOutputCode, 1, 0);
            this.tlaypMainWindow.Controls.Add(this.txbSummaryInputFile, 0, 1);
            this.tlaypMainWindow.Controls.Add(this.txbSummaryOutputFile, 1, 1);
            this.tlaypMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlaypMainWindow.Location = new System.Drawing.Point(0, 0);
            this.tlaypMainWindow.Name = "tlaypMainWindow";
            this.tlaypMainWindow.RowCount = 3;
            this.tlaypMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlaypMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlaypMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlaypMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlaypMainWindow.Size = new System.Drawing.Size(873, 399);
            this.tlaypMainWindow.TabIndex = 0;
            // 
            // txbInputFile
            // 
            this.txbInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbInputFile.Location = new System.Drawing.Point(3, 3);
            this.txbInputFile.Multiline = true;
            this.txbInputFile.Name = "txbInputFile";
            this.txbInputFile.ReadOnly = true;
            this.txbInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbInputFile.Size = new System.Drawing.Size(430, 253);
            this.txbInputFile.TabIndex = 2;
            this.txbInputFile.Text = "Input board";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseFile.Location = new System.Drawing.Point(3, 341);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(430, 55);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "Browse a .ppm image (in ASCII) file...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // btnBuildRleCode
            // 
            this.btnBuildRleCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuildRleCode.Location = new System.Drawing.Point(439, 341);
            this.btnBuildRleCode.Name = "btnBuildRleCode";
            this.btnBuildRleCode.Size = new System.Drawing.Size(431, 55);
            this.btnBuildRleCode.TabIndex = 1;
            this.btnBuildRleCode.Text = "Build RLE code";
            this.btnBuildRleCode.UseVisualStyleBackColor = true;
            this.btnBuildRleCode.Click += new System.EventHandler(this.BtnBuildRleCode_Click);
            // 
            // txbRleOutputCode
            // 
            this.txbRleOutputCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRleOutputCode.Location = new System.Drawing.Point(439, 3);
            this.txbRleOutputCode.Multiline = true;
            this.txbRleOutputCode.Name = "txbRleOutputCode";
            this.txbRleOutputCode.ReadOnly = true;
            this.txbRleOutputCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbRleOutputCode.Size = new System.Drawing.Size(431, 253);
            this.txbRleOutputCode.TabIndex = 3;
            this.txbRleOutputCode.Text = "Output board";
            // 
            // txbSummaryInputFile
            // 
            this.txbSummaryInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbSummaryInputFile.Location = new System.Drawing.Point(3, 262);
            this.txbSummaryInputFile.Multiline = true;
            this.txbSummaryInputFile.Name = "txbSummaryInputFile";
            this.txbSummaryInputFile.ReadOnly = true;
            this.txbSummaryInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSummaryInputFile.Size = new System.Drawing.Size(430, 73);
            this.txbSummaryInputFile.TabIndex = 4;
            this.txbSummaryInputFile.Text = "Summary for an input file";
            // 
            // txbSummaryOutputFile
            // 
            this.txbSummaryOutputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbSummaryOutputFile.Location = new System.Drawing.Point(439, 262);
            this.txbSummaryOutputFile.Multiline = true;
            this.txbSummaryOutputFile.Name = "txbSummaryOutputFile";
            this.txbSummaryOutputFile.ReadOnly = true;
            this.txbSummaryOutputFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSummaryOutputFile.Size = new System.Drawing.Size(431, 73);
            this.txbSummaryOutputFile.TabIndex = 5;
            this.txbSummaryOutputFile.Text = "Summary for the output file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 399);
            this.Controls.Add(this.tlaypMainWindow);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainWindow";
            this.Text = "RLE Coding";
            this.tlaypMainWindow.ResumeLayout(false);
            this.tlaypMainWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlaypMainWindow;
        private System.Windows.Forms.TextBox txbInputFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnBuildRleCode;
        private System.Windows.Forms.TextBox txbRleOutputCode;
        private System.Windows.Forms.TextBox txbSummaryInputFile;
        private System.Windows.Forms.TextBox txbSummaryOutputFile;
    }
}

