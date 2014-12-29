using System.Collections.Generic;
using System.Web.Http.ModelBinding;
using Moq;
using NUnit.Framework;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;
using Semplice.Kiriwa.SL.Contracts;

namespace Semplice.Kiriwa.WebApp.Tests.TestCommon
{
    internal class Helpers 
    {
        public static Mock<IObliqService> GetMockIObliqService(List<StackWithCardCountDTO> getStacksWithCardCountReturn = null, Stack getStackReturn = null, Card getCardReturn = null)
        {
            // Define default return object for GetStacksWithCardCount
            if (getStacksWithCardCountReturn == null)
                getStacksWithCardCountReturn = Models.StackWithCardCountDTOs;

            // Define default return object for GetStack
            if (getStackReturn == null)
                getStackReturn = Models.StackWithOneCard;

            // Define default return object for GetCard
            if (getCardReturn == null)
                getCardReturn = Models.CardWithoutChildren;

            var _service = new Mock<IObliqService>();

            // Add default return to GetStacksWithCardCount
            _service.Setup(x => x.GetStacksWithCardCount())
                .Returns(getStacksWithCardCountReturn);

            // Add default return to GetStack
            _service.Setup(x => x.GetStack(It.IsAny<int>()))
                .Returns(getStackReturn);

            // Add default return to GetCard
            _service.Setup(x => x.GetCard(It.IsAny<int>()))
                .Returns(getCardReturn);

            return _service;
        }
    }
}
