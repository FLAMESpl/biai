using BIAI.Data.Model.Annotations;
using BIAI.Data.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIAI.Data.Model
{
    public class AttackRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; private set; }
        public long Year { get; private set; }
        public long Month { get; private set; }
        public long Day { get; private set; }
        public bool? Extended24Hours { get; private set; }

        [Dictionary("Countries")]
        public long? CountryId { get; private set; }

        [Dictionary("Regions")]
        public long? RegionId { get; private set; }
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }
        public long? Specificity { get; private set; }
        public bool? Vicinity { get; private set; }
        public bool? PoliticalEconomicReligiousOrSocialGoal { get; private set; }
        public bool? IntentionToCoerceOrIntimidate { get; private set; }
        public bool? OutsideInternationalHumanitarianLaw { get; private set; }
        public bool? TerrorismDoubt { get; private set; }
        public int? AlternativeCategory { get; set; }
        public bool? PartOfMultipleIncident { get; private set; }
        public bool? WasSuccessful { get; private set; }
        public bool? WasSuicidalAttack { get; private set; }
        public AttackType AttackType { get; private set; }

        [Dictionary("TargetTypes")]
        public long? TargetTypeId { get; private set; }

        [Dictionary("TargetSubtypes")]
        public long? TargetSubTypeId { get; private set; }
        public bool? OrganizationNameDeduced { get; private set; }
        public bool? WasIndividualAttack { get; private set; }
        public int? NumberOfAttackers { get; private set; }
        public bool? ResponsibilityWasClaimed { get; private set; }
        public ClaimMode? ClaimMode { get; private set; }
        public DoubtBoolean? WasClaimCompeting { get; private set; }

        [Dictionary("Weapons")]
        public long? WeaponTypeId { get; private set; }
        public long Fatalities { get; private set; }
        public long? USCitizensKilled { get; private set; }
        public long? TerroristsKilled { get; private set; }
        public long? PeopleInjured { get; private set; }
        public long? USCitizensInjured { get; private set; }
        public long? TerroristsInjured { get; private set; }
        public DoubtBoolean? WasPropertyDamaged { get; private set; }
        public PropertyDamageValue? PropertyDamageValueClass { get; private set; }
        public long? PropertyDamageValue { get; private set; }
        public DoubtBoolean? WasHostageKidnapped { get; private set; }
        public int? NumberOfHostagesKidnapped { get; private set; }
        public int? NumberOfUSCitizensKidnapped { get; private set; }
        public DoubtBoolean? WasRansomDemanded { get; private set; }
        public HostageKidnappingOutcome? HostageKidnappingOutcome { get; private set; }
        public int? HostagesSurvived { get; private set; }
        public DoubtBoolean? WasLogisticallyInternational { get; private set; }
        public DoubtBoolean? WasIdeologicallyInternational { get; private set; }
        public DoubtBoolean? WasInternational { get; private set; }
        
        public Country Country { get; private set; }
        public Region Region { get; private set; }
        public TargetType TargetType { get; private set; }
        public TargetSubtype TargetSubtype { get; private set; }
        public Weapon Weapon { get; private set; }
    }
}
