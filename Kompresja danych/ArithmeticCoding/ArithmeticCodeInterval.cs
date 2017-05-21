namespace ArithmeticCoding
{
    internal class ArithmeticCodeInterval
    {

        public char Symbol { get; private set; }
        public uint Interval { get; private set; }

        public ArithmeticCodeInterval( char symbol, uint intervalNumber )
        {
            Symbol = symbol;
            Interval = intervalNumber;
        }

    }
}
