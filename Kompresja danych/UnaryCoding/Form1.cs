using System;
using System.Windows.Forms;
using System.Text;

namespace UnaryCoding
{
	public partial class WfMainForm : Form
	{

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Code generated at start.
        /// </summary>

		public WfMainForm()
			{
			InitializeComponent();
			}

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Invokes whenever text in the 'wfTextBoxCoderInput' has been changed.
        /// </summary>
        /// <param name="sender">No use.</param>
        /// <param name="e">No use.</param>

		private void wfTextBoxCoderInput_TextChanged( object sender, EventArgs e )
		{
		if ( ValidateTextForDigitsOnly(wfTextBoxCoderInput.Text) == false ) {
			MessageBox.Show( "Non digit input.", "Invalid argument" );
			RemoveNonDigitCharactersFromTextBoxCoderInput();
			return;
			}
	
		wfTextBoxCoderOutput.Text = "";
		wfTextBoxCoderOutput.Text = BuildUnaryCodeFromTextBoxCoderInput();
		}

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Checks whether the given 'text' contains ASCII digits only or not.
        /// </summary>
        /// <param name="text">String text to check.</param>
        /// <returns>'false' if at least one of the character is not a digit; 'true' otherwise.</returns>

		private bool ValidateTextForDigitsOnly( string text )
			{
			foreach ( char character in text ) {
				if ( Char.IsDigit(character) == false ) {
					return false;
					}
				}

			return true;
			}

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Removes every characters that are not ASCII digits from 'wfTextBoxCoderInput' component.
        /// </summary>

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

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Creates a string unary code from the input text given by the 'wfTextBoxCoderInput' component.
        /// </summary>
        /// <returns>A string with an unary code.</returns>

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

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Invokes whenever 'wfButtonDecode' component has been clicked.
        /// </summary>
        /// <param name="sender">No use.</param>
        /// <param name="e">No use.</param>

        private void wfButtonDecode_Click( object sender, EventArgs e )
            {
			if ( ValidateTextForUnaryCodePattern(wfTextBoxDecoderInput.Text) == false ) {
				MessageBox.Show( "Non unary code input.", "Invalid argument" );
				wfTextBoxDecoderInput.Text = "";
				return;
				}

			wfTextBoxDecoderOutput.Text = "";
			wfTextBoxDecoderOutput.Text = InterpretAsUnaryCodeFromTextBoxDecoderInput();
            }

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Validation method for returning control path for the decoding of unary code functionality.
        /// </summary>
        /// <param name="text">A string text to check.</param>
        /// <returns>'true' if the given 'text' can be processed further; 'false' otherwise.</returns>

		private bool ValidateTextForUnaryCodePattern( string text )
			{
			return ValidateIfStringContainsOnlyOnesAndZeros( text );
			}

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Checks whether the given 'text' contains only 1's and 0's.
        /// </summary>
        /// <param name="text">A string text to check.</param>
        /// <returns>'true' if only 0's and 1's has been reached; 'false' otherwise.</returns>

        private bool ValidateIfStringContainsOnlyOnesAndZeros( string text )
            {
            for ( int i=0; i<text.Length; i++ ) {
                if ( text[i] != '0' && text[i] != '1' ) {
                    return false;
                    }
                }

            return true;
            }

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Interprets a text from the 'wfTextBoxDecoderInput' component as an unary code.
        /// </summary>
        /// <returns>A unary code string.</returns>

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

		//______________________________________________________________________________________________________________

        /// <summary>
        /// Finds how many 1's contain 'unaryDigit' and return that value added by 1.
        /// </summary>
        /// <param name="unaryDigit">A text with unary digit to parse.</param>
        /// <returns>A decimal digit interpreted from the unary code.</returns>

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

        //______________________________________________________________________________________________________________

        }
}
