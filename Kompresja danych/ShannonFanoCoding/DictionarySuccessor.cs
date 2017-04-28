using System.Collections.Generic;

namespace ShannonFanoCoding
{
    class DictionarySuccessor
    {

        private int Counts { get; set; }
        private char[] Keys { get; set; }
        private ulong[] Values { get; set; }
        public int Index { get; private set; }
        public ulong Sum { get; private set; }

        public DictionarySuccessor( Dictionary<char, ulong> dictionary )
        {
            if ( dictionary.Count != 0 ) {
                Counts = dictionary.Count;
                Keys = new char[dictionary.Count];
                Values = new ulong[dictionary.Count];
                Index = 0;
                CopyDictionaryContentToArrays( dictionary );
                Sum = Values[0];
            }
            else {
                Counts = 0;
                Keys = null;
                Values = null;
                Index = -1;
                Sum = 0;
            }
        }

        void CopyDictionaryContentToArrays( Dictionary<char, ulong> dictionary )
        {
            int i = 0;

            foreach ( var pair in dictionary ) {
                Keys[i] = pair.Key;
                Values[i] = pair.Value;
                i++;
            }
        }

        Dictionary<char, ulong> CopyArraysContentIntoDictionary()
        {
            Dictionary<char, ulong> dictionary = new Dictionary<char, ulong>();

            for ( int i = 0; i <= Index; i++ ) {
                dictionary.Add( Keys[i], Values[i] );
            }

            return dictionary;
        }

        public bool TraverseNext()
        {
            if ( Index + 1 < Counts ) {
                Index++;
                Sum += Values[Index];
                return true;
            }

            return false;
        }

        public Dictionary<char, ulong> BuildDictionary()
        {
            return CopyArraysContentIntoDictionary();
        }

    }
}
