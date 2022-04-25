using Xunit;

namespace Katas.StringCalculator.Tests
{
    public class CalculatorCoreTests
    {
        private CalculatorCore _calculatorCore;
        public CalculatorCoreTests()
        {
            _calculatorCore = new CalculatorCore();
        }

        [Fact]
        public void AddingEmptyStringEqualsZero()
        {
            var init = string.Empty;
            var actual = _calculatorCore.Add(init);
            int expected = 0;
            Assert.Equal(actual, expected);
        }
    }
}
