using System;
using System.Text;
using System.Collections.Generic;

namespace HuffmanCoding
    {
    class HuffmanTree
        {

        #region Properties
        public Dictionary<char, double> AlphabetOfFrequencies { get; private set; }
        private HuffmanPriorityQueue TreeQueue { get; set; }
        #endregion

        #region HuffmanTree()
        public HuffmanTree()
            {
            SetDefaultPropertiesValues();
            }
        #endregion

        #region SetDefaultPropertiesValues() : void
        private void SetDefaultPropertiesValues()
            {
            AlphabetOfFrequencies = new Dictionary<char, double>();
            TreeQueue = new HuffmanPriorityQueue();
            }
        #endregion

        #region Encode(...) : string
        public string Encode( string message )
            {
            BuildAlphabetFromMessage( message );
            BuildHuffmanCodeTree();
            return EncodeMessageUsingBuildedHuffmanCodeTree( message );
            }
        #endregion

        #region BuildAlphabetFromMessage(...) : void
        private void BuildAlphabetFromMessage( string message )
            {
            AlphabetOfFrequencies.Clear();

            const uint LEFT_LIMIT = 0x20;
            const uint RIGHT_LIMIT = 0x7F;
            int [] symbols = new int [ 512 ];
            uint numberOfUniqueSymbols = 0;

            foreach ( var symbol in message ) {
                symbols[ Convert.ToInt32(symbol) ]++;
                }

            for ( uint i=LEFT_LIMIT; i<RIGHT_LIMIT; i++ ) {
                if ( symbols[i] != 0 ) {
                    numberOfUniqueSymbols++;
                    }
                }

            for ( uint i=LEFT_LIMIT; i<RIGHT_LIMIT; i++ ) {
                if ( symbols[i] != 0 ) {
                    double frequency = ( Convert.ToDouble(symbols[i]) / Convert.ToDouble(message.Length) ) * 100.0;
                    char symbol = Convert.ToChar( i );
                    AlphabetOfFrequencies.Add( symbol, frequency );
                    }
                }
            }
        #endregion

        #region BuildHuffmanCodeTree() : void
        private void BuildHuffmanCodeTree()
            {
            TreeQueue.ClearQueue();
            InsertDictionaryPairsAsLeafsOfTreePriorityQueue();
            ProceedWithHuffmanCodeTreeBuilding();
            }
        #endregion

        #region InsertDictionaryPairsAsLeafsOfTreePriorityQueue() : void
        private void InsertDictionaryPairsAsLeafsOfTreePriorityQueue()
            {
            foreach ( var pair in AlphabetOfFrequencies ) {
                HuffmanNode node = new HuffmanNode();
                node.Symbol = pair.Key;
                node.Frequency = pair.Value;
                node.LeftNode = null;
                node.RightNode = null;
                TreeQueue.Insert( node );
                }
            }
        #endregion

        #region ProceedWithHuffmanCodeTreeBuilding() : void
        private void ProceedWithHuffmanCodeTreeBuilding()
            {
            for ( int i=0; i<AlphabetOfFrequencies.Count - 1; i++ ) {
                HuffmanNode node = new HuffmanNode();
                node.LeftNode = TreeQueue.GetMinimumNode();
                TreeQueue.DeleteMinimumNode();
                node.RightNode = TreeQueue.GetMinimumNode();
                TreeQueue.DeleteMinimumNode();
                node.Symbol = HuffmanNode.DEFAULT_SYMBOL;
                node.Frequency = node.LeftNode.Frequency + node.RightNode.Frequency;
                TreeQueue.Insert( node );
                }
            }
        #endregion

        #region EncodeMessageUsingBuildedHuffmanCodeTree(...) : string
        private string EncodeMessageUsingBuildedHuffmanCodeTree( string message )
            {
            Dictionary<char,string> dictionary = TreeQueue.TraverseQueueForGainingLeafs();
            StringBuilder encodedMessage = new StringBuilder();
            string symbolHuffmanCode;

            foreach ( var symbol in message ) {
                dictionary.TryGetValue( symbol, out symbolHuffmanCode );
                encodedMessage.Append( symbolHuffmanCode );
                }

            return encodedMessage.ToString();
            }
        #endregion

        #region GetLastLeafs() : Dictionary<char,string>
        public Dictionary<char,string> GetLastLeafs()
            {
            return TreeQueue.Leafs;
            }
        #endregion

        #region Decode(...) : string
        [Obsolete]
        public string Decode( string text )
            {
            int searchingStringLength = GetMaximumStringLengthFromLeafs();
            int nextPositionInText = 0;
            StringBuilder decodedMessage = new StringBuilder();

            while ( nextPositionInText < text.Length ) {
                int currentValidLength = searchingStringLength;

                while ( currentValidLength > 0 ) {
                    string codedSample = text.Substring( nextPositionInText, currentValidLength );
                    char codedSymbol;

                    if ( IsHuffmanCodeInCodingSet(codedSample, out codedSymbol) ) {
                        decodedMessage.Append( codedSymbol );
                        nextPositionInText += currentValidLength;
                        }

                    currentValidLength--;
                    }
                }

            return null;
            }
        #endregion

        #region GetMaximumStringLengthFromLeafs() : int
        private int GetMaximumStringLengthFromLeafs()
            {
            int maximumLength = 0;

            foreach ( var pair in TreeQueue.Leafs ) {
                if ( pair.Value.Length > maximumLength ) {
                    maximumLength = pair.Value.Length;
                    }
                }

            return maximumLength;
            }
        #endregion

        #region IsHuffmanCodeInCodingSet(...) : bool
        [Obsolete]
        private bool IsHuffmanCodeInCodingSet( string huffmanCode, out char symbol )
            {
            symbol = '\0';
            string code;

            for ( int i=0x20; i<0x7F; i++ ) {
                if ( TreeQueue.Leafs.TryGetValue(Convert.ToChar( i ), out code) && code == huffmanCode ) {
                    symbol = Convert.ToChar( i );
                    return true;
                    }
                }

            return false;
            }
        #endregion

        }
    }
