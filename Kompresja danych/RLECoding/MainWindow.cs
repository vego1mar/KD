using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

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

            string rleText = "Yes = RLE encoding with TAB + CR/LF" + Environment.NewLine +
                "No = RLE encoding with single SPACE only";
            string rleCaption = "Choose encoding mode!";
            DialogResult chosenOption = MessageBox.Show( rleText, rleCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
            string rleCode = string.Empty;

            if ( chosenOption != DialogResult.Cancel ) {
                UpdateTextAndRefresh( txbRleOutputCode, "Building..." );
                UpdateTextAndRefresh( txbSummaryOutputFile, "Please wait for results..." );
            }

            switch ( chosenOption ) {
            case DialogResult.Yes:
                rleCode = BuildSimpleRleCode( false );
                break;
            case DialogResult.No:
                rleCode = BuildSimpleRleCode( true );
                break;
            default:
                return;
            }

            txbRleOutputCode.Text = rleCode;
            int countedNumbers = PpmFile.Data.Pixels.Count * 3;
            double compressionRate = (Convert.ToDouble( rleCode.Length ) / Convert.ToDouble( PpmFile.FileSizeInBytes )) * 100.0;
            txbSummaryOutputFile.Text = "Content length: " + rleCode.Length + Environment.NewLine +
                "Numbers counted: " + countedNumbers + " pairs of (value, occurences)" + Environment.NewLine +
                "Part of original file: " + compressionRate + " %" + Environment.NewLine;
        }

        private string BuildSimpleRleCode( bool useOnlySingleSpaces = false )
        {
            StringBuilder builder = new StringBuilder();
            List<ushort> values = PpmFile.GetPixelsDataAsList();
            ulong repeats = 0;
            AppendPpmHeaderFile( ref builder );

            if ( !useOnlySingleSpaces ) {
                builder.AppendLine();
            }

            for ( int i = 0; i < values.Count - 1; i++ ) {
                if ( values[i + 1] == values[i] ) {
                    repeats++;
                }
                else {
                    builder.Append( values[i] );

                    if ( !useOnlySingleSpaces ) {
                        builder.Append( '\t' );
                    }
                    else {
                        builder.Append( ' ' );
                    }

                    builder.Append( repeats + 1 );

                    if ( !useOnlySingleSpaces ) {
                        builder.AppendLine();
                    }
                    else {
                        builder.Append( ' ' );
                    }

                    repeats = 0;
                }
            }

            return builder.ToString();
        }

        private void AppendPpmHeaderFile( ref StringBuilder builder )
        {
            const char PARAGRAPH_UNICODE_SIGN = '\x00B6';
            builder.Append( PARAGRAPH_UNICODE_SIGN );
            builder.Append( ' ' );
            builder.Append( PpmFile.Data.Marker );
            builder.Append( ' ' );
            builder.Append( PpmFile.Data.Width );
            builder.Append( ' ' );
            builder.Append( PpmFile.Data.Heigth );
            builder.Append( ' ' );
            builder.Append( PpmFile.Data.MaxValue );
            builder.Append( ' ' );
            builder.Append( PARAGRAPH_UNICODE_SIGN );
            builder.Append( ' ' );
        }

    }
}
