namespace Testproject123
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 10;
            int j = 33;
            int result = i + j;
            int expected = 43;
                Assert.Equal(expected, result);    
 

        }
    }
}