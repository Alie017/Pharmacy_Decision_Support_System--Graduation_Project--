using Abp.Application.Services;
using Abp.Domain.Repositories;
using phadec.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phadec.Domain;

namespace phadec.MultiTenancy
{
    public class PrescriptionAppService: ApplicationService, IPrescriptionAppService
    {

        private readonly IRepository<Prescription, int> _PrescriptionRepository;

        public PrescriptionAppService(
            IRepository<Prescription, int> PrescriptionRepository
        )
        {
            _PrescriptionRepository = PrescriptionRepository;

        }

        public async Task InsertPrescription(PrescriptionDto input)
        {
            Prescription prescription = new Prescription();

            prescription.PatientId = input.PatientId;
            prescription.DoctorId = input.DoctorId;
            prescription.ElecNo = input.ElecNo;


            _PrescriptionRepository.Insert(prescription);
        }

        public async Task UpdatePrescription(PrescriptionDto input)
        {
            Prescription prescription = _PrescriptionRepository.FirstOrDefault(input.Id);
            prescription.PatientId = input.PatientId;
            prescription.DoctorId = input.DoctorId;
            prescription.ElecNo = input.ElecNo;
        }

        public async Task<PrescriptionDto> FindPrescription(int id)
        {
            var result = _PrescriptionRepository.FirstOrDefault(id);
            return ObjectMapper.Map<PrescriptionDto>(result);
        }

        public async Task DeletePrescription(int id)
        {

            _PrescriptionRepository.Delete(id);
        }

        public async Task<List<PrescriptionDto>> GetListPrescription()
        {

            var result = _PrescriptionRepository.GetAll().ToList();
            return ObjectMapper.Map<List<PrescriptionDto>>(result);
        }
    }
}

