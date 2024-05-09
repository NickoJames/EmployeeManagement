using System.Xml;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using RecordManagement.Application.Common.Interfaces.Persistence;
using RecordManagement.Application.Services;
using RecordManagement.Contracts.EmployeeRequest;
using RecordManagement.Domain;
using RecordManagement.Domain.Entities;
using RecordManagement.Infrastructure;


namespace RecordManagement.Api.Controllers;
[ApiController]
 [Route("Auth")]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
         private readonly IEmployeeRepository _employeeRepository;
        
        public EmployeeController(IEmployeeService employeeService, IEmployeeRepository inemployeeRepository)
        {
            _employeeService = employeeService;
            _employeeRepository = inemployeeRepository;
          
        }

        [HttpPost("AddEmployee")]
        public IActionResult CreateEmployee(CreateEmployeeRequest request)
        {
            
            try
            {
            var UniqueId =  Guid.NewGuid();
                var personalInfo = new PersonalInformation(
                
                request.FullName,
                request.DateOfBirth,
                request.PlaceOfBirth,
                request.Gender,
                request.CivilStatus,
                request.Citizenship,
                request.Height,
                request.Weight,
                request.BloodType
                );
     
                var contactInfo = new ContactInformation(
                request.PermanentAddress,
                request.PresentAddress,
                request.PhoneNumber,
                request.MobileNumber,
                request.EmailAddress
                );

              var employee = _employeeService.CreateEmployee(UniqueId,personalInfo, contactInfo);
              _employeeRepository.AddEmployee(employee);
                
              return Ok(employee);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        } 
  
      

         [HttpPost("AddEducationalBackground/{employeeId}")]
        public IActionResult CreateEducationalBackground(Guid employeeId,AddEducationalBackground request)
        {     
            try
            {
           
                var educationalInfo = new EducationalBackground(  
                request.Degree,
                request.School,
                request.YearGraduated  
                );

            var user = _employeeRepository.GetEmployeeById(employeeId);

            if (user!= null){
            _employeeService.AddEducationalBackground(user,educationalInfo);
            }
              return Ok(educationalInfo);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }

                 [HttpPost("AddEmploymentHistory/{employeeId}")]
                public IActionResult CreateEmploymentHistory(Guid employeeId,AddEmploymentHistoryRequest request)
                {
            
                    try
                    {
                
                        var employmenthistoryInfo = new EmploymentHistory(

            
                        request.Employer,
                        request.Position,
                        request.StartDate,
                        request.EndDate

                
                        );

                    var user = _employeeRepository.GetEmployeeById(employeeId);

                    if (user!= null){
                    _employeeService.AddEmploymentHistory(user,employmenthistoryInfo);
                    }
                    return Ok(employmenthistoryInfo);
                    }
                    catch (Exception ex)
                    {
                        
                        return StatusCode(500, $"An error occurred: {ex.Message}");
                    }

                }

                 [HttpPost("AddSkills/{employeeId}")]
                public IActionResult CreateSkills(Guid employeeId,AddSkillRequest request)
                {
            
                    try
                    {
                
                        var skillsInfo = new SkillsAndQualifications(
                        request.Skill,
                        request.Language
                   
                
                        );

                    var user = _employeeRepository.GetEmployeeById(employeeId);

                    if (user!= null){
                    _employeeService.AddSkill(user,skillsInfo);
                    }
                    return Ok(skillsInfo);
                    }
                    catch (Exception ex)
                    {
                        
                        return StatusCode(500, $"An error occurred: {ex.Message}");
                    }

                }

                    [HttpPost("AddReference/{employeeId}")]
                        public IActionResult CreateReference(Guid employeeId,AddReference request)
                        {
                    
                            try
                            {
                        
                                var referenceInfo = new Reference(
                                request.Name,
                                request.ContactInformation
                    
                                );

                            var user = _employeeRepository.GetEmployeeById(employeeId);

                            if (user!= null){
                            _employeeService.AddReference(user,referenceInfo);
                            }
                            return Ok(referenceInfo);
                            }
                            catch (Exception ex)
                            {
                                
                                return StatusCode(500, $"An error occurred: {ex.Message}");
                            }

                        }
                          [HttpPut("AddEmployee/{employeeId}")]
                        public IActionResult UpdateEmployee(Guid employeeId,[FromBody] Employee updatedEmployee){


                        if (updatedEmployee == null || employeeId != updatedEmployee.Id)
                            {
                                return BadRequest("Invalid data provided.");
                            }

                                _employeeRepository.UpdateEmployee(updatedEmployee);
                                return Ok();
        }

        [HttpGet("GetAllEmployees")]
                public IActionResult GetAllEmployees()
                {
                    var allEmployees = _employeeRepository.GetAllEmployees();
                    return Ok(allEmployees);
                }    


      [HttpDelete("{employeeId}")]
public IActionResult DeleteEmployee(Guid employeeId)
{
    try
    {
        var employeeToDelete = _employeeRepository.GetEmployeeById(employeeId);
        if (employeeToDelete == null)
        {
            return NotFound($"Employee with ID {employeeId} not found.");
        }

        _employeeRepository.DeleteEmployee(employeeId);
        return Ok($"Employee with ID {employeeId} has been deleted successfully.");
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"An error occurred: {ex.Message}");
    }
}


    }


        