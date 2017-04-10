using System.Windows.Forms;

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
            // TODO: Remove that assignment when finished
            wfMainWindowEncoderTextBox.Text = "AAABBCDDDDDEEEE";
            wfMainWindowEncoderOutputTextBox.Text = HuffmanCodeTree.Encode( wfMainWindowEncoderTextBox.Text );
            }
        #endregion

        }
    }
