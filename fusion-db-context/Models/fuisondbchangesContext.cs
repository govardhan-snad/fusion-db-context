using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class fuisondbchangesContext : DbContext
    {
        public fuisondbchangesContext()
        {
        }

        public fuisondbchangesContext(DbContextOptions<fuisondbchangesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppointStatus> AppointStatuses { get; set; }
        public virtual DbSet<AppointmentLetterTable> AppointmentLetterTables { get; set; }
        public virtual DbSet<AssetTable> AssetTables { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Backgroundcheckstatus> Backgroundcheckstatuses { get; set; }
        public virtual DbSet<BankDetail> BankDetails { get; set; }
        public virtual DbSet<BankName> BankNames { get; set; }
        public virtual DbSet<BranchLocation> BranchLocations { get; set; }
        public virtual DbSet<Bussinesarea> Bussinesareas { get; set; }
        public virtual DbSet<Clienttable> Clienttables { get; set; }
        public virtual DbSet<Compensaationreason> Compensaationreasons { get; set; }
        public virtual DbSet<Compensationdatum> Compensationdata { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CustomEvent> CustomEvents { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Educationdatum> Educationdata { get; set; }
        public virtual DbSet<Eligibleforrehire> Eligibleforrehires { get; set; }
        public virtual DbSet<Employeedatum> Employeedata { get; set; }
        public virtual DbSet<EmployementTable> EmployementTables { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Frequency> Frequencies { get; set; }
        public virtual DbSet<FusionRole> FusionRoles { get; set; }
        public virtual DbSet<FusionRoleClaim> FusionRoleClaims { get; set; }
        public virtual DbSet<FusionUser> FusionUsers { get; set; }
        public virtual DbSet<FusionUserClaim> FusionUserClaims { get; set; }
        public virtual DbSet<FusionUserRole> FusionUserRoles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GlobalNotification> GlobalNotifications { get; set; }
        public virtual DbSet<Gradetable> Gradetables { get; set; }
        public virtual DbSet<IdentityTable> IdentityTables { get; set; }
        public virtual DbSet<IdentityType> IdentityTypes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Invoicetype> Invoicetypes { get; set; }
        public virtual DbSet<JobRole> JobRoles { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Jobinformation> Jobinformations { get; set; }
        public virtual DbSet<LeaveBalanceTable> LeaveBalanceTables { get; set; }
        public virtual DbSet<LeavePolicyTable> LeavePolicyTables { get; set; }
        public virtual DbSet<LeavesCateogoryTable> LeavesCateogoryTables { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatuses { get; set; }
        public virtual DbSet<Myexpense> Myexpenses { get; set; }
        public virtual DbSet<Noticeperiod> Noticeperiods { get; set; }
        public virtual DbSet<OfferLetterTable> OfferLetterTables { get; set; }
        public virtual DbSet<OfferStatus> OfferStatuses { get; set; }
        public virtual DbSet<Overtimeeligibility> Overtimeeligibilities { get; set; }
        public virtual DbSet<PayRollExpense> PayRollExpenses { get; set; }
        public virtual DbSet<PayType> PayTypes { get; set; }
        public virtual DbSet<ProbationStatus> ProbationStatuses { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Projectname> Projectnames { get; set; }
        public virtual DbSet<ProjectsRole> ProjectsRoles { get; set; }
        public virtual DbSet<RateTable> RateTables { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SubDepartment> SubDepartments { get; set; }
        public virtual DbSet<TaskTable> TaskTables { get; set; }
        public virtual DbSet<TerminationReason> TerminationReasons { get; set; }
        public virtual DbSet<TicketTable> TicketTables { get; set; }
        public virtual DbSet<Timeoff> Timeoffs { get; set; }
        public virtual DbSet<TimesheetTable> TimesheetTables { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Visainformation> Visainformations { get; set; }
        public virtual DbSet<Visatype> Visatypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.10.56.13;Database=fuisondbchanges;user id=qasnaduser;password=Snad@qa123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointStatus>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("AppointStatus_PK");

                entity.ToTable("AppointStatus");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AppointStatus1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("appointStatus");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<AppointmentLetterTable>(entity =>
            {
                entity.ToTable("AppointmentLetterTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentSentDate).HasColumnType("date");

                entity.Property(e => e.AppointmentSentStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .IsUnicode(false)
                    .HasColumnName("DocumentURL");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.RequestedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WatermarkDocUrl).HasColumnName("WatermarkDocURL");

                entity.HasOne(d => d.AppointmentSentByNavigation)
                    .WithMany(p => p.AppointmentLetterTableAppointmentSentByNavigations)
                    .HasForeignKey(d => d.AppointmentSentBy)
                    .HasConstraintName("AppointmentLetterTable_Sentby_FK");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.AppointmentLetterTableApprovedByNavigations)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("AppointmentLetterTable_Approvedby_FK");

                entity.HasOne(d => d.ApproverNavigation)
                    .WithMany(p => p.AppointmentLetterTableApproverNavigations)
                    .HasForeignKey(d => d.Approver)
                    .HasConstraintName("AppointmentLetterTable_Approver_FK");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.AppointmentLetterTableEmps)
                    .HasForeignKey(d => d.Empid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("AppointmentLetterTable_FK");
            });

            modelBuilder.Entity<AssetTable>(entity =>
            {
                entity.ToTable("AssetTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Maker)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.AssetTables)
                    .HasForeignKey(d => d.Empid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("AssetTable_FK");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("AssetType_PK");

                entity.ToTable("AssetType");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AssetType1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("assetType");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("empID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Prid).HasColumnName("PRId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assignments_employeedata");

                entity.HasOne(d => d.Pr)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.Prid)
                    .HasConstraintName("Assignments_FK");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("Assignments_FK_2");
            });

            modelBuilder.Entity<Backgroundcheckstatus>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Backgrou__DDDF6446D8E3D4D3");

                entity.ToTable("Backgroundcheckstatus");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Backgroundcheckstatus1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("backgroundcheckstatus");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<BankDetail>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("BankDetails_PK");

                entity.Property(e => e.BankId).HasColumnName("bankId");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("accountName");

                entity.Property(e => e.AccountNo).HasColumnName("accountNo");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.DocUrl)
                    .HasMaxLength(500)
                    .HasColumnName("docUrl");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ifscCode");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsPrimary).HasColumnName("is_primary");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("BankDetails_FK");
            });

            modelBuilder.Entity<BankName>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("BankNames_PK");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.BankName1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.Isdeleted)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('Active')");
            });

            modelBuilder.Entity<BranchLocation>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("AppointmentIssuedLocation_PK");

                entity.ToTable("branchLocation");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("branch_code");

                entity.Property(e => e.BranchLocation1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("branch_location");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<Bussinesarea>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Bussines__DDDF644684544506");

                entity.ToTable("Bussinesarea");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<Clienttable>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("Client_Table_PK");

                entity.ToTable("clienttable");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.ContactMail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Line1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("line1");

                entity.Property(e => e.Line2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("line2");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("postcode");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Compensaationreason>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__compensa__DDDF6446531AC4B7");

                entity.ToTable("compensaationreason");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compensationdatum>(entity =>
            {
                entity.ToTable("compensationdata");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Compeffectivedate)
                    .HasColumnType("date")
                    .HasColumnName("compeffectivedate");

                entity.Property(e => e.Compensationamount)
                    .HasColumnType("money")
                    .HasColumnName("compensationamount");

                entity.Property(e => e.Compensationcomments)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("compensationcomments");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("frequency");

                entity.Property(e => e.Overtimeeligibility)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("overtimeeligibility");

                entity.Property(e => e.Paytype)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("paytype");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Active')");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Compensationdata)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("compensationdata_FK");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__country__DDDF6446AFB1EC69");

                entity.ToTable("country");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("countryName");

                entity.Property(e => e.Currency)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("CustomEvents_PK");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.AttachmentUrl).HasColumnName("attachment_url");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasColumnName("event_date");

                entity.Property(e => e.EventMessage).HasColumnName("event_message");

                entity.Property(e => e.EventTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("event_title");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.CustomEvents)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("CustomEvents_FK");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Degree__DDDF64463465B22E");

                entity.ToTable("Degree");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Departme__DDDF644639446219");

                entity.ToTable("Department");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<Educationdatum>(entity =>
            {
                entity.ToTable("educationdata");

                entity.Property(e => e.Degree)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DegreeEndDate).HasColumnType("date");

                entity.Property(e => e.DegreeStartDate).HasColumnType("date");

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.University)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Educationdata)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("educationdata_FK");
            });

            modelBuilder.Entity<Eligibleforrehire>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Eligible__DDDF64460FCCFF19");

                entity.ToTable("Eligibleforrehire");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Eligibleforrehire1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("eligibleforrehire");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<Employeedatum>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__employee__7AD04F116E47A249");

                entity.ToTable("employeedata");

                entity.HasIndex(e => e.FusionEmpId, "employeedata_UN")
                    .IsUnique();

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AzureAdId).HasColumnName("azure_ad_id");

                entity.Property(e => e.BackgroundCheckStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch_code");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contactnumber).HasColumnName("contactnumber");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Eligibleforrehire)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("eligibleforrehire");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.EmergencyEmail1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyName1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencycode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencycode1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencynumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("emergencynumber");

                entity.Property(e => e.Empstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("empstatus");

                entity.Property(e => e.Esic).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FusionEmpId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance)
                    .HasColumnName("insurance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManager)
                    .HasColumnName("isManager")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issalaryhold).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Lastworkingday)
                    .HasColumnType("date")
                    .HasColumnName("lastworkingday");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhoneCountryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mobilePhoneCountryCode");

                entity.Property(e => e.NoticePeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OfferIssueddate)
                    .HasColumnType("date")
                    .HasColumnName("offerIssueddate");

                entity.Property(e => e.Offerstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("offerstatus");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProbationEndDate)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProbationStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pt)
                    .HasColumnName("PT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelationShip)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Reportsto)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryLanguage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.Termreasonoffboard)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("termreasonoffboard");

                entity.Property(e => e.Termtypeoffboard)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("termtypeoffboard");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhoneCountryCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("workPhoneCountryCode");
            });

            modelBuilder.Entity<EmployementTable>(entity =>
            {
                entity.ToTable("EmployementTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmpEffectiveDate).HasColumnType("date");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.JobType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployementTables)
                    .HasForeignKey(d => d.Empid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EmployementTable_FK");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.EmployementTables)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("JobType_Table_FK");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.ExpensesCode)
                    .HasName("PK__Expenses__0B85D090039FC51D");

                entity.Property(e => e.ExpenseType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<Frequency>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Frequenc__DDDF64467DF5E692");

                entity.ToTable("Frequency");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Frequency1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("frequency");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<FusionRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<FusionRoleClaim>(entity =>
            {
                entity.HasIndex(e => new { e.ClaimType, e.ClaimValue, e.RoleId }, "uq_roleclaim")
                    .IsUnique();

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FusionRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<FusionUser>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasMaxLength(256);
            });

            modelBuilder.Entity<FusionUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FusionUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<FusionUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FusionUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FusionUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Gender__DDDF644644F70E3B");

                entity.ToTable("Gender");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<GlobalNotification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is-delete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRead)
                    .HasColumnName("is-read")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.NotificationDate)
                    .HasColumnType("date")
                    .HasColumnName("notification_date");

                entity.Property(e => e.NotificationType).HasColumnName("notification_type");

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .HasColumnName("Sent-to");
            });

            modelBuilder.Entity<Gradetable>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("Gradetable_PK");

                entity.ToTable("Gradetable");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.JobGrade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IdentityTable>(entity =>
            {
                entity.HasKey(e => e.IdentityId)
                    .HasName("IdentityTable_PK");

                entity.ToTable("IdentityTable");

                entity.Property(e => e.IdentityId).HasColumnName("identityId");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(500)
                    .HasColumnName("attachment");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.IdentityNumber)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("identityNumber");

                entity.Property(e => e.IdentityType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("identityType");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.IdentityTables)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("IdentityTable_FK");
            });

            modelBuilder.Entity<IdentityType>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("IdentityType_PK");

                entity.ToTable("IdentityType");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.IdentityType1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("identityType");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoices");

                entity.Property(e => e.Attachment).HasColumnName("ATTACHMENT");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Invoicedate).HasColumnType("date");

                entity.Property(e => e.Money).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("invoices_FK");
            });

            modelBuilder.Entity<Invoicetype>(entity =>
            {
                entity.ToTable("Invoicetype");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Invoicetype1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Invoicetype");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");
            });

            modelBuilder.Entity<JobRole>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__JobRole__DDDF64462639D817");

                entity.ToTable("JobRole");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.JobRole1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("JobRole");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__JobType__DDDF6446DA6EBCD6");

                entity.ToTable("JobType");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.JobType1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("JobType");
            });

            modelBuilder.Entity<Jobinformation>(entity =>
            {
                entity.ToTable("jobinformation");

                entity.Property(e => e.BussinessArea)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.JobRole)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Lopcation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.SubdeptId).HasColumnName("subdeptID");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Subdept)
                    .WithMany(p => p.Jobinformations)
                    .HasForeignKey(d => d.SubdeptId)
                    .HasConstraintName("jobinformation_FK");
            });

            modelBuilder.Entity<LeaveBalanceTable>(entity =>
            {
                entity.ToTable("LeaveBalanceTable");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.LeaveBalanceTables)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveBalanceTable_employeedata");

                entity.HasOne(d => d.LeavePolicy)
                    .WithMany(p => p.LeaveBalanceTables)
                    .HasForeignKey(d => d.LeavePolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LeaveBalanceTable_FK");
            });

            modelBuilder.Entity<LeavePolicyTable>(entity =>
            {
                entity.HasKey(e => e.LpId)
                    .HasName("Leave_Policy_Table_PK");

                entity.ToTable("LeavePolicyTable");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.LeavePolicyTables)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Leave_Policy_Table_FK");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.LeavePolicyTables)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Leave_Policy_Table_FK_1");
            });

            modelBuilder.Entity<LeavesCateogoryTable>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("Leaves_Cateogory_Table_PK");

                entity.ToTable("LeavesCateogoryTable");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Make>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("Make_PK");

                entity.ToTable("Make");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MakeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("makeName");
            });

            modelBuilder.Entity<Maritalstatus>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Maritals__DDDF6446C049B994");

                entity.ToTable("Maritalstatus");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Maritalstatus1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("maritalstatus");
            });

            modelBuilder.Entity<Myexpense>(entity =>
            {
                entity.ToTable("myexpenses");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Attachment).HasColumnName("attachment");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Expensedate).HasColumnType("date");

                entity.Property(e => e.IsManagementExpense).HasColumnName("isManagementExpense");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.ExpensesCodeNavigation)
                    .WithMany(p => p.Myexpenses)
                    .HasForeignKey(d => d.ExpensesCode)
                    .HasConstraintName("myexpenses_FK");
            });

            modelBuilder.Entity<Noticeperiod>(entity =>
            {
                entity.ToTable("Noticeperiod");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("period");
            });

            modelBuilder.Entity<OfferLetterTable>(entity =>
            {
                entity.ToTable("OfferLetterTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DocumentUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DocumentURL");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.OfferSentDate).HasColumnType("date");

                entity.Property(e => e.OfferSentStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.OfferLetterTableEmps)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("OfferLetterTable_FK");

                entity.HasOne(d => d.OfferSentByNavigation)
                    .WithMany(p => p.OfferLetterTableOfferSentByNavigations)
                    .HasForeignKey(d => d.OfferSentBy)
                    .HasConstraintName("OfferLetterTable_Sentby_FK");
            });

            modelBuilder.Entity<OfferStatus>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("OfferStatus_PK");

                entity.ToTable("OfferStatus");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.OfferStatus1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("offerStatus");
            });

            modelBuilder.Entity<Overtimeeligibility>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Overtime__DDDF6446A2518530");

                entity.ToTable("Overtimeeligibility");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Overtimeeligibility1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("overtimeeligibility");
            });

            modelBuilder.Entity<PayRollExpense>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Employeename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("employeename");

                entity.Property(e => e.Grosspay).HasColumnName("grosspay");

                entity.Property(e => e.Insurancebycompany).HasColumnName("insurancebycompany");

                entity.Property(e => e.Noofhours).HasColumnName("noofhours");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("date")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Payperiodenddate)
                    .HasColumnType("date")
                    .HasColumnName("payperiodenddate");

                entity.Property(e => e.Payperiodstartdate)
                    .HasColumnType("date")
                    .HasColumnName("payperiodstartdate");

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Payrollexpense1).HasColumnName("payrollexpense");

                entity.Property(e => e.Totalpayrollexpenses)
                    .HasColumnType("money")
                    .HasColumnName("totalpayrollexpenses");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .HasColumnType("date")
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PayRollExpenses)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PayRollExpenses_FK");
            });

            modelBuilder.Entity<PayType>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__PayType__DDDF6446E7EE2F93");

                entity.ToTable("PayType");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Paytype1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("paytype");
            });

            modelBuilder.Entity<ProbationStatus>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Probatio__DDDF6446B2A2E5C4");

                entity.ToTable("ProbationStatus");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Probationstatus1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Probationstatus");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.ProjectName, "UQ__Projects__BCBE781C373BC864")
                    .IsUnique();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ColourId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ColourID");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("Projects_FK");
            });

            modelBuilder.Entity<Projectname>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("projectname");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectName1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ProjectName");
            });

            modelBuilder.Entity<ProjectsRole>(entity =>
            {
                entity.HasKey(e => e.Prid)
                    .HasName("Projects_Roles_PK");

                entity.Property(e => e.Prid).HasColumnName("PRId");

                entity.Property(e => e.BillableRate).HasColumnType("money");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsBillabe)
                    .IsRequired()
                    .HasColumnName("isBillabe")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.ProjectsRoles)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Projects_Roles_FK_1");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectsRoles)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("Projects_Roles_FK");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ProjectsRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Projects_Roles_FK_2");
            });

            modelBuilder.Entity<RateTable>(entity =>
            {
                entity.HasKey(e => e.RateId)
                    .HasName("RateTable_PK");

                entity.ToTable("RateTable");

                entity.Property(e => e.RateId).HasColumnName("RateID");

                entity.Property(e => e.BillableRate).HasColumnType("money");

                entity.Property(e => e.CostRate).HasColumnType("money");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.RateTables)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RateTable_FK");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Relation__DDDF644666B12AFB");

                entity.ToTable("Relationship");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Relationship1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("relationship");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Status__DDDF6446DF6347C1");

                entity.ToTable("Status");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("statusname");
            });

            modelBuilder.Entity<SubDepartment>(entity =>
            {
                entity.ToTable("SubDepartment");

                entity.Property(e => e.SubdepartmentId).HasColumnName("subdepartment_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportingmanagerId).HasColumnName("reportingmanager_id");

                entity.Property(e => e.SubdepartmentName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("subdepartment_name");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SubDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SubDepartment_FK_1");

                entity.HasOne(d => d.Reportingmanager)
                    .WithMany(p => p.SubDepartments)
                    .HasForeignKey(d => d.ReportingmanagerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SubDepartment_FK");
            });

            modelBuilder.Entity<TaskTable>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("TaskTable_PK");

                entity.ToTable("TaskTable");

                entity.Property(e => e.TaskId).HasColumnName("taskId");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("taskName");

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TaskTables)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("TaskTable_FK");
            });

            modelBuilder.Entity<TerminationReason>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Terminat__DDDF64467B7511E9");

                entity.ToTable("TerminationReason");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketTable>(entity =>
            {
                entity.ToTable("TicketTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssigneeId).HasColumnName("assigneeId");

                entity.Property(e => e.AttachmentUrl).HasColumnName("attachment_url");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DeskNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desk_no");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Priority)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("priority");

                entity.Property(e => e.StepsToReplicate).HasColumnName("steps_to_replicate");

                entity.Property(e => e.SubdeptId).HasColumnName("subdept_id");

                entity.Property(e => e.Subject).HasColumnName("subject");

                entity.Property(e => e.TicketStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ticket_status");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Assignee)
                    .WithMany(p => p.TicketTableAssignees)
                    .HasForeignKey(d => d.AssigneeId)
                    .HasConstraintName("TicketTableassignee_FK");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TicketTableEmps)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("TicketTable_FK");

                entity.HasOne(d => d.Subdept)
                    .WithMany(p => p.TicketTables)
                    .HasForeignKey(d => d.SubdeptId)
                    .HasConstraintName("TicketTable_sub_FK");
            });

            modelBuilder.Entity<Timeoff>(entity =>
            {
                entity.ToTable("timeoff");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Enddate).HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.LeavePolicy)
                    .WithMany(p => p.Timeoffs)
                    .HasForeignKey(d => d.LeavePolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("timeoff_FK");
            });

            modelBuilder.Entity<TimesheetTable>(entity =>
            {
                entity.HasKey(e => e.TimesheetId)
                    .HasName("TimesheetTable_PK");

                entity.ToTable("TimesheetTable");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("createdat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.Friday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Monday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Saturday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sunday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Thursday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tuesday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedat)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Wednesday)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WeekEndDate).HasColumnType("date");

                entity.Property(e => e.WeekStartDate).HasColumnType("date");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TimesheetTables)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TimesheetTable_FK");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TimesheetTables)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TimesheetTable_FK_2");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TimesheetTables)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TimesheetTable_FK_3");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Title__DDDF64465433F155");

                entity.ToTable("Title");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Titlename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("titlename");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Visainformation>(entity =>
            {
                entity.ToTable("visainformation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Expirydate).HasColumnType("date");

                entity.Property(e => e.Issuedcountry)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Issueddate).HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Visatype)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Vstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Visainformations)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("visainformation_FK");
            });

            modelBuilder.Entity<Visatype>(entity =>
            {
                entity.ToTable("Visatype");

                entity.Property(e => e.Isdeleted)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("isdeleted");

                entity.Property(e => e.Visatype1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Visatype");
            });

            modelBuilder.HasSequence("exp_seq").StartsAt(1000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
