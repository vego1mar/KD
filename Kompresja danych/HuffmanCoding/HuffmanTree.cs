using System;
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
            // TODO: Build a new dictionary of (symbol, Huffman code) based on TreeQueue
            // TODO: Retrieve Huffman code from the new dictionary based on a message
            return null;
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

        }
    }
