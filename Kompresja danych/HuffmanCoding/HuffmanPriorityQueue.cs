using System.Collections.Generic;
using System.Text;

namespace HuffmanCoding
{
    class HuffmanPriorityQueue
    {

        #region Properties
        private List<HuffmanNode> PriorityQueue { set; get; }
        private StringBuilder HuffmanCodeBuilder { set; get; }
        public Dictionary<char, string> Leafs { private set; get; } 
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
            HuffmanCodeBuilder = new StringBuilder( 0 );
            Leafs = new Dictionary<char, string>();
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
            return PriorityQueue[GetMinimumNodeIndex()];
        }
        #endregion

        #region GetMinimumNodeIndex() : int
        private int GetMinimumNodeIndex()
        {
            int minimumNodeIndex = 0;
            double minimumNodeValue = PriorityQueue[0].Frequency;

            for ( int i = 1; i < PriorityQueue.Count; i++ ) {
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

        #region ClearQueue() : void
        public void ClearQueue()
        {
            PriorityQueue.Clear();
        }
        #endregion

        #region TraverseQueueForGainingLeafs() : Dictionary<char,string>
        public Dictionary<char, string> TraverseQueueForGainingLeafs()
        {
            HuffmanCodeBuilder.Clear();
            Leafs.Clear();
            HuffmanNode root = PriorityQueue[0];
            TraverseInOrder( root );
            return Leafs;
        }
        #endregion

        #region TraverseInOrder(...) : void
        private void TraverseInOrder( HuffmanNode node )
        {
            if ( node.LeftNode != null ) {
                HuffmanCodeBuilder.Append( '0' );
                TraverseInOrder( node.LeftNode );
            }

            if ( node.Symbol != HuffmanNode.DEFAULT_SYMBOL ) {
                Leafs.Add( node.Symbol, HuffmanCodeBuilder.ToString() );
            }

            if ( node.RightNode != null ) {
                HuffmanCodeBuilder.Append( '1' );
                TraverseInOrder( node.RightNode );
            }

            if ( node != GetRoot() ) {
                HuffmanCodeBuilder.Remove( HuffmanCodeBuilder.Length - 1, 1 );
            }
        }
        #endregion

        #region GetRoot() : HuffmanNode
        private HuffmanNode GetRoot()
        {
            return PriorityQueue[0];
        }
        #endregion

    }
}
