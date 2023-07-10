using Basic_Learning;

namespace Learn_Test
{
    public class FibonnaciMethodTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(19, 4181)]
        public void Method_Fibonnaci_Return_Correct_Value(int bilangan, int ekspetasi)
        {
            var result = Program.FibonnaciV2(bilangan);

            Assert.Equal(ekspetasi, result);
        }
    }
}