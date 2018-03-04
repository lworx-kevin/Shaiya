namespace Shaiya.Data.GameData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=GameDataDataModel")
        {
        }

        public virtual DbSet<BanChar> BanChars { get; set; }
        public virtual DbSet<CharApplySkill> CharApplySkills { get; set; }
        public virtual DbSet<CharItem> CharItems { get; set; }
        public virtual DbSet<CharQuest> CharQuests { get; set; }
        public virtual DbSet<CharQuickSlot> CharQuickSlots { get; set; }
        public virtual DbSet<CHAR> CHARS { get; set; }
        public virtual DbSet<CharSavePoint> CharSavePoints { get; set; }
        public virtual DbSet<CharSkill> CharSkills { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<FriendChar> FriendChars { get; set; }
        public virtual DbSet<GuildChar> GuildChars { get; set; }
        public virtual DbSet<Guild> Guilds { get; set; }
        public virtual DbSet<Keep> Keeps { get; set; }
        public virtual DbSet<UserMaxGrow> UserMaxGrows { get; set; }
        public virtual DbSet<UserStoredMoney> UserStoredMoneys { get; set; }
        public virtual DbSet<C_GuildDetailsBack> C_GuildDetailsBack { get; set; }
        public virtual DbSet<CharEvent> CharEvents { get; set; }
        public virtual DbSet<GuildDetail> GuildDetails { get; set; }
        public virtual DbSet<GuildNpcLv> GuildNpcLvs { get; set; }
        public virtual DbSet<GuildRankLog> GuildRankLogs { get; set; }
        public virtual DbSet<GuildRankLog2> GuildRankLog2 { get; set; }
        public virtual DbSet<GuildStoredItem> GuildStoredItems { get; set; }
        public virtual DbSet<InsertSlotList> InsertSlotLists { get; set; }
        public virtual DbSet<PointGiftNotify> PointGiftNotifies { get; set; }
        public virtual DbSet<PointLog> PointLogs { get; set; }
        public virtual DbSet<ProductLog> ProductLogs { get; set; }
        public virtual DbSet<SlotList> SlotLists { get; set; }
        public virtual DbSet<UserStoredItem> UserStoredItems { get; set; }
        public virtual DbSet<UserStoredPointItem> UserStoredPointItems { get; set; }
        public virtual DbSet<WorldInfo> WorldInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanChar>()
                .Property(e => e.BanName)
                .IsUnicode(false);

            modelBuilder.Entity<BanChar>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<CharItem>()
                .Property(e => e.Craftname)
                .IsUnicode(false);

            modelBuilder.Entity<CharItem>()
                .Property(e => e.Maketype)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.CharName)
                .IsUnicode(false);

            modelBuilder.Entity<Character>()
                .Property(e => e.OldCharName)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<FriendChar>()
                .Property(e => e.FriendName)
                .IsUnicode(false);

            modelBuilder.Entity<FriendChar>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<Guild>()
                .Property(e => e.GuildName)
                .IsUnicode(false);

            modelBuilder.Entity<Guild>()
                .Property(e => e.MasterUserID)
                .IsUnicode(false);

            modelBuilder.Entity<Guild>()
                .Property(e => e.MasterName)
                .IsUnicode(false);

            modelBuilder.Entity<C_GuildDetailsBack>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<GuildDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<GuildStoredItem>()
                .Property(e => e.Craftname)
                .IsUnicode(false);

            modelBuilder.Entity<GuildStoredItem>()
                .Property(e => e.Maketype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PointGiftNotify>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<PointGiftNotify>()
                .Property(e => e.SendCharName)
                .IsUnicode(false);

            modelBuilder.Entity<PointLog>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<PointLog>()
                .Property(e => e.TargetName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductLog>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<UserStoredItem>()
                .Property(e => e.Craftname)
                .IsUnicode(false);

            modelBuilder.Entity<UserStoredItem>()
                .Property(e => e.Maketype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserStoredPointItem>()
                .Property(e => e.GroupName)
                .IsUnicode(false);
        }
    }
}
