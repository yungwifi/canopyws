﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace canopyws.Controllers
{
    [Route("api/v1/company/{companyId}/exports")]
    public class EmployeeController : Controller
    {
        // GET: api/employees
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]  {
                                        "employeeUserId",
                                        "personalFirstName",
                                        "personalLastName"
                                 };
        }

        // GET api/values/5
        [HttpGet("employee-number/{employee-number}")]
        public IEnumerable<string> Get(string employeeUserId)
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

        // GET api/values/5
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
