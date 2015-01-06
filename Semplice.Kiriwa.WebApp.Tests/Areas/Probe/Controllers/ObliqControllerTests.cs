using System.Linq;
using NUnit.Framework;
using Semplice.Kiriwa.WebApp.Areas.Probe.Controllers;
using Semplice.Kiriwa.WebApp.Tests.TestCommon;

namespace Semplice.Kiriwa.WebApp.Tests.Areas.Probe.Controllers
{
    [TestFixture]
    public class ObliqControllerTests
    {
        [TestCase]
        public void GetStacksWithCardCount_InvokeOperation_ResultIsNotNullAndChildrenHaveValues()
        {
            // Arrange
            var _service = Helpers.GetMockIObliqService(Models.StackWithCardCountDTOs);

            // Act
            var _controller = new ObliqController(_service.Object);
            var _result = _controller.GetStacksWithCardCount();

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(1, _result.Count());
            Assert.AreEqual(1, _result.FirstOrDefault().CardCount);
            Assert.IsNotNull(_result.FirstOrDefault().Stacks);
        }

        [TestCase]
        public void GetStack_InvokeOperation_ResultIsNotNullAndIdMatchRequested()
        {
            // Arrange
            var _service = Helpers.GetMockIObliqService(getStackReturn: Models.StackWithOneCard);

            // Act
            var _controller = new ObliqController(_service.Object);
            var _result = _controller.GetStack(1);

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(1, _result.StackId);
        }

        [TestCase]
        public void GetCard_InvokeOperation_ResultIsNotNullAndIdMatchRequested()
        {
            // Arrange
            var _service = Helpers.GetMockIObliqService(getCardReturn: Models.CardWithoutChildren);

            // Act
            var _controller = new ObliqController(_service.Object);
            var _result = _controller.GetCard(2);

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(2, _result.CardId);
            Assert.IsNull(_result.Stack);
        }
    }
}
