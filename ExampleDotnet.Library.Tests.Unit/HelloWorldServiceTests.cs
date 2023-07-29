using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace ExampleDotnet.Library.Tests.Unit
{
    public class HelloWorldServiceTests
    {
        [Test]
        public void PrintMessage_ReturnsExpectedMessage()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<HelloWorldService>>();
            var service = new HelloWorldService(loggerMock.Object);

            // Act
            var result = service.PrintMessage();

            // Assert
            Assert.AreEqual("Hello, World!", result);
        }
    }
}