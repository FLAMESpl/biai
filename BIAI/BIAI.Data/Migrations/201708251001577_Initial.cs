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
                        Id = c.Long(nullable: false, identity: true),
                        Year = c.Long(nullable: false),
                        Month = c.Long(nullable: false),
                        Day = c.Long(nullable: false),
                        Extended24Hours = c.Boolean(nullable: false),
                        Resolution = c.String(),
                        CountryId = c.Long(nullable: false),
                        RegionId = c.Long(nullable: false),
                        City = c.String(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        Specificity = c.Long(nullable: false),
                        Vicinity = c.Boolean(nullable: false),
                        PoliticalEconomicReligiousOrSocialGoal = c.Boolean(nullable: false),
                        IntentionToCoerceOrIntimidate = c.Boolean(nullable: false),
                        OutsideInternationalHumanitarianLaw = c.Boolean(nullable: false),
                        TerrorismDoubt = c.Boolean(),
                        AlternativeCategory = c.Int(nullable: false),
                        PartOfMultipleIncident = c.Boolean(),
                        WasSuccessful = c.Boolean(nullable: false),
                        WasSuicidalAttack = c.Boolean(nullable: false),
                        AttackType = c.Int(nullable: false),
                        TargetTypeId = c.Long(nullable: false),
                        TargetSubTypeId = c.Long(nullable: false),
                        OrganizationName = c.String(),
                        OrganizationNameDeduced = c.Boolean(nullable: false),
                        WasIndividualAttack = c.Boolean(nullable: false),
                        NumberOfAttackers = c.Int(),
                        ResponsibilityWasClaimed = c.Boolean(nullable: false),
                        ClaimMode = c.Int(),
                        WasClaimCompeting = c.Int(),
                        WeaponTypeId = c.Long(),
                        WeaponSubtypeId = c.Long(),
                        Fatalities = c.Long(nullable: false),
                        USCitizensKilled = c.Long(),
                        TerroristsKilled = c.Long(),
                        PeopleInjured = c.Long(),
                        USCitizensInjured = c.Long(),
                        TerroristsInjured = c.Long(),
                        WasPropertyDamaged = c.Int(),
                        PropertyDamageValueClass = c.Int(),
                        PropertyDamageValue = c.Long(nullable: false),
                        WasHostageKidnapped = c.Int(),
                        NumberOfHostagesKidnapped = c.Int(),
                        NumberOfUSCitizensKidnapped = c.Int(),
                        HoursThatHostagesWasKidnapped = c.Int(nullable: false),
                        DaysThatHostagesWasKidnapped = c.Int(nullable: false),
                        WasRansomDemanded = c.Int(),
                        RansomPaid = c.Long(nullable: false),
                        RansomPaidByUS = c.Long(nullable: false),
                        HostageKidnappingOutcome = c.Int(),
                        HostagesSurvived = c.Int(nullable: false),
                        DatabaseSource = c.String(),
                        WasLogisticallyInternational = c.Int(),
                        WasIdeologicallyInternational = c.Int(),
                        WasInternational = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.TargetSubtypes", t => t.TargetSubTypeId, cascadeDelete: true)
                .ForeignKey("dbo.TargetTypes", t => t.TargetTypeId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.RegionId)
                .Index(t => t.TargetTypeId)
                .Index(t => t.TargetSubTypeId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TargetSubtypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TargetTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
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
            DropTable("dbo.TargetTypes");
            DropTable("dbo.TargetSubtypes");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.AttackRecords");
        }
    }
}
