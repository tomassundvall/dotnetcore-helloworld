using System;
using HelloWorld;
using Xunit;

namespace Test.Unit.HelloWorld
{
    public class SimpleFunctionUnitTest
    {
        [Fact]
        public void VerifyThatTheFunctionReturnsTen()
        {
            // ----------- SETUP -------------------------
            var instance = new SimpleFunction(15);


            // ----------- EXECUTE ------------------------            
            int result = instance.GetExpectedNumber();
            

            // ----------- VALIDATE ------------------------
            Assert.Equal<int>(15, result);
        }
    }
}
