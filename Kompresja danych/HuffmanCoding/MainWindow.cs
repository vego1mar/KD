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
            //wfMainWindowDecoderOutputAreaTextBox.Text = HuffmanCodeTree.Decode( wfMainWindowDecoderInputTextBox.Text );
            MessageBox.Show( "Not implemented yet.", "Under development", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            }
        #endregion

        }
    }
