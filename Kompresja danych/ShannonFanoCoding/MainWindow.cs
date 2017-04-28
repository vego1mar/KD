using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ShannonFanoCoding
{
    public partial class MainWindow : Form
    {

        private char[] Symbols { get; set; }
        private ulong[] Units { get; set; }
        private StringBuilder[] Code { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WfBuildCodeButton_Click( object sender, EventArgs e )
        {
            Dictionary<char, ulong> unsortedSourceUnits = CountSourceUnits( wfInputTextBox.Text );
            Dictionary<char, ulong> sourceUnits = GetSortedSourceUnits( unsortedSourceUnits );
            PreparePropertiesForShannonFanoSplit( sourceUnits.Count, sourceUnits );
            PerformShannonFanoSplit( sourceUnits );
            BuildAndOutputResult( wfOutputTextBox, wfInputTextBox.Text );
        }

        private Dictionary<char, ulong> CountSourceUnits( string sourceMessage )
        {
            int[] symbols = new int[Char.MaxValue];
            Dictionary<char, ulong> sourceUnits = new Dictionary<char, ulong>();

            foreach ( char symbol in sourceMessage ) {
                symbols[symbol]++;
            }

            for ( int i = 0; i < symbols.Length; i++ ) {
                if ( symbols[i] != 0 ) {
                    sourceUnits.Add( Convert.ToChar( i ), Convert.ToUInt64( symbols[i] ) );
                }
            }

            return sourceUnits;
        }

        private Dictionary<char, ulong> GetSortedSourceUnits( Dictionary<char, ulong> unsortedSourceUnits )
        {
            Dictionary<char, ulong> sortedSourceUnits = new Dictionary<char, ulong>();
            char[] symbols = new char[unsortedSourceUnits.Count];
            ulong[] units = new ulong[unsortedSourceUnits.Count];
            int i = 0;

            foreach ( var pair in unsortedSourceUnits ) {
                symbols[i] = pair.Key;
                units[i] = pair.Value;
                i++;
            }

            for ( i = 0; i < symbols.Length; i++ ) {
                for ( int j = 0; j < units.Length - 1; j++ ) {
                    if ( units[j] < units[j + 1] ) {
                        ulong lhsUnit = units[j];
                        units[j] = units[j + 1];
                        units[j + 1] = lhsUnit;
                        char lhsSymbol = symbols[j];
                        symbols[j] = symbols[j + 1];
                        symbols[j + 1] = lhsSymbol;
                    }
                }
            }

            for ( i = 0; i < symbols.Length; i++ ) {
                sortedSourceUnits.Add( symbols[i], units[i] );
            }

            return sortedSourceUnits;
        }

        private void PerformShannonFanoSplit( Dictionary<char, ulong> source )
        {
            if ( source.Count > 1 ) {
                Dictionary<char, ulong> leftSource;
                Dictionary<char, ulong> rightSource;
                DivideSourceToAboutSameUnits( source, out leftSource, out rightSource );
                BuildShannonFanoCode( leftSource, '0' );
                BuildShannonFanoCode( rightSource, '1' );
                PerformShannonFanoSplit( leftSource );
                PerformShannonFanoSplit( rightSource );
            }
        }

        private void PreparePropertiesForShannonFanoSplit( int sourceSize, Dictionary<char, ulong> source )
        {
            Symbols = new char[sourceSize];
            Units = new ulong[sourceSize];
            Code = new StringBuilder[sourceSize];

            for ( int i = 0; i < Code.Length; i++ ) {
                Code[i] = new StringBuilder();
            }

            CopyDictionaryContentIntoPropertiesArrays( source );
        }

        private void CopyDictionaryContentIntoPropertiesArrays( Dictionary<char, ulong> source )
        {
            int i = 0;

            foreach ( var pair in source ) {
                Symbols[i] = pair.Key;
                Units[i] = pair.Value;
                i++;
            }
        }

        private void DivideSourceToAboutSameUnits( Dictionary<char, ulong> source, out Dictionary<char, ulong> leftSource, out Dictionary<char, ulong> rightSource )
        {
            leftSource = new Dictionary<char, ulong>();
            rightSource = new Dictionary<char, ulong>();
            DictionarySuccessor forwarder = new DictionarySuccessor( source );
            DictionaryDesuccessor backwarder = new DictionaryDesuccessor( source );

            if ( source == null ) {
                return;
            }

            if ( source.Count == 1 ) {
                leftSource = source;
                rightSource = null;
            }

            while ( forwarder.Index + 1 != backwarder.Index ) {
                if ( forwarder.Sum < backwarder.Sum ) {
                    forwarder.TraverseNext();
                }
                else {
                    backwarder.TraversePrevious();
                }
            }

            leftSource = forwarder.BuildDictionary();
            rightSource = backwarder.BuildDictionary();
        }

        private void BuildShannonFanoCode( Dictionary<char, ulong> source, char codeDigit )
        {
            foreach ( var pair in source ) {
                int index = RetrieveSymbolIndexInPropertiesArray( pair.Key );
                Code[index].Append( codeDigit );
            }
        }

        private int RetrieveSymbolIndexInPropertiesArray( char symbol )
        {
            for ( int i = 0; i < Symbols.Length; i++ ) {
                if ( Symbols[i] == symbol ) {
                    return i;
                }
            }

            return -1;
        }

        private void BuildAndOutputResult( TextBox textBox, string sourceMessage )
        {
            StringBuilder builder = new StringBuilder();
            const char TABULATOR = '\t';

            for ( int i = 0; i < Symbols.Length; i++ ) {
                builder.Append( Symbols[i].ToString() + TABULATOR + Units[i].ToString() + TABULATOR + Code[i].ToString() );
                builder.AppendLine();
            }

            builder.AppendLine();

            foreach ( char symbol in sourceMessage ) {
                int index = RetrieveSymbolIndexInPropertiesArray( symbol );
                builder.Append( Code[index].ToString() );
            }

            builder.AppendLine();
            textBox.Text = builder.ToString();
        }

    }
}
