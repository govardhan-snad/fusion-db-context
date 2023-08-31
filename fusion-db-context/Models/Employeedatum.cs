using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Employeedatum
    {
        public Employeedatum()
        {
            AppointmentLetterTableAppointmentSentByNavigations = new HashSet<AppointmentLetterTable>();
            AppointmentLetterTableApprovedByNavigations = new HashSet<AppointmentLetterTable>();
            AppointmentLetterTableApproverNavigations = new HashSet<AppointmentLetterTable>();
            AppointmentLetterTableEmps = new HashSet<AppointmentLetterTable>();
            AssetTables = new HashSet<AssetTable>();
            Assignments = new HashSet<Assignment>();
            BankDetails = new HashSet<BankDetail>();
            Compensationdata = new HashSet<Compensationdatum>();
            CustomEvents = new HashSet<CustomEvent>();
            Educationdata = new HashSet<Educationdatum>();
            EmployementTables = new HashSet<EmployementTable>();
            IdentityTables = new HashSet<IdentityTable>();
            Invoices = new HashSet<Invoice>();
            LeaveBalanceTables = new HashSet<LeaveBalanceTable>();
            OfferLetterTableEmps = new HashSet<OfferLetterTable>();
            OfferLetterTableOfferSentByNavigations = new HashSet<OfferLetterTable>();
            PayRollExpenses = new HashSet<PayRollExpense>();
            SubDepartments = new HashSet<SubDepartment>();
            TicketTableAssignees = new HashSet<TicketTable>();
            TicketTableEmps = new HashSet<TicketTable>();
            TimesheetTables = new HashSet<TimesheetTable>();
            Visainformations = new HashSet<Visainformation>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaritalStatus { get; set; }
        public string Empstatus { get; set; }
        public string Emailaddress { get; set; }
        public int? Supervisor { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }
        public long? Contactnumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
        public string Country { get; set; }
        public int? TaxFileNumber { get; set; }
        public decimal? Emergencynumber { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public int? NationalId { get; set; }
        public string SecondaryLanguage { get; set; }
        public long? WorkPhone { get; set; }
        public long? MobilePhone { get; set; }
        public string WorkEmail { get; set; }
        public string HomeEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string ProbationEndDate { get; set; }
        public string ProbationStatus { get; set; }
        public string NoticePeriod { get; set; }
        public string BackgroundCheckStatus { get; set; }
        public string EmergencyName { get; set; }
        public string RelationShip { get; set; }
        public string EmailId { get; set; }
        public long? MobileNumber { get; set; }
        public string Termtypeoffboard { get; set; }
        public string Termreasonoffboard { get; set; }
        public string Eligibleforrehire { get; set; }
        public DateTime? Lastworkingday { get; set; }
        public string Reportsto { get; set; }
        public bool? IsManager { get; set; }
        public string WorkPhoneCountryCode { get; set; }
        public string MobilePhoneCountryCode { get; set; }
        public DateTime? OfferIssueddate { get; set; }
        public string Offerstatus { get; set; }
        public int EmployeeId { get; set; }
        public string FusionEmpId { get; set; }
        public string Emergencycode { get; set; }
        public string EmergencyName1 { get; set; }
        public string EmergencyEmail1 { get; set; }
        public string Emergencycode1 { get; set; }
        public long? EmergencyNumber1 { get; set; }
        public string Relationship1 { get; set; }
        public bool? Issalaryhold { get; set; }
        public bool? Pf { get; set; }
        public bool? Esic { get; set; }
        public bool? Pt { get; set; }
        public string AzureAdId { get; set; }
        public bool? Insurance { get; set; }
        public string BranchCode { get; set; }

        public virtual ICollection<AppointmentLetterTable> AppointmentLetterTableAppointmentSentByNavigations { get; set; }
        public virtual ICollection<AppointmentLetterTable> AppointmentLetterTableApprovedByNavigations { get; set; }
        public virtual ICollection<AppointmentLetterTable> AppointmentLetterTableApproverNavigations { get; set; }
        public virtual ICollection<AppointmentLetterTable> AppointmentLetterTableEmps { get; set; }
        public virtual ICollection<AssetTable> AssetTables { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<BankDetail> BankDetails { get; set; }
        public virtual ICollection<Compensationdatum> Compensationdata { get; set; }
        public virtual ICollection<CustomEvent> CustomEvents { get; set; }
        public virtual ICollection<Educationdatum> Educationdata { get; set; }
        public virtual ICollection<EmployementTable> EmployementTables { get; set; }
        public virtual ICollection<IdentityTable> IdentityTables { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<LeaveBalanceTable> LeaveBalanceTables { get; set; }
        public virtual ICollection<OfferLetterTable> OfferLetterTableEmps { get; set; }
        public virtual ICollection<OfferLetterTable> OfferLetterTableOfferSentByNavigations { get; set; }
        public virtual ICollection<PayRollExpense> PayRollExpenses { get; set; }
        public virtual ICollection<SubDepartment> SubDepartments { get; set; }
        public virtual ICollection<TicketTable> TicketTableAssignees { get; set; }
        public virtual ICollection<TicketTable> TicketTableEmps { get; set; }
        public virtual ICollection<TimesheetTable> TimesheetTables { get; set; }
        public virtual ICollection<Visainformation> Visainformations { get; set; }
    }
}
