using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.SL.Queries;

namespace Semplice.Kiriwa.SL.Contracts
{
    public interface IObliqService
    {
        Card GetCard(int id);
    }
}
