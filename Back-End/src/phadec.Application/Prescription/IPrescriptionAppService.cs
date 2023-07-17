using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IPrescriptionAppService
    {
        Task InsertPrescription(PrescriptionDto input);
        Task UpdatePrescription(PrescriptionDto input);
        Task<PrescriptionDto> FindPrescription(int id);
        Task DeletePrescription(int id);
        Task<List<PrescriptionDto>> GetListPrescription();



    }
}

