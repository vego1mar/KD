namespace HuffmanCoding
{
    class HuffmanNode
    {

        #region Constants
        public const char DEFAULT_SYMBOL = '\r';
        #endregion

        #region Properties
        public char Symbol { get; set; }
        public double Frequency { get; set; }
        public HuffmanNode LeftNode { get; set; }
        public HuffmanNode RightNode { get; set; }
        #endregion

        #region HuffmanNode()
        public HuffmanNode()
        {
            SetDefaultPropertiesValues();
        }
        #endregion

        #region SetDefaultPropertiesValues() : void
        private void SetDefaultPropertiesValues()
        {
            Symbol = DEFAULT_SYMBOL;
            Frequency = 0.0;
            LeftNode = null;
            RightNode = null;
        }
        #endregion

    }
}
