using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class DoctorAppService: ApplicationService, IDoctorAppService
    {

        private readonly IRepository<Doctor, int> _DoctorRepository;

        public DoctorAppService(
            IRepository<Doctor, int> DoctorRepository
        )
        {
            _DoctorRepository = DoctorRepository;

        }

        public async Task InsertDoctor(DoctorDto input)
        {
            Doctor doctor = new Doctor();

            doctor.Name = input.Name;
            doctor.SurName =input.SurName;
           
            _DoctorRepository.Insert(doctor);
        }

        public async Task UpdateDoctor(DoctorDto input)
        {
            Doctor doctor = _DoctorRepository.FirstOrDefault(input.Id);

            doctor.Name = input.Name;
            doctor.SurName = input.SurName;
        }

        public async Task<DoctorDto> FindDoctor(int id)
        {
            var result = _DoctorRepository.FirstOrDefault(id);
            return ObjectMapper.Map<DoctorDto>(result);
        }

        public async Task DeleteDoctor(int id)
        {

            _DoctorRepository.Delete(id);
        }

        public async Task<List<DoctorDto>> GetListDoctor()
        {

            var result = _DoctorRepository.GetAll().ToList();
            return ObjectMapper.Map<List<DoctorDto>>(result);
        }
    }
}

