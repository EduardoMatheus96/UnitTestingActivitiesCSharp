using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Xunit;

namespace Atividade15.Tests
{
    public class DetectTextImageTests
    {
        [Fact]
        public async Task DetectTextLabelAsync_WithValidImage_SavesResultToTextFile()
        {
            // Arrange
            var detectTextImage = new DetectTextImage();
            var resultFilePath = Path.GetTempFileName();

            // Act
            await detectTextImage.DetectTextLabelAsync(resultFilePath);

            // Assert
            Assert.True(File.Exists(resultFilePath));
            var result = File.ReadAllText(resultFilePath);
            Assert.NotEmpty(result);
            File.Delete(resultFilePath);
        }

        [Fact]
        public async Task DetectTextLabelAsync_WithInvalidImage_ThrowsException()
        {
            // Arrange
            var detectTextImage = new DetectTextImage();
            var resultFilePath = Path.GetTempFileName();
            var invalidImagePath = "invalid-image.jpg";

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => detectTextImage.DetectTextLabelAsync(invalidImagePath));
        }

        [Fact]
        public async Task SaveResultToTextFile_WithValidTextCollection_SavesToFile()
        {
            // Arrange
            var detectTextImage = new DetectTextImage();
            var textCollection = new List<TextDetection>
            {
                new TextDetection { DetectedText = "Test 1", Confidence = 0.9f, Id = 1, ParentId = 0, Type = TextTypes.LINE },
                new TextDetection { DetectedText = "Test 2", Confidence = 0.8f, Id = 2, ParentId = 0, Type = TextTypes.WORD }
            };
            var resultFilePath = Path.GetTempFileName();

            // Act
            detectTextImage.SaveResultToTextFile(textCollection, resultFilePath);

            // Assert
            Assert.True(File.Exists(resultFilePath));
            var result = File.ReadAllText(resultFilePath);
            Assert.Contains("Detected: Test 1", result);
            Assert.Contains("Confidence: 0.9", result);
            Assert.Contains("Id: 1", result);
            Assert.Contains("ParentId: 0", result);
            Assert.Contains("Type: Line", result);
            Assert.Contains("Detected: Test 2", result);
            Assert.Contains("Confidence: 0.8", result);
            Assert.Contains("Id: 2", result);
            Assert.Contains("ParentId: 0", result);
            Assert.Contains("Type: Word", result);
            File.Delete(resultFilePath);
        }
    }
}
