using System;
using System.Windows.Forms;
using System.Text;

namespace UnaryCoding
{
	public partial class MainWindow : Form
	{

		public MainWindow()
			{
			InitializeComponent();
			}

		private void WfTextBoxCoderInput_TextChanged( object sender, EventArgs e )
		{
		if ( !ValidateTextForDigitsOnly(wfTextBoxCoderInput.Text) ) {
			MessageBox.Show( "Non digit input.", "Invalid argument" );
			RemoveNonDigitCharactersFromTextBoxCoderInput();
			return;
			}
	
		wfTextBoxCoderOutput.Text = "";
		wfTextBoxCoderOutput.Text = BuildUnaryCodeFromTextBoxCoderInput();
		}

		private bool ValidateTextForDigitsOnly( string text )
			{
			foreach ( char character in text ) {
				if ( !Char.IsDigit(character) ) {
					return false;
					}
				}

			return true;
			}

		private void RemoveNonDigitCharactersFromTextBoxCoderInput()
			{ 
			var newInputString = new StringBuilder( "" );

			foreach ( char character in wfTextBoxCoderInput.Text ) {
				if ( Char.IsDigit(character) ) {
					newInputString.Append( character );
					}
				}

			wfTextBoxCoderInput.Text = newInputString.ToString();
			}

		private string BuildUnaryCodeFromTextBoxCoderInput()
			{
			var unaryCodeString = new StringBuilder( "" );
			
			foreach ( char character in wfTextBoxCoderInput.Text ) {
				byte currentDigit = Byte.Parse( character.ToString() );

				for ( byte i=0; i<currentDigit-1; i++ ) {
					unaryCodeString.Append( '1' );
					}

				unaryCodeString.Append( '0' );
				}

			return unaryCodeString.ToString();
			}

        private void WfButtonDecode_Click( object sender, EventArgs e )
            {
			if ( !ValidateTextForUnaryCodePattern(wfTextBoxDecoderInput.Text) ) {
				MessageBox.Show( "Non unary code input.", "Invalid argument" );
				wfTextBoxDecoderInput.Text = "";
				return;
				}

			wfTextBoxDecoderOutput.Text = "";
			wfTextBoxDecoderOutput.Text = InterpretAsUnaryCodeFromTextBoxDecoderInput();
            }

		private bool ValidateTextForUnaryCodePattern( string text )
			{
			return ValidateIfStringContainsOnlyOnesAndZeros( text );
			}

        private bool ValidateIfStringContainsOnlyOnesAndZeros( string text )
            {
            for ( int i=0; i<text.Length; i++ ) {
                if ( text[i] != '0' && text[i] != '1' ) {
                    return false;
                    }
                }

            return true;
            }

		private string InterpretAsUnaryCodeFromTextBoxDecoderInput()
			{
			var unaryDigit = new StringBuilder();
            var interpretedDigits = new StringBuilder( "" );
            int lastIndexOfUnaryDigit = 0;

			while ( lastIndexOfUnaryDigit < wfTextBoxDecoderInput.Text.Length ) {
				unaryDigit.Clear();

                while ( wfTextBoxDecoderInput.Text[ lastIndexOfUnaryDigit ] != '0' ) {
					unaryDigit.Append( '1' );
                    lastIndexOfUnaryDigit++;
                    }

				unaryDigit.Append( wfTextBoxDecoderInput.Text[ lastIndexOfUnaryDigit ] );
                lastIndexOfUnaryDigit++;
                interpretedDigits.Append( ParseStringAsUnaryDigit(unaryDigit.ToString()) );
				}

			return interpretedDigits.ToString();
			}

        private byte ParseStringAsUnaryDigit( string unaryDigit )
            {
            byte numberOfOnes = 0;

            foreach ( char character in unaryDigit ) {
                if ( character == '1' ) {
                    numberOfOnes++;
                    }
                }

            numberOfOnes += 1;
            return numberOfOnes;
            }

	}
}
