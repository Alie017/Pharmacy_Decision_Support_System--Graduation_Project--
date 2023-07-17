using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IDocumentAppService
    {
        Task InsertDocument(DocumentDto input);
        Task UpdateDocument(DocumentDto input);
        Task<DocumentDto> FindDocument(int id);
        Task DeleteDocument(int id);
        Task<List<DocumentDto>> GetListDocument();



    }
}

