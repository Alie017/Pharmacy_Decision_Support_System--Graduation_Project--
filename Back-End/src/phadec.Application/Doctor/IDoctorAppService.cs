using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace phadec.MultiTenancy
{
    public interface IDoctorAppService
    {
        Task InsertDoctor(DoctorDto input);
        Task UpdateDoctor(DoctorDto input);
        Task<DoctorDto> FindDoctor(int id);
        Task DeleteDoctor(int id);
        Task<List<DoctorDto>> GetListDoctor();



    }
}

