using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial10.Data;
using Tutorial10.Models.DTOs;
using Tutorial10.Services;

namespace Tutorial10.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatientService _patientService;

    public PatientController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrescription(PrescriptionDTO prescriptionDto)
    {
        await _patientService.AddPatientIfNotExist(prescriptionDto.Patient);

        var checkMeds =await  _patientService.CheckMedicaments(prescriptionDto.Medicaments);

        if (!checkMeds)
        {
            return StatusCode(403, "Incorrect input of a medicaments list");
        }

        var checkDates = _patientService.CheckDates(DateOnly.Parse(prescriptionDto.Date), DateOnly.Parse(prescriptionDto.DueDate));

        if (!checkDates)
        {
            return StatusCode(403, "Incorrect input: DueDate is smaller than Date");
        }

        await _patientService.AddPrescription(prescriptionDto);
        
        return Created();
    }
    
}