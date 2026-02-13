using Assignment2_Rectangle; // Make sure your test project references the main project
using NUnit.Framework;

namespace Assignment2_Rectangle_Tests
{
    [TestFixture]
    public class RectangleTests
    {
        //Christine's 6 Tests 

        // GetLength Tests 〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️

        // Test to get length of default rectangle where the output should be 1
        [Test]
        public void GetLength_DefaultRectangle_Output1()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 1;

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - Default length should be 1");
        }

        // Test to get length of rectangle where the user input is set to 100
        [Test]
        public void GetLength_SetLengthTo100_Output100()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            rect.SetLength(100);
            int expected = 100;

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - Length should be 100");
        }

        // Test to get length of rectangle where the user input is set to 4500
        [Test]
        public void GetLength_SetLengthTo4500_Output4500()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            rect.SetLength(4500);
            int expected = 4500;

            // Act
            int actual = rect.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - Length should be 4500");
        }

        // SetLength Tests 〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️
        
        // Test to set length of rectangle where the user input is set to 1
        [Test]
        public void SetLength_SetTo1_Output1()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 1;

            // Act
            int actual = rect.SetLength(1);

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - SetLength to 1");
        }

        // Test to set length of rectangle where the user input is set to 100
        [Test]
        public void SetLength_SetTo100_Output100()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 100;

            // Act
            int actual = rect.SetLength(100);

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - SetLength to 100");
        }

        // Test to set length of rectangle where the user input is set to 4500
        [Test]
        public void SetLength_SetTo4500_Output4500()
        {
            // Arrange
            Rectangle rect = new Rectangle();
            int expected = 4500;

            // Act
            int actual = rect.SetLength(4500);

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "Test Failed - SetLength to 4500");
        }


        /*Whoever is next, post your code here.Please be sure the two curly braces
        you now see below are after your code to ensure the class and namespace are closed.👇🏼*/


    }
}
