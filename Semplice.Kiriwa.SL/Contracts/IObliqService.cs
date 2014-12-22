using System.Collections.Generic;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;

namespace Semplice.Kiriwa.SL.Contracts
{
    public interface IObliqService
    {
        #region Stack

        Stack GetStack(int id);

        IEnumerable<StackWithCardCountDTO> GetStacksWithCardCount();

        #endregion

        #region Card

        Card GetCard(int id);

        #endregion
    }
}
