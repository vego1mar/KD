namespace ArithmeticCoding
{
    internal class ArithmeticCodeBorders
    {

        public double LeftBorder { get; private set; }
        public double RightBorder { get; private set; }

        public ArithmeticCodeBorders( double left, double right )
        {
            LeftBorder = left;
            RightBorder = right;
        }

    }
}
