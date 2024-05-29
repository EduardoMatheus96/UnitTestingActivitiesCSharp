using NSubstitute;
using Xunit;

namespace Atividade14.Tests
{
    public class EventHandlerTest
    {
        [Fact]
        public void HandleEvent_WhenCalled_InvokesSendEmailOnEmailService()
        {
            // Arrange
            var emailServiceMock = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailServiceMock);
            var eventMessage = "Test Event";

            // Act
            eventHandler.HandleEvent(eventMessage);

            // Assert
            emailServiceMock.Received().SendEmail("test@example.com", "Event Occurred", eventMessage);
        }

        [Fact]
        public void HandleEvent_WhenCalledWithEmptyEventMessage_InvokesSendEmailOnEmailService()
        {
            // Arrange
            var emailServiceMock = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailServiceMock);
            var eventMessage = string.Empty;

            // Act
            eventHandler.HandleEvent(eventMessage);

            // Assert
            emailServiceMock.Received().SendEmail("test@example.com", "Event Occurred", eventMessage);
        }

        [Fact]
        public void HandleEvent_WhenCalledWithWhitespaceEventMessage_InvokesSendEmailOnEmailService()
        {
            // Arrange
            var emailServiceMock = Substitute.For<IEmailService>();
            var eventHandler = new EventHandler(emailServiceMock);
            var eventMessage = "   ";

            // Act
            eventHandler.HandleEvent(eventMessage);

            // Assert
            emailServiceMock.Received().SendEmail("test@example.com", "Event Occurred", eventMessage);
        }
    }
}
