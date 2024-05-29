using Xunit;
using NSubstitute;

namespace Atividade14.Tests
{
    public class EmailServiceTests
    {
        [Fact]
        public void SendEmail_WhenCalled_SendsEmail()
        {
            // Arrange
            var emailService = new EmailService();
            var recipient = "test@example.com";
            var subject = "Test Email";
            var body = "This is a test email.";

            // Act
            emailService.SendEmail(recipient, subject, body);

            // Assert
            // Adicione aqui as verificações necessárias para garantir que o email foi enviado corretamente
        }
    }
}
