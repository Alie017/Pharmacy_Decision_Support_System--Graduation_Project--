using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class PatientAppService: ApplicationService, IPatientAppService
    {

        private readonly IRepository<Patient, int> _PatientRepository;

        public PatientAppService(
            IRepository<Patient, int> PatientRepository
        )
        {
            _PatientRepository = PatientRepository;

        }

        public async Task InsertPatient(PatientDto input)
        {
            Patient patient = new Patient();

            patient.Name = input.Name;
            patient.SurName = input.Surname;
            patient.Info = input.Info;
            _PatientRepository.Insert(patient);

        }

        public async Task UpdatePatient(PatientDto input)
        {
            Patient patient = _PatientRepository.FirstOrDefault(input.Id);
            patient.Name = input.Name;
            patient.SurName = input.Surname;
            patient.Info = input.Info;
        }

        public async Task<PatientDto> FindPatient(int id)
        {
            var result = _PatientRepository.FirstOrDefault(id);
            return ObjectMapper.Map<PatientDto>(result);
        }

        public async Task DeletePatient(int id)
        {

            _PatientRepository.Delete(id);
        }

        public async Task<List<PatientDto>> GetListPatient()
        {

            var result = _PatientRepository.GetAll().ToList();
            return ObjectMapper.Map<List<PatientDto>>(result);
        }
    }
}

