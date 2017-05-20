using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArithmeticCoding
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEncode_Click( object sender, EventArgs e )
        {
            string exceptionInfo;
            Dictionary<int, ulong> symbolsAlphabet = GetAlphabetOfOccurences( txbCoderInputBoard.Text );
            List<double> convertees = ValidateThatProvidedProbabilitiesAreNumbers( out exceptionInfo, symbolsAlphabet );

            if ( convertees == null ) {
                string text = "A problem with number convertion:" + Environment.NewLine + exceptionInfo;
                string caption = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            if ( !ValidateThatProvidedProbabilitiesSumUpToOneness( symbolsAlphabet.Count, convertees ) ) {
                string text = "The provided probabilities are not sum up to oneness.";
                string caption = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            Dictionary<int, double> cumulativeProbabilities = GetCumulativeProbabilities( symbolsAlphabet, convertees );
            List<double> borders;
            double arithmeticCode = GetArithmeticCode( cumulativeProbabilities, txbCoderInputBoard.Text, out borders );
            UpdateUIWithEncodingResults( arithmeticCode, borders, txbCoderOutputBoard );
        }

        private void TxbCoderInputBoard_TextChanged( object sender, EventArgs e )
        {
            TextBox coderInputBoard = sender as TextBox;
            const int NUMBER_OF_ACCEPTED_DIFFERENT_SYMBOLS = 5;

            if ( coderInputBoard != null ) {
                Dictionary<int, ulong> symbolsOccurences = GetAlphabetOfOccurences( coderInputBoard.Text );

                if ( symbolsOccurences.Count > NUMBER_OF_ACCEPTED_DIFFERENT_SYMBOLS ) {
                    string text = "Different symbols found: " + symbolsOccurences.Count + ". " +
                        "Accepted is: " + NUMBER_OF_ACCEPTED_DIFFERENT_SYMBOLS + ".";
                    string caption = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    int lastSymbol = coderInputBoard.Text[coderInputBoard.Text.Length - 1];
                    coderInputBoard.Text = coderInputBoard.Text.Replace( Convert.ToChar( lastSymbol ).ToString(), string.Empty );
                    SetCursorAtEnd( coderInputBoard );
                    return;
                }

                UpdateUIToInformAboutRecognizedSymbols( symbolsOccurences );
            }
        }

        private Dictionary<int, ulong> GetAlphabetOfOccurences( string source )
        {
            Dictionary<int, ulong> alphabet = new Dictionary<int, ulong>();

            for ( int i = 0; i < source.Length; i++ ) {
                if ( alphabet.ContainsKey( source[i] ) ) {
                    alphabet[source[i]] = alphabet[source[i]] + 1;
                }
                else {
                    alphabet.Add( source[i], 1 );
                }
            }

            return alphabet;
        }

        private void UpdateUIToInformAboutRecognizedSymbols( Dictionary<int, ulong> coderInputBoardAlphabet )
        {
            TextBox[] informees = {
                txbTextP1, txbTextP2, txbTextP3, txbTextP4, txbTextP5
            };

            int j = 0;

            foreach ( var pair in coderInputBoardAlphabet ) {
                informees[j].Text = "p" + (j + 1).ToString() + " (" + Convert.ToChar( pair.Key ) + ") = ";
                j++;
            }

            for ( int i = j; i < informees.Length; i++ ) {
                informees[i].Text = "p" + (i + 1).ToString() + " = ";
            }
        }

        private void SetCursorAtEnd( TextBox textBox )
        {
            textBox.SelectionStart = Math.Max( 0, textBox.Text.Length );
            textBox.SelectionLength = 0;
        }

        private List<double> ValidateThatProvidedProbabilitiesAreNumbers( out string exceptionMessage, Dictionary<int, ulong> symbolsAlphabet )
        {
            exceptionMessage = null;
            List<double> convertees = new List<double>();

            TextBox[] providers = {
                txbInputP1, txbInputP2, txbInputP3, txbInputP4, txbInputP5
            };

            try {
                for ( int i = 0; i < symbolsAlphabet.Count; i++ ) {
                    convertees.Add( Convert.ToDouble( providers[i].Text ) );
                }
            }
            catch ( FormatException x ) {
                exceptionMessage = x.Message;
                return null;
            }
            catch ( OverflowException x ) {
                exceptionMessage = x.Message;
                return null;
            }
            catch ( Exception x ) {
                exceptionMessage = x.Message;
                return null;
            }

            return convertees;
        }

        private bool ValidateThatProvidedProbabilitiesSumUpToOneness( int symbolsAlphabetCount, List<double> probabilities )
        {
            double sum = 0.0;
            const double CIRCUMSCRIPTION = 1E-5;
            const double BASE_NUMBER = 1.0000;
            const double RIGHT_CIRCUMSCRIPTION = BASE_NUMBER + CIRCUMSCRIPTION;
            const double LEFT_CIRCUMSCRIPTION = BASE_NUMBER - CIRCUMSCRIPTION;

            for ( int i = 0; i < symbolsAlphabetCount; i++ ) {
                sum += probabilities[i];
            }

            if ( sum >= LEFT_CIRCUMSCRIPTION && sum <= RIGHT_CIRCUMSCRIPTION ) {
                return true;
            }

            return false;
        }

        private Dictionary<int, double> GetCumulativeProbabilities( Dictionary<int, ulong> symbolsAlphabet, List<double> probabilities )
        {
            Dictionary<int, double> cumulativeProbabilities = new Dictionary<int, double>();
            double currentCumulativeProbability = 0.0;
            cumulativeProbabilities.Add( 0, currentCumulativeProbability );
            int i = 0;

            foreach ( var pair in symbolsAlphabet ) {
                currentCumulativeProbability += probabilities[i];
                i++;
                cumulativeProbabilities.Add( pair.Key, currentCumulativeProbability );
            }

            return cumulativeProbabilities;
        }

        private double GetArithmeticCode( Dictionary<int, double> cumulativeProbabilities, string message, out List<double> endBorders )
        {
            int[] symbols;
            double[] probabilities;
            RetrieveKeysAndValues( cumulativeProbabilities, out symbols, out probabilities );
            double leftBorder = 0.0;
            double rightBorder = 1.0;

            for ( int i = 0; i < message.Length; i++ ) {
                double substractor = rightBorder - leftBorder;
                int currentIndex = FindFirstIndexOf( symbols, message[i] );
                double currentLeftBorder = leftBorder + substractor * probabilities[currentIndex - 1];
                double currentRightBorder = leftBorder + substractor * probabilities[currentIndex];
                leftBorder = currentLeftBorder;
                rightBorder = currentRightBorder;
            }

            endBorders = new List<double>() {
                leftBorder, rightBorder
            };

            return (rightBorder - leftBorder) / 2.0;
        }

        private void RetrieveKeysAndValues<T1, T2>( Dictionary<T1, T2> dictionary, out T1[] keys, out T2[] values )
        {
            keys = new T1[dictionary.Count];
            values = new T2[dictionary.Count];
            int i = 0;

            foreach ( var pair in dictionary ) {
                keys[i] = pair.Key;
                values[i] = pair.Value;
                i++;
            }
        }

        private int FindFirstIndexOf<T>( T[] array, T value )
        {
            int index = -1;

            for ( int i = 0; i < array.Length; i++ ) {
                if ( Comparer<T>.Default.Compare( array[i], value ) == 0 ) {
                    return i;
                }
            }

            return index;
        }

        private void UpdateUIWithEncodingResults( double arithmeticCode, List<double> endBorders, TextBox textBox )
        {
            const string DOUBLE_FORMAT = "{0:F4}";
            StringBuilder builder = new StringBuilder();
            builder.Append( "Left border      =  " );
            builder.AppendFormat( DOUBLE_FORMAT, endBorders[0] );
            builder.AppendLine();
            builder.Append( "Right border     =  " );
            builder.AppendFormat( DOUBLE_FORMAT, endBorders[1] );
            builder.AppendLine();
            builder.Append( "Arithmetic code  =  " );
            builder.AppendFormat( DOUBLE_FORMAT, arithmeticCode );
            builder.AppendLine();
            textBox.Text = builder.ToString();
        }

    }
}
