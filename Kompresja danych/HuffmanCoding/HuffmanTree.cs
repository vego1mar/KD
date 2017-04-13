using System;
using System.Text;
using System.Collections.Generic;

namespace HuffmanCoding
{
    class HuffmanTree
    {

        #region Constants
        public const uint ALPHABET_LOWER_LIMIT = 0x20;
        public const uint ALPHABET_UPPER_LIMIT = 0x7F;
        #endregion

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

            int[] symbols = new int[512];
            uint numberOfUniqueSymbols = 0;

            foreach ( var symbol in message ) {
                symbols[Convert.ToInt32( symbol )]++;
            }

            for ( uint i = ALPHABET_LOWER_LIMIT; i < ALPHABET_UPPER_LIMIT; i++ ) {
                if ( symbols[i] != 0 ) {
                    numberOfUniqueSymbols++;
                }
            }

            for ( uint i = ALPHABET_LOWER_LIMIT; i < ALPHABET_UPPER_LIMIT; i++ ) {
                if ( symbols[i] != 0 ) {
                    double frequency = (Convert.ToDouble( symbols[i] ) / Convert.ToDouble( message.Length )) * 100.0;
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
            for ( int i = 0; i < AlphabetOfFrequencies.Count - 1; i++ ) {
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
            Dictionary<char, string> dictionary = TreeQueue.TraverseQueueForGainingLeafs();
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
        public Dictionary<char, string> GetLastLeafs()
        {
            return TreeQueue.Leafs;
        }
        #endregion

        #region Decode(...) : string
        public string Decode( string text )
        {
            if ( TreeQueue.Leafs.Count == 0 ) {
                return null;
            }

            int bitsNumber;
            int nextPositionInText = 0;
            string huffmanCode;
            StringBuilder decodedMessage = new StringBuilder();
            char symbol;

            while ( nextPositionInText < text.Length ) {
                bitsNumber = 1;
                huffmanCode = text.Substring( nextPositionInText, bitsNumber );

                while ( !IsHuffmanCodeInCodingSet( huffmanCode, out symbol ) ) {
                    bitsNumber++;
                    huffmanCode = text.Substring( nextPositionInText, bitsNumber );
                }

                nextPositionInText += bitsNumber;
                decodedMessage.Append( symbol );
            }

            return decodedMessage.ToString();
        }
        #endregion

        #region IsHuffmanCodeInCodingSet(...) : bool
        private bool IsHuffmanCodeInCodingSet( string huffmanCode, out char symbol )
        {
            symbol = '\0';

            for ( uint i = ALPHABET_LOWER_LIMIT; i < ALPHABET_UPPER_LIMIT; i++ ) {
                if ( TreeQueue.Leafs.TryGetValue( Convert.ToChar( i ), out string code ) && code == huffmanCode ) {
                    symbol = Convert.ToChar( i );
                    return true;
                }
            }

            return false;
        }
        #endregion

    }
}
