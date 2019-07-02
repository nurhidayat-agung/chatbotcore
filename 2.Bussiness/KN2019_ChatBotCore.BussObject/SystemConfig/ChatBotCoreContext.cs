using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KN2019_ChatBotCore.BussObject.SystemConfig
{
    public partial class ChatBotCoreContext : DbContext
    {
        public ChatBotCoreContext()
        {
        }

        public ChatBotCoreContext(DbContextOptions<ChatBotCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MChatDetail> MChatDetail { get; set; }
        public virtual DbSet<MMenu> MMenu { get; set; }
        public virtual DbSet<MModule> MModule { get; set; }
        public virtual DbSet<MRole> MRole { get; set; }
        public virtual DbSet<MRoleAccess> MRoleAccess { get; set; }
        public virtual DbSet<MSystemConfiguration> MSystemConfiguration { get; set; }
        public virtual DbSet<MUser> MUser { get; set; }
        public virtual DbSet<MUserChat> MUserChat { get; set; }
        public virtual DbSet<MUserRole> MUserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.104.1.249;Database=ChatBotDB;User ID=usrChatBotDB;Password=usrChatBotDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<MChatDetail>(entity =>
            {
                entity.ToTable("mChatDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IntOrigin).HasColumnName("intOrigin");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtMessage)
                    .HasColumnName("txtMessage")
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUserId)
                    .HasColumnName("txtUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MMenu>(entity =>
            {
                entity.ToTable("mMenu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntModuleId).HasColumnName("intModuleID");

                entity.Property(e => e.IntOrderId).HasColumnName("intOrderID");

                entity.Property(e => e.IntParentId).HasColumnName("intParentID");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDescription)
                    .HasColumnName("txtDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtLink)
                    .HasColumnName("txtLink")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxtMenuName)
                    .HasColumnName("txtMenuName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MModule>(entity =>
            {
                entity.ToTable("mModule");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDescription)
                    .HasColumnName("txtDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtModuleName)
                    .HasColumnName("txtModuleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MRole>(entity =>
            {
                entity.ToTable("mRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.BitSuperuser).HasColumnName("bitSuperuser");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtRoleName)
                    .HasColumnName("txtRoleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MRoleAccess>(entity =>
            {
                entity.ToTable("mRoleAccess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.BitDelete).HasColumnName("bitDelete");

                entity.Property(e => e.BitEdit).HasColumnName("bitEdit");

                entity.Property(e => e.BitPrint).HasColumnName("bitPrint");

                entity.Property(e => e.BitView).HasColumnName("bitView");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntModuleId).HasColumnName("intModuleID");

                entity.Property(e => e.IntRoleId).HasColumnName("intRoleID");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MSystemConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TxtKeyId });

                entity.ToTable("mSystemConfiguration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxtKeyId)
                    .HasColumnName("txtKeyID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntModuleId).HasColumnName("intModuleID");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDefaultValue)
                    .HasColumnName("txtDefaultValue")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDescription)
                    .HasColumnName("txtDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtValue)
                    .HasColumnName("txtValue")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUser>(entity =>
            {
                entity.ToTable("mUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.BitUseActiveDirectory).HasColumnName("bitUseActiveDirectory");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntDepartmentId).HasColumnName("intDepartmentID");

                entity.Property(e => e.IntLobid).HasColumnName("intLOBID");

                entity.Property(e => e.TxtCompanyCode)
                    .HasColumnName("txtCompanyCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtDomainName)
                    .HasColumnName("txtDomainName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtEmail)
                    .HasColumnName("txtEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtEmpId)
                    .HasColumnName("txtEmpID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TxtNick)
                    .HasColumnName("txtNick")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TxtPassword)
                    .HasColumnName("txtPassword")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUserName)
                    .HasColumnName("txtUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUserChat>(entity =>
            {
                entity.ToTable("mUserChat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.BitShpempl).HasColumnName("bitSHPEmpl");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtEmail)
                    .HasColumnName("txtEmail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxtGender)
                    .HasColumnName("txtGender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TxtName)
                    .HasColumnName("txtName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxtSection)
                    .HasColumnName("txtSection")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUserId)
                    .HasColumnName("txtUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUserRole>(entity =>
            {
                entity.ToTable("mUserRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BitActive).HasColumnName("bitActive");

                entity.Property(e => e.DtCreateDate)
                    .HasColumnName("dtCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdateDate)
                    .HasColumnName("dtUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntRoleId).HasColumnName("intRoleID");

                entity.Property(e => e.IntUserId).HasColumnName("intUserID");

                entity.Property(e => e.TxtCreateBy)
                    .HasColumnName("txtCreateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtUpdateBy)
                    .HasColumnName("txtUpdateBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
