using Tutorial10.Models;
using Tutorial10.Models.DTOs;

namespace Tutorial10.Services;

public interface IPatientService
{
    public Task<bool> AddPatientIfNotExist(PatientDTO patient);
    public Task<bool> CheckMedicaments(IEnumerable<MedicamentDTO> medicaments);
    public bool CheckDates(DateOnly Date, DateOnly DueDate);
    public Task<bool> AddPrescription(PrescriptionDTO prescriptionDto);
    public Task<Patient> GetPatient(int id);
}