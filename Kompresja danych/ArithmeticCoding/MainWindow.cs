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
            TextBox[] providers = { txbCoderInputP1, txbCoderInputP2, txbCoderInputP3, txbCoderInputP4, txbCoderInputP5 };
            Dictionary<int, ulong> symbolsAlphabet = GetAlphabetOfOccurences( txbCoderInputBoard.Text );
            List<double> convertees;

            if ( !IsInputDataValidated( providers, symbolsAlphabet.Count, out convertees, true ) ) {
                return;
            }

            Dictionary<int, double> cumulativeProbabilities = GetCumulativeProbabilities( symbolsAlphabet, convertees );
            List<ArithmeticCodeBorders> borders;
            double marker = GetArithmeticCodeMarker( cumulativeProbabilities, txbCoderInputBoard.Text, out borders );
            UpdateUIWithEncodingResults( marker, borders, txbCoderOutputBoard );
            UpdateUIInDecoderTabPage( marker );
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
                txbCoderTextP1, txbCoderTextP2, txbCoderTextP3, txbCoderTextP4, txbCoderTextP5
            };

            int j = 0;

            foreach ( var pair in coderInputBoardAlphabet ) {
                informees[j].Text = "p" + (j + 1).ToString() + " (" + Convert.ToChar( pair.Key ) + ") = ";
                j++;
            }

            for ( int i = j; i < informees.Length; i++ ) {
                informees[i].Text = "p" + (i + 1).ToString() + " = ";
            }

            TextBox[] decoderInformees = {
                txbDecoderTextP1, txbDecoderTextP2, txbDecoderTextP3, txbDecoderTextP4, txbDecoderTextP5
            };

            for ( int i = 0; i < decoderInformees.Length; i++ ) {
                decoderInformees[i].Text = informees[i].Text;
            }
        }

        private void SetCursorAtEnd( TextBox textBox )
        {
            textBox.SelectionStart = Math.Max( 0, textBox.Text.Length );
            textBox.SelectionLength = 0;
        }

        private List<double> ValidateThatProvidedProbabilitiesAreNumbers( out string exceptionMessage, int symbolsAlphabetCount, TextBox[] providers )
        {
            exceptionMessage = null;
            List<double> convertees = new List<double>();

            try {
                for ( int i = 0; i < symbolsAlphabetCount; i++ ) {
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

        private double GetArithmeticCodeMarker( Dictionary<int, double> cumulativeProbabilities, string message, out List<ArithmeticCodeBorders> borders )
        {
            int[] symbols;
            double[] probabilities;
            RetrieveKeysAndValues( cumulativeProbabilities, out symbols, out probabilities );
            double leftBorder = 0.0;
            double rightBorder = 1.0;
            borders = new List<ArithmeticCodeBorders>();
            borders.Add( new ArithmeticCodeBorders( leftBorder, rightBorder ) );

            for ( int i = 0; i < message.Length; i++ ) {
                double substractor = rightBorder - leftBorder;
                int currentIndex = FindFirstIndexOf( symbols, message[i] );
                double currentLeftBorder = leftBorder + substractor * probabilities[currentIndex - 1];
                double currentRightBorder = leftBorder + substractor * probabilities[currentIndex];
                leftBorder = currentLeftBorder;
                rightBorder = currentRightBorder;
                borders.Add( new ArithmeticCodeBorders( leftBorder, rightBorder ) );
            }

            return (rightBorder + leftBorder) / 2.0;
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

        private void UpdateUIWithEncodingResults( double arithmeticCode, List<ArithmeticCodeBorders> borders, TextBox textBox )
        {
            const string DOUBLE_FORMAT = "{0:F16}";
            StringBuilder builder = new StringBuilder();
            builder.Append( "Marker = " );
            builder.AppendFormat( DOUBLE_FORMAT, arithmeticCode );
            builder.AppendLine();
            builder.AppendLine();

            foreach ( var interval in borders ) {
                builder.Append( "< " );
                builder.AppendFormat( DOUBLE_FORMAT, interval.LeftBorder );
                builder.Append( " ; " );
                builder.AppendFormat( DOUBLE_FORMAT, interval.RightBorder );
                builder.Append( " )" );
                builder.AppendLine();
            }

            textBox.Text = builder.ToString();
        }

        private void UpdateUIInDecoderTabPage( double marker )
        {
            txbDecoderMarkerInput.Text = marker.ToString();
            txbDecoderSourceLengthInput.Text = txbCoderInputBoard.Text.Length.ToString();
            txbDecoderInputP1.Text = txbCoderInputP1.Text;
            txbDecoderInputP2.Text = txbCoderInputP2.Text;
            txbDecoderInputP3.Text = txbCoderInputP3.Text;
            txbDecoderInputP4.Text = txbCoderInputP4.Text;
            txbDecoderInputP5.Text = txbCoderInputP5.Text;
        }

        private void BtnDecoderDecode_Click( object sender, EventArgs e )
        {
            TextBox[] providers = { txbDecoderInputP1, txbDecoderInputP2, txbDecoderInputP3, txbDecoderInputP4, txbDecoderInputP5 };
            TextBox[] decodingSpecificProviders = { txbDecoderMarkerInput, txbDecoderSourceLengthInput };
            Dictionary<int, ulong> symbolsAlphabet = GetAlphabetOfOccurences( txbCoderInputBoard.Text );
            List<double> convertees;
            List<double> decodingSpecificConvertees;

            if ( !IsInputDataValidated( providers, symbolsAlphabet.Count, out convertees, true ) ) {
                return;
            }

            if ( !IsInputDataValidated( decodingSpecificProviders, decodingSpecificProviders.Length, out decodingSpecificConvertees, false ) ) {
                return;
            }

            double marker = decodingSpecificConvertees[0];
            ulong sourceLength = Convert.ToUInt64( decodingSpecificConvertees[1] );
            int[] keys;
            ulong[] values;
            RetrieveKeysAndValues( symbolsAlphabet, out keys, out values );
            txbDecoderOutputBoard.Text = GetArithmeticCodeMessage( marker, sourceLength, convertees, keys );
        }

        private bool IsInputDataValidated( TextBox[] textProviders, int symbolsAlphabetCount, out List<double> convertees, bool isOnenessChecked )
        {
            string exceptionInfo;
            convertees = ValidateThatProvidedProbabilitiesAreNumbers( out exceptionInfo, symbolsAlphabetCount, textProviders );

            if ( convertees == null ) {
                string text = "A problem with number convertion:" + Environment.NewLine + exceptionInfo;
                string caption = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            if ( isOnenessChecked && !ValidateThatProvidedProbabilitiesSumUpToOneness( symbolsAlphabetCount, convertees ) ) {
                string text = "The provided probabilities are not sum up to oneness.";
                string caption = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show( text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return false;
            }

            return true;
        }

        private string GetArithmeticCodeMessage( double marker, ulong sourceLength, List<double> probabilities, int[] symbols )
        {
            double[] currentIntervalPoints = new double[probabilities.Count + 1];
            currentIntervalPoints[0] = 0.0;
            double currentCumulativeSum = 0.0;
            StringBuilder builder = new StringBuilder();
            double[] cumulativeIntervals = new double[currentIntervalPoints.Length];

            for ( int i = 0; i < probabilities.Count; i++ ) {
                currentCumulativeSum += probabilities[i];
                currentIntervalPoints[i + 1] = currentCumulativeSum;
            }

            CopyArrayInto( currentIntervalPoints, cumulativeIntervals );
            ArithmeticCodeInterval nextSymbol = SpecifySymbolAndIntervalNumberByClassifyingMarker( marker, currentIntervalPoints, symbols );
            builder.Append( nextSymbol.Symbol );

            for ( ulong i = 0; i < sourceLength - 1; i++ ) {
                currentIntervalPoints[0] = currentIntervalPoints[nextSymbol.Interval];
                currentIntervalPoints[currentIntervalPoints.Length - 1] = currentIntervalPoints[nextSymbol.Interval + 1];

                for ( int j = 1; j < currentIntervalPoints.Length - 1; j++ ) {
                    double intervalLength = currentIntervalPoints[currentIntervalPoints.Length - 1] - currentIntervalPoints[0];
                    currentIntervalPoints[j] = cumulativeIntervals[j] * intervalLength + currentIntervalPoints[0];
                }

                nextSymbol = SpecifySymbolAndIntervalNumberByClassifyingMarker( marker, currentIntervalPoints, symbols );
                builder.Append( nextSymbol.Symbol );
            }

            return builder.ToString();
        }

        private ArithmeticCodeInterval SpecifySymbolAndIntervalNumberByClassifyingMarker( double marker, double[] intervalPoints, int[] symbols )
        {
            for ( int i = 0; i < intervalPoints.Length - 1; i++ ) {
                if ( marker >= intervalPoints[i] && marker <= intervalPoints[i + 1] ) {
                    char symbol = Convert.ToChar( symbols[i] );
                    uint interval = Convert.ToUInt32( i );
                    return new ArithmeticCodeInterval( symbol, interval );
                }
            }

            return null;
        }

        private void CopyArrayInto<T>( T[] source, T[] target )
        {
            for ( int i = 0; i < source.Length; i++ ) {
                target[i] = source[i];
            }
        }

    }
}
