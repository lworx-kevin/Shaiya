namespace Shaiya.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameDefsDataModel : DbContext
    {
        public GameDefsDataModel()
            : base("name=GameDefsDataModel")
        {
        }

        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<ExpDef> ExpDefs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<MobItem> MobItems { get; set; }
        public virtual DbSet<Mob> Mobs { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<StatusDef> StatusDefs { get; set; }
        public virtual DbSet<BaseItemsDef> BaseItemsDefs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Mob>()
                .Property(e => e.MobName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductList>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<ProductList>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.SkillName)
                .IsUnicode(false);
        }
    }
}
