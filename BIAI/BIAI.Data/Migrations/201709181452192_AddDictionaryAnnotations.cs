namespace BIAI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDictionaryAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AttackRecords", "Weapon_Id", c => c.Long());
            CreateIndex("dbo.AttackRecords", "Weapon_Id");
            AddForeignKey("dbo.AttackRecords", "Weapon_Id", "dbo.Weapons", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttackRecords", "Weapon_Id", "dbo.Weapons");
            DropIndex("dbo.AttackRecords", new[] { "Weapon_Id" });
            DropColumn("dbo.AttackRecords", "Weapon_Id");
        }
    }
}
