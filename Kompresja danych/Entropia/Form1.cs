using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Entropia
{
    public partial class WfMainForm : Form
    {

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Main window initialization.
        /// </summary>

        public WfMainForm()
            {
            InitializeComponent();
            }

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Invoked when the main window is formed.
        /// </summary>
        /// <param name="sender">An object that caused this action.</param>
        /// <param name="e">Additional information provided about this event.</param>

        private void Form1_Load( object sender, EventArgs e )
            {
            // Created by Designer.
            }

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Invoked when 'Calculate' button is clicked.
        /// </summary>
        /// <param name="sender">An object that caused of button click.</param>
        /// <param name="e">Additional information provided about button click.</param>

        private void wfButtonCalculate_Click( object sender, EventArgs e )
            {
		    char [] tbCharacters = wfTextBoxInput.Text.ToCharArray();
		    int [] tbAmounts;
            double [] probabilities;
            double entropy;

            GainNumberOfCharacters( tbCharacters, out tbAmounts );
            GainEntropyProbabilities( tbAmounts, out probabilities, tbCharacters.Length );
            entropy = CountEntropy( tbCharacters, probabilities );
            wfTextBoxOutput.AppendText( "Entropy = " + entropy + Environment.NewLine );
            AppendProbabilitiesToTextBoxOutput( tbCharacters, probabilities );
            }

    //______________________________________________________________________________________________________________

        /// <summary>
        /// Counts the number of characters occurances from 'characters' to the 'amounts'. 
        /// It uses ASCII codes of characters as indices.
        /// </summary>
        /// <param name="characters">Set of characters to check.</param>
        /// <param name="amounts">Set of digits, initially zero, to store the numbers of corresponding characters.</param>

        private void GainNumberOfCharacters( char [] characters, out int [] amounts )
            {
            amounts = new int [ 512 ];

            for ( int i=0; i<characters.Length; i++ ) {
			    amounts[ Math.Abs(characters[i]) ]++;
			    }
            }

    //______________________________________________________________________________________________________________

        /// <summary>
        /// Counts the partial probabilities needed to count the entropy of the source of characters.
        /// </summary>
        /// <param name="amounts">A set with the numbers of corresponding characters.</param>
        /// <param name="probabilities">A set for storing the partial entropy probabilities.</param>
        /// <param name="numberOfCharacters">The number of characters in the entropy source.</param>

        private void GainEntropyProbabilities( int [] amounts, out double [] probabilities, int numberOfCharacters )
            {
            probabilities = new double [ amounts.Length ];

		    for ( int i=0; i<probabilities.Length; i++ ) {
			    probabilities[i] = Convert.ToDouble(amounts[i]) / Convert.ToDouble(numberOfCharacters);
			    }
            }

    //______________________________________________________________________________________________________________

        /// <summary>
        /// Counts the entropy of the source.
        /// </summary>
        /// <param name="characters">A set of characters that will be treated as an entropy source.</param>
        /// <param name="probabilities">A set with the partial entropy probabilities.</param>
        /// <returns>Entropy of the character-type source.</returns>

        private double CountEntropy( char [] characters, double [] probabilities )
            {
		    double entropy = 0.0;
		    double partialSum;
		    double currentProbability;

		    for ( int i=0; i<characters.Length; i++ ) {
			    currentProbability = probabilities[ Math.Abs(characters[i]) ];
			    partialSum = currentProbability * Math.Log( currentProbability, 2.0 );
			    entropy += partialSum;
			    }

		    return -entropy;
            }

    //______________________________________________________________________________________________________________

        /// <summary>
        /// Appends a text to the Windows Forms component 'wfTextBoxOutput'. 
        /// This text will be lines with probabilities values of the given characters from the entropy source.
        /// </summary>
        /// <param name="characters">A set of characters treated as an entropy source.</param>
        /// <param name="probabilities">A set with the partial entropy counting probabilities.</param>

        private void AppendProbabilitiesToTextBoxOutput( char [] characters, double [] probabilities )
            {
            ISet<char> tbDistinctCharacters = new HashSet<char>();

            for ( int i=0; i<characters.Length; i++ ) {
                tbDistinctCharacters.Add( characters[i] );
                }

            foreach ( var character in tbDistinctCharacters ) {
                double currentProbability = probabilities[ Math.Abs(character) ];
                string currentLine = "p(" + character + ") = " + currentProbability + Environment.NewLine;
                wfTextBoxOutput.AppendText( currentLine );
                }
            }

        //______________________________________________________________________________________________________________

        /// <summary>
        /// Invoked when 'Clear' button is clicked.
        /// </summary>
        /// <param name="sender">An object that caused of button click.</param>
        /// <param name="e">Additional information provided about button click.</param>

        private void wfButtonClear_Click( object sender, EventArgs e )
            {
            wfTextBoxInput.Clear();
            wfTextBoxOutput.Clear();
            }

        //______________________________________________________________________________________________________________

        }
}
