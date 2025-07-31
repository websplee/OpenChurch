using Audit.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OC.Domain.Interfaces;
using OC.Domain.Models.Accounting;
using OC.Domain.Models.Audits;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Locations;
using OC.Domain.Models.Members;
using OC.Domain.Models.Users;

namespace OC.Data
{
    [AuditDbContext(Mode = AuditOptionMode.OptOut, IncludeEntityObjects = true, AuditEventType = "{blci}_{OCDbContext}")]
    public class OCDbContext : AuditIdentityDbContext<User>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        public OCDbContext()
        { }
        public OCDbContext(DbContextOptions<OCDbContext> options, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // To be used when running an update to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*optionsBuilder.UseSqlServer(@"Server=crystalisedapps.com; Initial Catalog=zeeblci_test;User Id=blciuser;Password=B6?0w8nz;TrustServerCertificate=True");*/
            /*optionsBuilder.UseSqlServer(@"Server=localhost; Initial Catalog=zeeblci_test;User Id=blciuser;Password=B6?0w8nz;TrustServerCertificate=True");*/

        }

        public string CurrentUserId { get; set; }

        #region Accounting DbSet
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<Pledge> Pledges { get; set; }
        #endregion Accounting DbSet 

        #region Audits DbSet
        public DbSet<OC.Domain.Models.Audits.Audit> AuditLogs { get; set; }
        #endregion Audits DbSet

        #region Approvals DbSet
        /* public DbSet<AgentDepositApproval> AgentDepositApprovals { get; set; }
         public DbSet<ApprovalStage> ApprovalStages { get; set; }
         public DbSet<ApprovalStatus> ApprovalStatuses { get; set; }*/
        #endregion Approvals DbSet

        #region Branches DbSet
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchLeadership> BranchLeaderships { get; set; }
        public DbSet<BranchMinistry> BranchMinistries { get; set; }
        public DbSet<BranchMinistryLeadership> BranchMinistryLeaderships { get; set; }
        public DbSet<BranchStaff> BranchStaff { get; set; }
        public DbSet<BranchStaffResignation> BranchStaffResignations { get; set; }
        public DbSet<CellGroup> CellGroups { get; set; }
        public DbSet<CellGroupHost> CellGroupHosts { get; set; }
        public DbSet<CellLeadership> CellLeaderships { get; set; }
        public DbSet<ChurchProgramSession> ChurchProgramSession { get; set; }
        public DbSet<ChurchProgramSessionAttendance> ChurchProgramSessionAttendances { get; set; }
        public DbSet<ChurchProgramSessionVisitor> ChurchProgramSessionVisitors { get; set; }
        public DbSet<IncomingTransfer> IncomingTransfers { get; set; }
        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<OutgoingTransfer> OutgoingTransfers { get; set; }
        #endregion Branches DbSet

        #region Locations DbSet
        public DbSet<ChurchSettings> ChurchSettings { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionLeadership> RegionLeaderships { get; set; }
        #endregion Locations DbSet

        #region Members DbSet
        public DbSet<EducationField> EducationFields { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<LeadershipRole> LeadershipRoles { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberTransaction> MemberTransactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        #endregion Members DbSet

        #region Users DbSet
        public DbSet<Module> Modules { get; set; }
        public DbSet<RoleModule> RoleModules { get; set; }
        #endregion User DbSet

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string ADMIN_ID = "8a4353dd-5496-4ffe-bfa3-db90afab6684";
            string ROLE_ID = "bdf53b89-5034-4dfa-8d2b-7441ce66a535";

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            #region Accounting Builder Entities
            builder.Entity<Expense>(entity =>
            {
                entity.ToTable("tblExpenses");
            });
            builder.Entity<ExpenseType>(entity =>
            {
                entity.ToTable("tblExpenseTpes");
            });
            builder.Entity<Income>(entity =>
            {
                entity.ToTable("tblIncomes");
            });
            builder.Entity<IncomeType>(entity =>
            {
                entity.ToTable("tblIncomeTypes");
            });
            builder.Entity<Pledge>(entity =>
            {
                entity.ToTable("tblPledges");
            });
            #endregion Accounting Builder Entities

            #region Audit Builder Entities
            builder.Entity<OC.Domain.Models.Audits.Audit>(entity =>
            {
                entity.ToTable("tblAudits");
            });
            #endregion Audit Builder Entities

            #region Branches Builder Entities
            builder.Entity<Branch>(entity =>
            {
                entity.ToTable("tblBranches")
                .HasData(
                    new Branch
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        RegionId = 6,
                        Name = "Chawama",
                        PhysicalAddress = "Plot 10, Chawama Road",
                        Latitude = 0,
                        Longitude = 0,
                        Phone1 = "",
                        Phone2 = "",
                        Email = "chawamabranch@blci.com",
                        OwnBuilding = false,
                        IsActive = true
                    },
                    new Branch
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        RegionId = 6,
                        Name = "Chilanga",
                        PhysicalAddress = "Plot 3, Munda Wanga",
                        Latitude = 0,
                        Longitude = 0,
                        Phone1 = "",
                        Phone2 = "",
                        Email = "chilangabranch@blci.com",
                        OwnBuilding = false,
                        IsActive = true
                    },
                    new Branch
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        RegionId = 6,
                        Name = "Chongwe",
                        PhysicalAddress = "Corner Great East Road",
                        Latitude = 0,
                        Longitude = 0,
                        Phone1 = "",
                        Phone2 = "",
                        Email = "chongwebranch@blci.com",
                        OwnBuilding = false,
                        IsActive = true
                    },
                    new Branch
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        RegionId = 6,
                        Name = "Chisamba Boma",
                        PhysicalAddress = "Town Centre",
                        Latitude = 0,
                        Longitude = 0,
                        Phone1 = "",
                        Phone2 = "",
                        Email = "chisambabranch@blci.com",
                        OwnBuilding = false,
                        IsActive = true
                    },
                    new Branch
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        RegionId = 6,
                        Name = "Chisamba William",
                        PhysicalAddress = "William Farm",
                        Latitude = 0,
                        Longitude = 0,
                        Phone1 = "",
                        Phone2 = "",
                        Email = "chisambabranch@blci.com",
                        OwnBuilding = false,
                        IsActive = true
                    }
                    );
            });

            builder.Entity<BranchLeadership>(entity =>
            {
                entity.ToTable("tblBranchLeaderships");
            });

            builder.Entity<BranchMinistryLeadership>(entity =>
            {
                entity.ToTable("tblBranchMinistryLeaderships");
            });
            builder.Entity<BranchMinistry>(entity =>
            {
                entity.ToTable("tblBranchMinistries");
            });

            builder.Entity<BranchStaff>(entity =>
            {
                entity.ToTable("tblBranchStaff");
            });

            builder.Entity<BranchStaffResignation>(entity =>
            {
                entity.ToTable("tblBranchStaffResignations");
            });

            builder.Entity<CellGroup>(entity =>
            {
                entity.ToTable("tblCellGroups");
            });

            builder.Entity<CellGroupHost>(entity =>
            {
                entity.ToTable("tblCellGroupHosts");
            });
            
            builder.Entity<CellLeadership>(entity =>
            {
                entity.ToTable("tblCellLeaderships");
            });

            builder.Entity<ChurchProgram>(entity =>
            {
                entity.ToTable("tblChurchPrograms")
                .HasData(
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        Name = "Sunday First Service",
                        Description = "Sunday First Service",
                        IsActive = true
                    },
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        Name = "Sunday Second Service",
                        Description = "Sunday Second Service",
                        IsActive = true
                    },
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        Name = "Sunday Youth Service",
                        Description = "Sunday Youth Service",
                        IsActive = true
                    },
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        Name = "Sunday Local Language Service",
                        Description = "Sunday Local Language Service",
                        IsActive = true
                    },
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        Name = "Mid-week Service",
                        Description = "Mid-week Service",
                        IsActive = true
                    }
                    ,
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        Name = "3 Days of Power",
                        Description = "3 Days of Power conference",
                        IsActive = true
                    },
                    new ChurchProgram
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 7,
                        Name = "Easter Conference",
                        Description = "Easter Conference",
                        IsActive = true
                    }
                    );
            });

            builder.Entity<ChurchProgramSession>(entity =>
            {
                entity.ToTable("tblChurchProgramSessions");
            });

            builder.Entity<ChurchProgramSessionAttendance>(entity =>
            {
                entity.ToTable("tblChurchProgramSessionAttendances");
            });

            builder.Entity<ChurchProgramSessionVisitor>(entity =>
            {
                entity.ToTable("tblChurchProgramSessionVistors");
            });

            builder.Entity<IncomingTransfer>(entity =>
            {
                entity.ToTable("tblIncomingTransfers");
            });

            builder.Entity<Ministry>(entity =>
            {
                entity.ToTable("tblMinistries");
            });
            
            builder.Entity<OutgoingTransfer>(entity =>
            {
                entity.ToTable("tblOutgoingTransfers");
            });

            #endregion Branches Builder Entities

            #region Locations Builder Entities
            builder.Entity<ChurchSettings>(entity =>
            {
                entity.ToTable("tblChurchSettings");
            });

            builder.Entity<Continent>(entity =>
            {
                entity.ToTable("tblContinents")
                .HasData(
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        Name = "Africa"
                    },
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        Name = "Australia"
                    },
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        Name = "North America"
                    },
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        Name = "South America"
                    },
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        Name = "Europe"
                    },
                    new Continent
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        Name = "Asia"
                    });
            });

            builder.Entity<Country>(entity =>
            {
                entity.ToTable("tblCountries")
                .HasData(
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        ContinentId = 1,
                        Code = "zm",
                        Name = "Zambia"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        ContinentId = 1,
                        Code = "cd",
                        Name = "Democratic Republic of Congo"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        ContinentId = 1,
                        Code = "na",
                        Name = "Namibia"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        ContinentId = 1,
                        Code = "za",
                        Name = "South Africa"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        ContinentId = 1,
                        Code = "mw",
                        Name = "Malawi"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        ContinentId = 1,
                        Code = "tz",
                        Name = "Tanzania"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 7,
                        ContinentId = 1,
                        Code = "bw",
                        Name = "Botswana"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 8,
                        ContinentId = 3,
                        Code = "us",
                        Name = "United States"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 9,
                        ContinentId = 2,
                        Code = "au",
                        Name = "Australia"
                    },
                    new Country
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 10,
                        ContinentId = 5,
                        Code = "gb",
                        Name = "United Kingdom"
                    }
                    );
            }
            );

            builder.Entity<Region>(entity =>
            {
                entity.ToTable("tblRegions")
                .HasData(
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        CountryId = 1,
                        Name = "North-Western"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        CountryId = 1,
                        Name = "Northern"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        CountryId = 1,
                        Name = "Muchinga"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        CountryId = 1,
                        Name = "Luapula"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        CountryId = 1,
                        Name = "Eastern"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        CountryId = 1,
                        Name = "Lusaka"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 7,
                        CountryId = 1,
                        Name = "Central"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 8,
                        CountryId = 1,
                        Name = "Copperbelt-South"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 9,
                        CountryId = 1,
                        Name = "Copperbelt-North"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 10,
                        CountryId = 1,
                        Name = "Southern"
                    },
                    new Region
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 11,
                        CountryId = 1,
                        Name = "Western"
                    }
                    );
            }
            );

            builder.Entity<RegionLeadership>(entity =>
            {
                entity.ToTable("tblRegionLeaderships");

            });
            #endregion Locations Builder Entities

            #region Members Builder Entities
            builder.Entity<EducationField>(entity =>
            {
                entity.ToTable("tblEducationFields");
            });

            builder.Entity<EducationLevel>(entity =>
            {
                entity.ToTable("tblEducationLevels")
                .HasData(
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        Name = "None"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        Name = "Doctorate (PhD)"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        Name = "Masters"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        Name = "Degree"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        Name = "Diploma"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        Name = "Certificate"
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 7,
                        Name = "Secondary Ed."
                    },
                    new EducationLevel
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 8,
                        Name = "Primary Ed."
                    });
            });

            builder.Entity<Family>(entity =>
            {
                entity.ToTable("tblFamilies");
                entity.HasOne(f => f.Administrator).WithOne().HasForeignKey<Family>(f => f.FamilyAdminId);
            });

            builder.Entity<LeadershipRole>(entity =>
            {
                entity.ToTable("tblLeadershipRoles");
            });

            builder.Entity<Member>(entity =>
            {
                entity.ToTable("tblMembers");
            });

            builder.Entity<MemberEducation>(entity =>
            {
                entity.ToTable("tblMemberEducations");
            });

            builder.Entity<MemberTransaction>(entity =>
            {
                entity.ToTable("tblMemberTransactions");
            });

            builder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("tblTransactionTypes")
                .HasData(
                    new TransactionType
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        Name = "Cash"
                    },
                    new TransactionType
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        Name = "Mobile Money"
                    },
                    new TransactionType
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        Name = "Card"
                    });
            });
            #endregion Members Builder Entities             

            #region User Builder Entities  
            builder.Entity<Module>(entity =>
            {
                entity.ToTable("tblModules")
                .HasData(
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 1,
                        Name = "Admin",
                        Description = "Master access to all modules",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 2,
                        Name = "Users",
                        Description = "Users Management System Module",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 3,
                        Name = "Accounting",
                        Description = "Accounting System Module",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 4,
                        Name = "Reports",
                        Description = "Reporting System Module",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 5,
                        Name = "Branches",
                        Description = "Branches System Module",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 6,
                        Name = "Locations",
                        Description = "Locations System Module",
                        IsActive = true
                    },
                    new Module
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = 7,
                        Name = "Members",
                        Description = "Members System Module",
                        IsActive = true
                    }
                    );
                entity.HasIndex(c => c.Name)
                .IsUnique();
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("tblRoles")
                .HasData(
                    new IdentityRole
                    {
                        Id = ROLE_ID,
                        Name = "Admin",
                        NormalizedName = "Admin".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "f077ed29-51b7-4fe7-8136-c65b8e7b3f15",
                        Name = "BranchUser",
                        NormalizedName = "BranchUser".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "a173a5cc-3edc-4f49-979c-f423e044b202",
                        Name = "Member",
                        NormalizedName = "Member".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "f0223225-0c52-413d-b188-0868ea111427",
                        Name = "Visitor",
                        NormalizedName = "Visitor".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "575759c6-e020-4c4b-888d-24e01ba62797",
                        Name = "Pastor",
                        NormalizedName = "Pastor".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "0a8baeb0-7191-4731-b8f2-a8b22b5a8596",
                        Name = "CellGroupLeader",
                        NormalizedName = "CellGroupLeader".ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = "a1922985-be01-4762-a2b6-32d6f4f58235",
                        Name = "MinistryLeader",
                        NormalizedName = "MinistryLeader".ToUpper(),
                    }
                    );
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("tblUserRoles")
                .HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = ADMIN_ID,
                        RoleId = ROLE_ID,
                    });
            });

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<User>(entity =>
            {
                entity.ToTable("tblUsers")
                .HasData(
                    new User
                    {
                        MakerId = ADMIN_ID,
                        SubmissionDate = DateTime.UtcNow.AddHours(2),
                        CheckerId = ADMIN_ID,
                        ApprovalDate = DateTime.UtcNow.AddHours(2),
                        RejectionDate = null,
                        Id = ADMIN_ID,
                        UserName = "superadmin@blci.com",
                        NormalizedUserName = "superadmin@blci.com".ToUpper(),
                        Email = "superadmin@blci.com",
                        NormalizedEmail = "superadmin@blci.com".ToUpper(),
                        Description = "Systems Administrator",
                        Fullname = "Super Admin",
                        PasswordHash = hasher.HashPassword(null, "Jesus+Faith=Life"),
                        EmailConfirmed = true,
                        IsActive = true
                    });
            });            

            builder.Entity<RoleModule>(entity =>
            {
                entity.ToTable("tblRoleModules")
                .HasIndex(el => new { el.ModuleId, el.RoleId }).IsUnique();
                entity.HasKey(t => t.Id);
            });
            #endregion User Builder Entities           
        }

        public override int SaveChanges()
        {
            UpdateAuditEntities();
            return base.SaveChanges();
        }


        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            UpdateAuditEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(cancellationToken);
        }


        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        private void UpdateAuditEntities()
        {
            var auditEntries = new List<AuditEntry>();

            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));


            foreach (var entry in modifiedEntries)
            {
                var entity = (IAuditableEntity)entry.Entity;
                DateTime now = DateTime.UtcNow.AddHours(2);

                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = CurrentUserId;
                auditEntries.Add(auditEntry);
                foreach (var property in entry.Properties)
                {
                    string propertyName = property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }
                    switch (entry.State)
                    {
                        case EntityState.Unchanged:

                            break;
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[propertyName] = property.CurrentValue;
                            break;
                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[propertyName] = property.OriginalValue;
                            break;
                        case EntityState.Modified:

                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(propertyName);
                                if (auditEntry.TableName == "tblUsers")
                                    auditEntry.AuditType = AuditType.LogIn;
                                else
                                    auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                            }
                            break;
                    }
                }

                if (entry.State == EntityState.Added)
                {
                    entity.SubmissionDate = now;
                    entity.MakerId = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.MakerId).IsModified = false;
                    base.Entry(entity).Property(x => x.SubmissionDate).IsModified = false;
                }

                entity.ApprovalDate = now;
                entity.CheckerId = CurrentUserId;
            }

            foreach (var auditEntry in auditEntries)
            {
                AuditLogs.Add(auditEntry.ToAudit());
            }
        }
    }
}
