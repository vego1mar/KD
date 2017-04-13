using System.Windows.Forms;
using System.Text;
using System;

namespace HuffmanCoding
{
    public partial class MainWindow : Form
    {
        private HuffmanTree HuffmanCodeTree { get; set; }

        #region MainWindow()
        public MainWindow()
        {
            InitializeComponent();
            SetDefaultPropertiesValues();
        }
        #endregion

        #region SetDefaultPropertiesValues() : void
        private void SetDefaultPropertiesValues()
        {
            HuffmanCodeTree = new HuffmanTree();
        }
        #endregion

        #region wfMainWindowEncoderEncodeButton_Click(...) : void
        private void wfMainWindowEncoderEncodeButton_Click( object sender, System.EventArgs e )
        {
            StringBuilder text = new StringBuilder( HuffmanCodeTree.Encode( wfMainWindowEncoderTextBox.Text ) );
            var symbols = HuffmanCodeTree.GetLastLeafs();
            text.Append( Environment.NewLine + Environment.NewLine );

            foreach ( var pair in symbols ) {
                text.Append( pair.Key + "\t" + pair.Value + Environment.NewLine );
            }

            wfMainWindowEncoderOutputTextBox.Text = text.ToString();
        }
        #endregion

        #region MainWindow_Load(...) : void
        private void MainWindow_Load( object sender, System.EventArgs e )
        {
            this.MaximizeBox = false;
        }
        #endregion

        #region wfMainWindowDecoderDecodeButton_Click(...) : void
        private void wfMainWindowDecoderDecodeButton_Click( object sender, EventArgs e )
        {
            if ( !ValidateDecoderInputText() ) {
                MessageBox.Show( "The given string cannot be a Huffman code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
                return;
            }

            wfMainWindowDecoderOutputAreaTextBox.Text = HuffmanCodeTree.Decode( wfMainWindowDecoderInputTextBox.Text );
        }
        #endregion

        #region ValidateDecoderInputText() : bool
        private bool ValidateDecoderInputText()
        {
            foreach ( var symbol in wfMainWindowDecoderInputTextBox.Text ) {
                if ( symbol != '0' && symbol != '1' ) {
                    return false;
                }
            }

            return true;
        }
        #endregion

    }
}
