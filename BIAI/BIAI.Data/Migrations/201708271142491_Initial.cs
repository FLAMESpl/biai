namespace BIAI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttackRecords",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Year = c.Long(nullable: false),
                        Month = c.Long(nullable: false),
                        Day = c.Long(nullable: false),
                        Extended24Hours = c.Boolean(),
                        CountryId = c.Long(),
                        RegionId = c.Long(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        Specificity = c.Long(),
                        Vicinity = c.Boolean(),
                        PoliticalEconomicReligiousOrSocialGoal = c.Boolean(),
                        IntentionToCoerceOrIntimidate = c.Boolean(),
                        OutsideInternationalHumanitarianLaw = c.Boolean(),
                        TerrorismDoubt = c.Boolean(),
                        AlternativeCategory = c.Int(),
                        PartOfMultipleIncident = c.Boolean(),
                        WasSuccessful = c.Boolean(),
                        WasSuicidalAttack = c.Boolean(),
                        AttackType = c.Int(nullable: false),
                        TargetTypeId = c.Long(),
                        TargetSubTypeId = c.Long(),
                        OrganizationNameDeduced = c.Boolean(),
                        WasIndividualAttack = c.Boolean(),
                        NumberOfAttackers = c.Int(),
                        ResponsibilityWasClaimed = c.Boolean(),
                        ClaimMode = c.Int(),
                        WasClaimCompeting = c.Int(),
                        WeaponTypeId = c.Long(),
                        Fatalities = c.Long(nullable: false),
                        USCitizensKilled = c.Long(),
                        TerroristsKilled = c.Long(),
                        PeopleInjured = c.Long(),
                        USCitizensInjured = c.Long(),
                        TerroristsInjured = c.Long(),
                        WasPropertyDamaged = c.Int(),
                        PropertyDamageValueClass = c.Int(),
                        PropertyDamageValue = c.Long(),
                        WasHostageKidnapped = c.Int(),
                        NumberOfHostagesKidnapped = c.Int(),
                        NumberOfUSCitizensKidnapped = c.Int(),
                        WasRansomDemanded = c.Int(),
                        HostageKidnappingOutcome = c.Int(),
                        HostagesSurvived = c.Int(),
                        WasLogisticallyInternational = c.Int(),
                        WasIdeologicallyInternational = c.Int(),
                        WasInternational = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .ForeignKey("dbo.TargetSubtypes", t => t.TargetSubTypeId)
                .ForeignKey("dbo.TargetTypes", t => t.TargetTypeId)
                .Index(t => t.CountryId)
                .Index(t => t.RegionId)
                .Index(t => t.TargetTypeId)
                .Index(t => t.TargetSubTypeId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TargetSubtypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TargetTypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttackRecords", "TargetTypeId", "dbo.TargetTypes");
            DropForeignKey("dbo.AttackRecords", "TargetSubTypeId", "dbo.TargetSubtypes");
            DropForeignKey("dbo.AttackRecords", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.AttackRecords", "CountryId", "dbo.Countries");
            DropIndex("dbo.AttackRecords", new[] { "TargetSubTypeId" });
            DropIndex("dbo.AttackRecords", new[] { "TargetTypeId" });
            DropIndex("dbo.AttackRecords", new[] { "RegionId" });
            DropIndex("dbo.AttackRecords", new[] { "CountryId" });
            DropTable("dbo.Weapons");
            DropTable("dbo.TargetTypes");
            DropTable("dbo.TargetSubtypes");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.AttackRecords");
        }
    }
}
