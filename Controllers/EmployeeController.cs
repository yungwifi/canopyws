using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using canopyws.Models;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/v1/company/{companyId}/exports")]
    public class EmployeeController : Controller
    {
        //I think this is how you set up a client to make HTTP requests?
        private static readonly HttpClient client = new HttpClient();
       

        // GET: api/employee
        //Just creating an employee to have data to show on the front end
        [HttpGet]
        public IActionResult Index()
        {
            var employeeOne = new EmployeeModel() {
                employeeUserId = "100",
                personalFirstName = "Spencer",
                personalLastName = "Merryman" };
            
            return View(employeeOne);
        }

        // GET api/values/5
        //Using an HTTP client to make a get request to the API 
        //Set up a get reutest with a parameter looking for the employee number. Hoping to use this later for the 
        //search functionality and the click ID for the specific employee in the list 
        [HttpGet("employee-number/{employee-number}")]
        public async void Get([FromBody]string value)
        {
            var responseString = await client.GetStringAsync("https://api.webhris.com/v1/company/236/exports");
        }

        // GET api/values/5
        //Set up a get reutest with a parameter looking for the ssn. Hoping to use this later for the search functionality 
        [HttpGet("ssn/{ssn}")]
        public IEnumerable<string> Get(int ssn)
        {
            return new string[]  {
                                        "employeeUserId",
                                        "personalFirstName",
                                        "personalMiddleName",
                                        "personalMiddleInitial",
                                        "personalLastName",
                                        "personalSuffixName",
                                        "personalSuffixDescription",
                                        "personalSsn",
                                        "personalBirthday",
                                        "personalHomeStreet1",
                                        "personalHomeStreet2",
                                        "personalHomeCity",
                                        "personalHomeState",
                                        "personalHomeZipCode",
                                        "personalHomeCountry",
                                        "personalSex",
                                        "personalMaritalStatus",
                                        "personalRaceEthnicity",
                                        "personalHomePhoneAreaCode",
                                        "personalHomePhoneNumber",
                                        "personalCellPhoneAreaCode",
                                        "personalCellPhoneNumber",
                                        "personalIsSmoker",
                                        "personalIsDisabledVet",
                                        "personalIsVietnamEraVet",
                                        "personalDriversLicenseNumber",
                                        "personalDriversLicenseExpiration",
                                        "personalDriversLicenseState",
                                        "personalDriversLicenseCountry",
                                        "personalForeignCitizen",
                                        "jobClassificationNumber",
                                        "jobClassificationTitle",
                                        "jobClassificationDescription",
                                        "positionNumber",
                                        "positionName",
                                        "positionCc1LocationName",
                                        "positionCc1LocationDescription",
                                        "positionCc2DepartmentName",
                                        "positionCc2DepartmentDescription",
                                        "positionCc3DivisionName",
                                        "positionCc3DivisionDescription",
                                        "positionFlsaName",
                                        "positionFlsaDescription",
                                        "positionWorkersCompName",
                                        "positionWorkersCompDescription",
                                        "employmentNumber",
                                        "employmentStatus",
                                        "employmentTypeCode",
                                        "employmentTypeDesc",
                                        "employmentHireDate",
                                        "employmentOriginalHireDate",
                                        "employmentSeniorityDate",
                                        "employmentTerminationDate",
                                        "employmentEmail",
                                        "employmentReportsToPersonalFirstName",
                                        "employmentReportsToPersonalMiddleName",
                                        "employmentReportsToPersonalMiddleInitial",
                                        "employmentReportsToPersonalLastName",
                                        "employmentTerminationReasonName",
                                        "employmentTerminationReasonDescription",
                                        "employmentIsVeteran",
                                        "primaryEmergencyContactName",
                                        "primaryEmergencyContactRelationship",
                                        "primaryEmergencyContactAddress1",
                                        "primaryEmergencyContactAddress2",
                                        "primaryEmergencyContactCity",
                                        "primaryEmergencyContactState",
                                        "primaryEmergencyContactCountry",
                                        "primaryEmergencyContactZip",
                                        "primaryEmergencyContactHomePhoneAreaCode",
                                        "primaryEmergencyContactHomePhoneNumber",
                                        "primaryEmergencyContactWorkPhoneAreaCode",
                                        "primaryEmergencyContactWorkPhoneNumber",
                                        "primaryEmergencyContactWorkPhoneExt",
                                        "primaryEmergencyContactCellPhoneAreaCode",
                                        "primaryEmergencyContactCellPhoneNumber",
                                        "primaryEmergencyContactHomeEmail",
                                        "primaryEmergencyContactWorkEmail",
                                        "taxWorkState",
                                        "taxResidenceState",
                                        "taxFederalMarriedStatusName",
                                        "taxFederalMarriedStatusCode",
                                        "taxFederalExtra",
                                        "taxFederalExtraIsPercent",
                                        "taxFederalDependents",
                                        "taxStateMarriedStatusName",
                                        "taxStateMarriedStatusCode",
                                        "taxStateExtra",
                                        "taxStateExtraIsPercent",
                                        "taxStateDependents",
                                        "taxLocalMarriedStatusName",
                                        "taxLocalMarriedStatusCode",
                                        "taxLocalExtra",
                                        "taxLocalExtraIsPercen",
                                        "payEffectiveDate",
                                        "payChangeReasonCode",
                                        "payChangeReasonDescription",
                                        "payTypeCode",
                                        "payTypeDescription",
                                        "payFrequencyCode",
                                        "payFrequencyDescription",
                                        "payStandardHoursPerPayPeriod",
                                        "payAnnualized",
                                        "payPerPeriod",
                                        "payHourly",
                                        "payPayCodeName",
                                        "payPayCodeDescription",
                                        "payPayStatusName",
                                        "payPayStatusDescription",
                                        "payrollGroupName",
                                        "payrollGroupDescription"
                            };
        }

    }
}
