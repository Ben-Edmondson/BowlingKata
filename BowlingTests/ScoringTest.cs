using Bowling;

namespace BowlingTests
{
    public class ScoringTest
    {
        [Test]
        public void ScoreFinalTestStrike() //Tests if strike was the last thrown
        {
            // Arrange
            List<int> rolls = new List<int> { 7, 0, 2, 4, 3, 4, 8, 0, 4, 0, 6, 0, 7, 2, 8, 1, 5, 1, 10, 0, 2, 3 };
            var result = 77;
            // Act
            var actual = Scoring.ScoreFinal(rolls);

            // Assert
            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        public void ScoreFinalTestSpare() //Tests if spare was the last thrown
        {
            // Arrange
            List<int> rolls = new List<int> { 3, 0, 2, 4, 3, 4, 8, 2, 3, 0, 6, 0, 7, 2, 8, 1, 9, 1, 8, 2, 2 };
            var result = 86;
            // Act
            var actual = Scoring.ScoreFinal(rolls);

            // Assert
            Assert.That(actual, Is.EqualTo(result));
        }

        [Test]
        public void ScoreFinalTestNoSpareOrStrike() //Tests if there was no strike or spare thrown at the end
        {
            // Arrange
            List<int> rolls = new List<int> { 2, 0, 2, 4, 3, 4, 8, 1, 7, 0, 6, 0, 7, 2, 8, 1, 9, 0, 8, 0 };
            var result = 72;
            // Act
            var actual = Scoring.ScoreFinal(rolls);

            // Assert
            Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void ScoreFinalTestStrikeAll() //All Strikes test
        {
            // Arrange
            List<int> rolls = new List<int> { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10 };
            var result = 300;
            // Act
            var actual = Scoring.ScoreFinal(rolls);

            // Assert
            Assert.That(actual, Is.EqualTo(result));
        }
        [Test]
        public void ScoreFinalTestAllSpares() //All Spares test
        {
            // Arrange
            List<int> rolls = new List<int> { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            var result = 150;
            // Act
            var actual = Scoring.ScoreFinal(rolls);

            // Assert
            Assert.That(result, Is.EqualTo(actual));
        }
    }
}
