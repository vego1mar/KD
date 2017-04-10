using System.Collections.Generic;

namespace HuffmanCoding
    {
    class HuffmanPriorityQueue
        {

        #region Properties
        private List<HuffmanNode> PriorityQueue { set; get; }
        #endregion

        #region HuffmanPriorityQueue()
        public HuffmanPriorityQueue()
            {
            SetDefaultPropertiesValues();
            }
        #endregion

        #region SetDefaultPropertiesValues() : void
        private void SetDefaultPropertiesValues()
            {
            PriorityQueue = new List<HuffmanNode>();
            PriorityQueue.Clear();
            }
        #endregion

        #region Insert(...) : void
        public void Insert( HuffmanNode node )
            {
            PriorityQueue.Add( node );
            }
        #endregion

        #region GetMinimumNode() : HuffmanNode
        public HuffmanNode GetMinimumNode()
            {
            return PriorityQueue[ GetMinimumNodeIndex() ];
            }
        #endregion

        #region GetMinimumNodeIndex() : int
        private int GetMinimumNodeIndex()
            {
            int minimumNodeIndex = 0;
            double minimumNodeValue = PriorityQueue[0].Frequency;

            for ( int i=1; i<PriorityQueue.Count; i++ ) {
                if ( PriorityQueue[i].Frequency < minimumNodeValue ) {
                    minimumNodeIndex = i;
                    minimumNodeValue = PriorityQueue[i].Frequency;
                    }
                }

            return minimumNodeIndex;
            }
        #endregion

        #region DeleteMinimumNode() : void
        public void DeleteMinimumNode()
            {
            PriorityQueue.RemoveAt( GetMinimumNodeIndex() );
            }
        #endregion

        }
    }
