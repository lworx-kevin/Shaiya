namespace Shaiya.Data.UserData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=UserDataDataModel")
        {
        }

        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Users_Master> Users_Master { get; set; }
        public virtual DbSet<UserBlockLog> UserBlockLogs { get; set; }
        public virtual DbSet<UserLeaveLog> UserLeaveLogs { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public virtual DbSet<UserPauseLog> UserPauseLogs { get; set; }
        public virtual DbSet<UserPointChargeLog> UserPointChargeLogs { get; set; }
        public virtual DbSet<Users_Block> Users_Block { get; set; }
        public virtual DbSet<Users_BlockLog> Users_BlockLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.Pw)
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.UserType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.UserIp)
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.ModiIp)
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.Enpassword)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users_Master>()
                .Property(e => e.Birth)
                .IsUnicode(false);

            modelBuilder.Entity<UserBlockLog>()
                .Property(e => e.Cause)
                .IsUnicode(false);

            modelBuilder.Entity<UserBlockLog>()
                .Property(e => e.ProcAdminID)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.Phone3)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.LeaveQuestion1)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.LeaveQuestion2)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.LeaveQuestion3)
                .IsUnicode(false);

            modelBuilder.Entity<UserLeaveLog>()
                .Property(e => e.ProcAdminID)
                .IsUnicode(false);

            modelBuilder.Entity<UserLoginLog>()
                .Property(e => e.UserIP)
                .IsUnicode(false);

            modelBuilder.Entity<UserLoginLog>()
                .Property(e => e.ErrMsg)
                .IsUnicode(false);

            modelBuilder.Entity<UserPauseLog>()
                .Property(e => e.Cause)
                .IsUnicode(false);

            modelBuilder.Entity<UserPauseLog>()
                .Property(e => e.ProcAdminID)
                .IsUnicode(false);

            modelBuilder.Entity<UserPointChargeLog>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Users_BlockLog>()
                .Property(e => e.GmID)
                .IsUnicode(false);
        }
    }
}
