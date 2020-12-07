using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CSC_Assistant.Client.DataStructures
{
    public class GameDataForDisplay
    {
        [JsonPropertyName("allowRNG")]
        public bool AllowRNG { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("refineTimePerUnit")]
        public int RefineTimePerUnit { get; set; }

        [JsonPropertyName("qty")]
        public string Qty { get; set; }

        [JsonPropertyName("fruitIndex")]
        public string FruitIndex { get; set; }

        [JsonPropertyName("cabinRequirement")]
        public string CabinRequirement { get; set; }

        [JsonPropertyName("blueprintForItemID")]
        public string BlueprintForItemID { get; set; }

        [JsonPropertyName("blueprintPoints")]
        public int? BlueprintPoints { get; set; }

        [JsonPropertyName("blueprintTechLevel")]
        public string BlueprintTechLevel { get; set; }

        [JsonPropertyName("setMaxSkillpoints")]
        public bool? SetMaxSkillpoints { get; set; }

        [JsonPropertyName("allowRngRewards")]
        public bool? AllowRngRewards { get; set; }

        [JsonPropertyName("arriveSpeed")]
        public double? ArriveSpeed { get; set; }

        [JsonPropertyName("avoidancePrediction")]
        public double? AvoidancePrediction { get; set; }

        [JsonPropertyName("baseCargo")]
        public int? BaseCargo { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("decelerationSpeed")]
        public double? DecelerationSpeed { get; set; }

        [JsonPropertyName("enginePowerBase")]
        public int? EnginePowerBase { get; set; }

        [JsonPropertyName("hardPointsLimit")]
        public int? HardPointsLimit { get; set; }

        [JsonPropertyName("hull")]
        public int? Hull { get; set; }

        [JsonPropertyName("insuranceState")]
        public int? InsuranceState { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("mass")]
        public double? Mass { get; set; }

        [JsonPropertyName("maxCamDistance")]
        public int? MaxCamDistance { get; set; }

        [JsonPropertyName("maxRadarDistance")]
        public int? MaxRadarDistance { get; set; }

        [JsonPropertyName("maxSlipStream")]
        public double? MaxSlipStream { get; set; }

        [JsonPropertyName("maxSublightSpeed")]
        public int? MaxSublightSpeed { get; set; }

        [JsonPropertyName("minCamDistance")]
        public double? MinCamDistance { get; set; }

        [JsonPropertyName("minSpeedAvoidance")]
        public double? MinSpeedAvoidance { get; set; }

        [JsonPropertyName("multTractorLootDistance")]
        public int? MultTractorLootDistance { get; set; }

        [JsonPropertyName("powerRechargeInc")]
        public int? PowerRechargeInc { get; set; }

        [JsonPropertyName("powerRechargeRate")]
        public double? PowerRechargeRate { get; set; }

        [JsonPropertyName("powerRecovery")]
        public string PowerRecovery { get; set; }

        [JsonPropertyName("powerTotal")]
        public int? PowerTotal { get; set; }

        [JsonPropertyName("prefab")]
        public string Prefab { get; set; }

        [JsonPropertyName("rotationRollSpeed")]
        public double? RotationRollSpeed { get; set; }

        [JsonPropertyName("rotationSpeed")]
        public double? RotationSpeed { get; set; }

        [JsonPropertyName("seekSpeed")]
        public double? SeekSpeed { get; set; }

        [JsonPropertyName("shieldPowerBase")]
        public int? ShieldPowerBase { get; set; }

        [JsonPropertyName("shieldRechargeInc")]
        public int? ShieldRechargeInc { get; set; }

        [JsonPropertyName("shieldRechargeRate")]
        public double? ShieldRechargeRate { get; set; }

        [JsonPropertyName("shields")]
        public int? Shields { get; set; }

        [JsonPropertyName("shipID")]
        public string ShipID { get; set; }

        [JsonPropertyName("slipstreamAvoidanceLimiter")]
        public string SlipstreamAvoidanceLimiter { get; set; }

        [JsonPropertyName("slowTurnAngle")]
        public int? SlowTurnAngle { get; set; }

        [JsonPropertyName("slowestTurnSpeed")]
        public int? SlowestTurnSpeed { get; set; }

        [JsonPropertyName("subType")]
        public string SubType { get; set; }

        [JsonPropertyName("timeTillSlipstreamEngage")]
        public int? TimeTillSlipstreamEngage { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("weaponRechargeInc")]
        public int? WeaponRechargeInc { get; set; }

        [JsonPropertyName("weaponRechargeRate")]
        public double? WeaponRechargeRate { get; set; }

        [JsonPropertyName("beamDPS")]
        public double? BeamDPS { get; set; }

        [JsonPropertyName("coolDown")]
        public double? CoolDown { get; set; }

        [JsonPropertyName("effectivenessOnArmor")]
        public double? EffectivenessOnArmor { get; set; }

        [JsonPropertyName("effectivenessOnHull")]
        public double? EffectivenessOnHull { get; set; }

        [JsonPropertyName("effectivenessOnShield")]
        public double? EffectivenessOnShield { get; set; }

        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        [JsonPropertyName("powerBase")]
        public int? PowerBase { get; set; }

        [JsonPropertyName("powerDraw")]
        public int? PowerDraw { get; set; }

        [JsonPropertyName("durability")]
        public int? Durability { get; set; }

        [JsonPropertyName("noInvention")]
        public bool? NoInvention { get; set; }

        [JsonPropertyName("toggleable")]
        public bool? Toggleable { get; set; }

        [JsonPropertyName("craftingAmounts")]
        public string CraftingAmounts { get; set; }

        [JsonPropertyName("craftingRecipe")]
        public string CraftingRecipe { get; set; }

        [JsonPropertyName("craftingTime")]
        public int? CraftingTime { get; set; }

        [JsonPropertyName("avgDPS")]
        public string AvgDPS { get; set; }

        [JsonPropertyName("damageType")]
        public string DamageType { get; set; }

        [JsonPropertyName("delayPerShot")]
        public double? DelayPerShot { get; set; }

        [JsonPropertyName("effectiveTargetingSpeed")]
        public double? EffectiveTargetingSpeed { get; set; }

        [JsonPropertyName("maxTargetLockRange")]
        public int? MaxTargetLockRange { get; set; }

        [JsonPropertyName("projectileDamageAmount")]
        public int? ProjectileDamageAmount { get; set; }

        [JsonPropertyName("projectileHitSize")]
        public double? ProjectileHitSize { get; set; }

        [JsonPropertyName("projectileLifetime")]
        public double? ProjectileLifetime { get; set; }

        [JsonPropertyName("projectileShoutCount")]
        public int? ProjectileShoutCount { get; set; }

        [JsonPropertyName("projectileSpeed")]
        public double? ProjectileSpeed { get; set; }

        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        [JsonPropertyName("spotDPS")]
        public string SpotDPS { get; set; }

        [JsonPropertyName("weaponRange")]
        public int? WeaponRange { get; set; }

        [JsonPropertyName("colonistCount")]
        public int? ColonistCount { get; set; }

        [JsonPropertyName("holoIconLocation")]
        public string HoloIconLocation { get; set; }

        [JsonPropertyName("preLaunchBp")]
        public string PreLaunchBp { get; set; }

        [JsonPropertyName("bonuses")]
        public Bonuses Bonuses { get; set; }

        [JsonPropertyName("shipVisualID")]
        public string ShipVisualID { get; set; }

        [JsonPropertyName("soundType")]
        public string SoundType { get; set; }

        [JsonPropertyName("ContianerExpectedQty")]
        public string ContianerExpectedQty { get; set; }

        [JsonPropertyName("ContianerForItemID")]
        public string ContianerForItemID { get; set; }

        [JsonPropertyName("ContianerWeightReductionAmount")]
        public string ContianerWeightReductionAmount { get; set; }

        [JsonPropertyName("deconstructionResourcePercentageOverride")]
        public string DeconstructionResourcePercentageOverride { get; set; }

        [JsonPropertyName("previousTechLevel")]
        public string PreviousTechLevel { get; set; }

        [JsonPropertyName("radarData")]
        public string RadarData { get; set; }

        [JsonPropertyName("radarRange")]
        public string RadarRange { get; set; }

        [JsonPropertyName("energyResistance")]
        public string EnergyResistance { get; set; }

        [JsonPropertyName("exoticResistance")]
        public string ExoticResistance { get; set; }

        [JsonPropertyName("kineticResistance")]
        public string KineticResistance { get; set; }

        [JsonPropertyName("plasmaResistance")]
        public string PlasmaResistance { get; set; }

        [JsonPropertyName("ftlActiveJumpRange")]
        public int? FtlActiveJumpRange { get; set; }

        [JsonPropertyName("ftlBoostMultiply")]
        public bool? FtlBoostMultiply { get; set; }

        [JsonPropertyName("ftlBoostValue")]
        public string FtlBoostValue { get; set; }

        [JsonPropertyName("ftlJumpCoolDown")]
        public string FtlJumpCoolDown { get; set; }

        [JsonPropertyName("ftlJumpRange")]
        public double? FtlJumpRange { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("shieldHitMaterial")]
        public string ShieldHitMaterial { get; set; }

        [JsonPropertyName("shieldMaterial")]
        public string ShieldMaterial { get; set; }

        [JsonPropertyName("scanEnhancement")]
        public double? ScanEnhancement { get; set; }

        [JsonPropertyName("scanQuality")]
        public double? ScanQuality { get; set; }

        [JsonPropertyName("scanRange")]
        public int? ScanRange { get; set; }

        [JsonPropertyName("scanRes")]
        public double? ScanRes { get; set; }

        [JsonPropertyName("scanType")]
        public string ScanType { get; set; }

        [JsonPropertyName("scanAngle")]
        public int? ScanAngle { get; set; }

        [JsonPropertyName("disruptionExpireTime")]
        public string DisruptionExpireTime { get; set; }

        [JsonPropertyName("disruptionIntensity")]
        public string DisruptionIntensity { get; set; }

        [JsonPropertyName("disruptionPercentage")]
        public string DisruptionPercentage { get; set; }

        [JsonPropertyName("disruptionTime")]
        public string DisruptionTime { get; set; }

        [JsonPropertyName("targetDisruptionIntensity")]
        public string TargetDisruptionIntensity { get; set; }

        [JsonPropertyName("beamDuration")]
        public double? BeamDuration { get; set; }

        [JsonPropertyName("mineType")]
        public string MineType { get; set; }

        [JsonPropertyName("curveToTargetSpeed")]
        public string CurveToTargetSpeed { get; set; }

        [JsonPropertyName("curveToTargetTime")]
        public string CurveToTargetTime { get; set; }

        [JsonPropertyName("detachVelocityMax")]
        public string DetachVelocityMax { get; set; }

        [JsonPropertyName("detachVelocityMulti")]
        public string DetachVelocityMulti { get; set; }

        [JsonPropertyName("missileDelayTime")]
        public string MissileDelayTime { get; set; }

        [JsonPropertyName("beamPulseRate")]
        public double? BeamPulseRate { get; set; }

        [JsonPropertyName("useTrekSounds")]
        public bool? UseTrekSounds { get; set; }

        [JsonPropertyName("insurancePayoutGRP")]
        public string InsurancePayoutGRP { get; set; }

        [JsonPropertyName("refineCurve")]
        public string RefineCurve { get; set; }

        [JsonPropertyName("refineTime")]
        public int? RefineTime { get; set; }

        [JsonPropertyName("screenVibrationMax")]
        public string ScreenVibrationMax { get; set; }

        [JsonPropertyName("screenVibrationMin")]
        public string ScreenVibrationMin { get; set; }

        [JsonPropertyName("screenVibrationOptimal")]
        public string ScreenVibrationOptimal { get; set; }

        [JsonPropertyName("modulestoAffect")]
        public string ModulestoAffect { get; set; }

        [JsonPropertyName("rigStabilityMax")]
        public string RigStabilityMax { get; set; }

        [JsonPropertyName("rigStabilityMin")]
        public string RigStabilityMin { get; set; }

        [JsonPropertyName("rigStabilityOptimal")]
        public string RigStabilityOptimal { get; set; }

        [JsonPropertyName("skinRestriction")]
        public string SkinRestriction { get; set; }

        [JsonPropertyName("augmentInput")]
        public string AugmentInput { get; set; }

        [JsonPropertyName("separatorValueMax")]
        public int? SeparatorValueMax { get; set; }

        [JsonPropertyName("separatorValueMin")]
        public int? SeparatorValueMin { get; set; }

        [JsonPropertyName("separatorValueOptimal")]
        public int? SeparatorValueOptimal { get; set; }

        [JsonPropertyName("sluiceOperationMax")]
        public string SluiceOperationMax { get; set; }

        [JsonPropertyName("sluiceOperationMin")]
        public string SluiceOperationMin { get; set; }

        [JsonPropertyName("sluiceOperationOptimal")]
        public string SluiceOperationOptimal { get; set; }

        [JsonPropertyName("cargoSize")]
        public string CargoSize { get; set; }

        [JsonPropertyName("augmentTime")]
        public string AugmentTime { get; set; }

        [JsonPropertyName("augmentYield")]
        public string AugmentYield { get; set; }

        [JsonPropertyName("movementBoost")]
        public double? MovementBoost { get; set; }

        [JsonPropertyName("visibleToShip")]
        public bool? VisibleToShip { get; set; }

        [JsonPropertyName("visibleToSonar")]
        public bool? VisibleToSonar { get; set; }

        [JsonPropertyName("avgArmorRepRate")]
        public string AvgArmorRepRate { get; set; }

        [JsonPropertyName("avgHullRepRate")]
        public string AvgHullRepRate { get; set; }

        [JsonPropertyName("repairArmorAmount")]
        public string RepairArmorAmount { get; set; }

        [JsonPropertyName("repairHullAmount")]
        public string RepairHullAmount { get; set; }

        [JsonPropertyName("repairRate")]
        public string RepairRate { get; set; }

        [JsonPropertyName("transportCount")]
        public string TransportCount { get; set; }

        [JsonPropertyName("eesRadius")]
        public int? EesRadius { get; set; }

        [JsonPropertyName("excludePersonnelFTItemIDs")]
        public string ExcludePersonnelFTItemIDs { get; set; }

        [JsonPropertyName("scanPingRate")]
        public double? ScanPingRate { get; set; }

        [JsonPropertyName("scanTrackingLossTime")]
        public int? ScanTrackingLossTime { get; set; }

        [JsonPropertyName("scanPingDuration")]
        public int? ScanPingDuration { get; set; }
    }
    public class GameData : GameDataForDisplay
    {
        [JsonPropertyName("refinedResources")]
        public List<RefinedResource> RefinedResources { get; set; }

        [JsonPropertyName("craftingResources")]
        public List<CraftingResource> CraftingResources { get; set; }

        [JsonPropertyName("skinVisualID")]
        public string SkinVisualID { get; set; }

    }
}