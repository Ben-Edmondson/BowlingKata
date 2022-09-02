using Bowling;

namespace BowlingTests
{
    public class RollingTest
    {
        //test types and if null
        [Test]
        public void IsRollNull()
        {
            // Arrange
            int roll = Rolling.IndividualRoll();
            // Act

            // Assert
            Assert.NotNull(roll);
        }
        [Test]
        public void IsSecondRollNull()
        {
            // Arrange
            int secondRoll = Rolling.SecondRoll(Rolling.IndividualRoll());
            // Act

            // Assert
            Assert.NotNull(secondRoll);
        }
    }
}