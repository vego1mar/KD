using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Entropia
{
    public partial class MainWindow : Form
    {

        private int[] Symbols { get; set; }
        private int[] Occurences { get; set; }
        private double[] Probabilities { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WfButtonCalculate_Click( object sender, EventArgs e )
        {
            ISet<char> setOfSymbols = GainSetOfSymbols( wfTextBoxInput.Text );
            Dictionary<char, int> setOfSymbolsOccurences = GainSymbolsOccurences( wfTextBoxInput.Text, setOfSymbols );
            long numberOfAllSymbols = GainNumberOfAllSymbols( setOfSymbolsOccurences );
            AggregateDataForEntropyCounting( setOfSymbolsOccurences, numberOfAllSymbols );
            OutputEntropyCountingResult( CountEntropy(), numberOfAllSymbols );
        }

        private void WfButtonClear_Click( object sender, EventArgs e )
        {
            wfTextBoxInput.Clear();
            wfTextBoxOutput.Clear();
        }

        private Dictionary<char, int> GainSymbolsOccurences( string message, ISet<char> setOfSymbols )
        {
            Dictionary<char, int> setOfSymbolsOccurences = new Dictionary<char, int>();
            int[] numberOfSymbols = new int[512];

            foreach ( char symbol in message ) {
                if ( setOfSymbols.Contains( symbol ) ) {
                    numberOfSymbols[symbol]++;
                }
            }

            for ( int i = 0; i < numberOfSymbols.Length; i++ ) {
                if ( numberOfSymbols[i] != 0 ) {
                    setOfSymbolsOccurences.Add( Convert.ToChar( i ), numberOfSymbols[i] );
                }
            }

            return setOfSymbolsOccurences;
        }

        private ISet<char> GainSetOfSymbols( string message )
        {
            ISet<char> setOfSymbols = new HashSet<char>();

            foreach ( char symbol in message ) {
                if ( !setOfSymbols.Contains( symbol ) ) {
                    setOfSymbols.Add( symbol );
                }
            }

            return setOfSymbols;
        }

        private long GainNumberOfAllSymbols( Dictionary<char, int> setOfSymbolsOccurences )
        {
            long numberOfAllSymbols = 0;

            foreach ( var pair in setOfSymbolsOccurences ) {
                numberOfAllSymbols += pair.Value;
            }

            return numberOfAllSymbols;
        }

        private void AggregateDataForEntropyCounting( Dictionary<char, int> setOfSymbolsOccurences, long numberOfAllSymbols )
        {
            Symbols = new int[setOfSymbolsOccurences.Count];
            Occurences = new int[setOfSymbolsOccurences.Count];
            Probabilities = new double[setOfSymbolsOccurences.Count];
            int i = 0;

            foreach ( var pair in setOfSymbolsOccurences ) {
                Symbols[i] = pair.Key;
                Occurences[i] = pair.Value;
                Probabilities[i] = Convert.ToDouble( pair.Value ) / Convert.ToDouble( numberOfAllSymbols );
                i++;
            }
        }

        private double CountEntropy()
        {
            double entropy = 0.0;
            double partialSum;
            const double LOGARITHM_BASE = 2.0;

            for ( int i = 0; i < Symbols.Length; i++ ) {
                partialSum = Probabilities[i] * Math.Log( Probabilities[i], LOGARITHM_BASE );
                entropy += partialSum;
            }

            return -entropy;
        }

        private void OutputEntropyCountingResult( double entropy, long numberOfAllSymbols )
        {
            StringBuilder builder = new StringBuilder();
            builder.Append( "Entropy = " + entropy );
            builder.AppendLine();

            for ( int i = 0; i < Symbols.Length; i++ ) {
                char currentSymbol = Convert.ToChar( Symbols[i] );
                string currentProbability = String.Format( "{0:0.0000}", Probabilities[i] );
                builder.Append( "p(" + currentSymbol + ") = " + Occurences[i] + "/" + numberOfAllSymbols + " = " + currentProbability );
                builder.AppendLine();
            }

            wfTextBoxOutput.Text = builder.ToString();
        }

    }
}
