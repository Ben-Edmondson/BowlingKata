using Bowling;

namespace BowlingTests
{
    public class RollingTest
    {
        [Test]
        public void IsRollNotNull()
        {
            // Arrange
            int roll = Rolling.IndividualRoll();
            // Act

            // Assert
            Assert.NotNull(roll);
        }
        [Test]
        public void IsSecondRollNotNull()
        {
            // Arrange
            int secondRoll = Rolling.SecondRoll(Rolling.IndividualRoll());
            // Act

            // Assert
            Assert.NotNull(secondRoll);
        }
    }
}