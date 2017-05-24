using System;
using System.Text;
using System.Windows.Forms;

namespace RLECoding
{
    public partial class MainWindow : Form
    {

        private bool IsFileChosen { get; set; } = false;
        private PpmFile PpmFile { get; } = new PpmFile();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBrowseFile_Click( object sender, EventArgs e )
        {
            string chosenFileName;
            DialogResult fileInputResult = ShowInputFileChooserDialog( out chosenFileName );

            if ( fileInputResult != DialogResult.OK ) {
                return;
            }

            IsFileChosen = true;
            PpmFile.FilePath = chosenFileName;

            UpdateTextAndRefresh( txbInputFile, "Reading..." );
            UpdateTextAndRefresh( txbSummaryInputFile, "Please wait for results..." );

            if ( !PpmFile.Read() ) {
                string text = PpmFile.LastException.Message;
                string caption = PpmFile.LastException.GetType().ToString();
                UpdateTextAndRefresh( txbInputFile, PpmFile.LastException.ToString() );
                UpdateTextAndRefresh( txbSummaryInputFile, PpmFile.LastException.TargetSite.ToString() );
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop );
                return;
            }

            UpdateTextAndRefresh( txbInputFile, "Parsing..." );

            if ( !PpmFile.Parse() ) {
                string text = PpmFile.LastException.Message;
                string caption = PpmFile.LastException.GetType().ToString();
                UpdateTextAndRefresh( txbInputFile, PpmFile.LastException.ToString() );
                UpdateTextAndRefresh( txbSummaryInputFile, PpmFile.LastException.TargetSite.ToString() );
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop );
                return;
            }

            UpdateTextAndRefresh( txbInputFile, "Displaying..." );
            StringBuilder builder = new StringBuilder();

            foreach ( var element in PpmFile.SourceLineByLine ) {
                builder.AppendLine( element );
            }

            txbInputFile.Text = builder.ToString();
            txbSummaryInputFile.Text = "Content length: " + builder.Length + Environment.NewLine +
                "File size: " + PpmFile.FileSizeInBytes + " B" + Environment.NewLine +
                "Pixels found: " + PpmFile.Data.Pixels.Count + Environment.NewLine +
                "Encoding: " + PpmFile.Encoding.BodyName.ToString().ToUpperInvariant() + Environment.NewLine +
                "File path: " + PpmFile.FilePath + Environment.NewLine;
        }

        private void UpdateTextAndRefresh( TextBox textBox, string text )
        {
            textBox.Text = text;
            textBox.Refresh();
        }

        private DialogResult ShowInputFileChooserDialog( out string fileName )
        {
            DialogResult result;

            using ( var dialog = new OpenFileDialog() ) {
                dialog.DefaultExt = "ppm";
                dialog.Filter = "NetPBM images (*.ppm)|*.ppm|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.ReadOnlyChecked = true;
                dialog.AddExtension = true;
                dialog.Title = "RLE Coding - choose a file...";
                dialog.Multiselect = false;
                dialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                result = dialog.ShowDialog();
                fileName = dialog.FileName;
            }

            return result;
        }

        private void BtnBuildRleCode_Click( object sender, EventArgs e )
        {
            if ( !IsFileChosen ) {
                string text = "A file has not been chosen yet.";
                string caption = "Choose a file!";
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            // TODO: Build RLE code.
            // TODO: Update UI with a summary.
        }

    }
}
