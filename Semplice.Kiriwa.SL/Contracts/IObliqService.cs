using System.Collections.Generic;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Contracts
{
    public interface IObliqService
    {
        Stack GetStack(int id);

        IEnumerable<Stack> GetStacks();
    }
}
