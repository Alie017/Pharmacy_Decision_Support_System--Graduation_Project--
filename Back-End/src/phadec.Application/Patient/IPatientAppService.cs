using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IPatientAppService
    {
        Task InsertPatient(PatientDto input);
        Task UpdatePatient(PatientDto input);
        Task<PatientDto> FindPatient(int id);
        Task DeletePatient(int id);
        Task<List<PatientDto>> GetListPatient();



    }
}

