using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class DocumentAppService: ApplicationService, IDocumentAppService
    {

        private readonly IRepository<Document, int> _DocumentRepository;

        public DocumentAppService(
            IRepository<Document, int> DocumentRepository
        )
        {
            _DocumentRepository = DocumentRepository;

        }

        public async Task InsertDocument(DocumentDto input)
        {
            Document document = new Document();

            document.Name =input.Name;
            document.Descripton = input.Description;
            document.Type =input.Type;
            document.UserId =input.UserId;
            _DocumentRepository.Insert(document);
        }

        public async Task UpdateDocument(DocumentDto input)
        {
            Document document = _DocumentRepository.FirstOrDefault(input.Id);

            document.Name = input.Name;
            document.Descripton = input.Description;
            document.Type = input.Type;
            document.UserId = input.UserId;
        }

        public async Task<DocumentDto> FindDocument(int id)
        {
            var result = _DocumentRepository.FirstOrDefault(id);
            return ObjectMapper.Map<DocumentDto>(result);
        }

        public async Task DeleteDocument(int id)
        {

            _DocumentRepository.Delete(id);
        }

        public async Task<List<DocumentDto>> GetListDocument()
        {

            var result = _DocumentRepository.GetAll().ToList();
            return ObjectMapper.Map<List<DocumentDto>>(result);
        }

        public async Task<List<DocumentDto>> GetListDocumentByUserId(int userId)
        {
            var result = _DocumentRepository.GetAll().Where(x => x.UserId == userId).ToList();
            return ObjectMapper.Map<List<DocumentDto>>(result);
        }
    }
}

