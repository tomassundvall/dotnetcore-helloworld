namespace HelloWorld
{
    public class SimpleFunction
    {
        private int _expectedNumber;

        public SimpleFunction(int expectedNumber)
        {
            _expectedNumber = expectedNumber;
        }

        public int GetExpectedNumber()
        {
            return _expectedNumber;
        }
    }   
}