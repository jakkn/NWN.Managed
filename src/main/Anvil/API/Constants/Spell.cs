using NWN.Core;

namespace Anvil.API
{
  public enum Spell
  {
    AllSpells = NWScript.SPELL_ALL_SPELLS,
    AcidFog = NWScript.SPELL_ACID_FOG,
    Aid = NWScript.SPELL_AID,
    AnimateDead = NWScript.SPELL_ANIMATE_DEAD,
    Barkskin = NWScript.SPELL_BARKSKIN,
    BestowCurse = NWScript.SPELL_BESTOW_CURSE,
    BladeBarrier = NWScript.SPELL_BLADE_BARRIER,
    Bless = NWScript.SPELL_BLESS,
    BlessWeapon = NWScript.SPELL_BLESS_WEAPON,
    BlindnessAndDeafness = NWScript.SPELL_BLINDNESS_AND_DEAFNESS,
    BullsStrength = NWScript.SPELL_BULLS_STRENGTH,
    BurningHands = NWScript.SPELL_BURNING_HANDS,
    CallLightning = NWScript.SPELL_CALL_LIGHTNING,
    CatsGrace = NWScript.SPELL_CATS_GRACE,
    ChainLightning = NWScript.SPELL_CHAIN_LIGHTNING,
    CharmMonster = NWScript.SPELL_CHARM_MONSTER,
    CharmPerson = NWScript.SPELL_CHARM_PERSON,
    CharmPersonOrAnimal = NWScript.SPELL_CHARM_PERSON_OR_ANIMAL,
    CircleOfDeath = NWScript.SPELL_CIRCLE_OF_DEATH,
    CircleOfDoom = NWScript.SPELL_CIRCLE_OF_DOOM,
    ClairaudienceAndClairvoyance = NWScript.SPELL_CLAIRAUDIENCE_AND_CLAIRVOYANCE,
    Clarity = NWScript.SPELL_CLARITY,
    CloakOfChaos = NWScript.SPELL_CLOAK_OF_CHAOS,
    Cloudkill = NWScript.SPELL_CLOUDKILL,
    ColorSpray = NWScript.SPELL_COLOR_SPRAY,
    ConeOfCold = NWScript.SPELL_CONE_OF_COLD,
    Confusion = NWScript.SPELL_CONFUSION,
    Contagion = NWScript.SPELL_CONTAGION,
    ControlUndead = NWScript.SPELL_CONTROL_UNDEAD,
    CreateGreaterUndead = NWScript.SPELL_CREATE_GREATER_UNDEAD,
    CreateUndead = NWScript.SPELL_CREATE_UNDEAD,
    CureCriticalWounds = NWScript.SPELL_CURE_CRITICAL_WOUNDS,
    CureLightWounds = NWScript.SPELL_CURE_LIGHT_WOUNDS,
    CureMinorWounds = NWScript.SPELL_CURE_MINOR_WOUNDS,
    CureModerateWounds = NWScript.SPELL_CURE_MODERATE_WOUNDS,
    CureSeriousWounds = NWScript.SPELL_CURE_SERIOUS_WOUNDS,
    Darkness = NWScript.SPELL_DARKNESS,
    Daze = NWScript.SPELL_DAZE,
    DeathWard = NWScript.SPELL_DEATH_WARD,
    DelayedBlastFireball = NWScript.SPELL_DELAYED_BLAST_FIREBALL,
    Dismissal = NWScript.SPELL_DISMISSAL,
    DispelMagic = NWScript.SPELL_DISPEL_MAGIC,
    DivinePower = NWScript.SPELL_DIVINE_POWER,
    DominateAnimal = NWScript.SPELL_DOMINATE_ANIMAL,
    DominateMonster = NWScript.SPELL_DOMINATE_MONSTER,
    DominatePerson = NWScript.SPELL_DOMINATE_PERSON,
    Doom = NWScript.SPELL_DOOM,
    ElementalShield = NWScript.SPELL_ELEMENTAL_SHIELD,
    ElementalSwarm = NWScript.SPELL_ELEMENTAL_SWARM,
    Endurance = NWScript.SPELL_ENDURANCE,
    EndureElements = NWScript.SPELL_ENDURE_ELEMENTS,
    EnergyDrain = NWScript.SPELL_ENERGY_DRAIN,
    Enervation = NWScript.SPELL_ENERVATION,
    Entangle = NWScript.SPELL_ENTANGLE,
    Fear = NWScript.SPELL_FEAR,
    Feeblemind = NWScript.SPELL_FEEBLEMIND,
    FingerOfDeath = NWScript.SPELL_FINGER_OF_DEATH,
    FireStorm = NWScript.SPELL_FIRE_STORM,
    Fireball = NWScript.SPELL_FIREBALL,
    FlameArrow = NWScript.SPELL_FLAME_ARROW,
    FlameLash = NWScript.SPELL_FLAME_LASH,
    FlameStrike = NWScript.SPELL_FLAME_STRIKE,
    FreedomOfMovement = NWScript.SPELL_FREEDOM_OF_MOVEMENT,
    Gate = NWScript.SPELL_GATE,
    GhoulTouch = NWScript.SPELL_GHOUL_TOUCH,
    GlobeOfInvulnerability = NWScript.SPELL_GLOBE_OF_INVULNERABILITY,
    Grease = NWScript.SPELL_GREASE,
    GreaterDispelling = NWScript.SPELL_GREATER_DISPELLING,
    GreaterPlanarBinding = NWScript.SPELL_GREATER_PLANAR_BINDING,
    GreaterRestoration = NWScript.SPELL_GREATER_RESTORATION,
    GreaterSpellBreach = NWScript.SPELL_GREATER_SPELL_BREACH,
    GreaterSpellMantle = NWScript.SPELL_GREATER_SPELL_MANTLE,
    GreaterStoneskin = NWScript.SPELL_GREATER_STONESKIN,
    GustOfWind = NWScript.SPELL_GUST_OF_WIND,
    HammerOfTheGods = NWScript.SPELL_HAMMER_OF_THE_GODS,
    Harm = NWScript.SPELL_HARM,
    Haste = NWScript.SPELL_HASTE,
    Heal = NWScript.SPELL_HEAL,
    HealingCircle = NWScript.SPELL_HEALING_CIRCLE,
    HoldAnimal = NWScript.SPELL_HOLD_ANIMAL,
    HoldMonster = NWScript.SPELL_HOLD_MONSTER,
    HoldPerson = NWScript.SPELL_HOLD_PERSON,
    HolyAura = NWScript.SPELL_HOLY_AURA,
    HolySword = NWScript.SPELL_HOLY_SWORD,
    Identify = NWScript.SPELL_IDENTIFY,
    Implosion = NWScript.SPELL_IMPLOSION,
    ImprovedInvisibility = NWScript.SPELL_IMPROVED_INVISIBILITY,
    IncendiaryCloud = NWScript.SPELL_INCENDIARY_CLOUD,
    Invisibility = NWScript.SPELL_INVISIBILITY,
    InvisibilityPurge = NWScript.SPELL_INVISIBILITY_PURGE,
    InvisibilitySphere = NWScript.SPELL_INVISIBILITY_SPHERE,
    Knock = NWScript.SPELL_KNOCK,
    LesserDispel = NWScript.SPELL_LESSER_DISPEL,
    LesserMindBlank = NWScript.SPELL_LESSER_MIND_BLANK,
    LesserPlanarBinding = NWScript.SPELL_LESSER_PLANAR_BINDING,
    LesserRestoration = NWScript.SPELL_LESSER_RESTORATION,
    LesserSpellBreach = NWScript.SPELL_LESSER_SPELL_BREACH,
    LesserSpellMantle = NWScript.SPELL_LESSER_SPELL_MANTLE,
    Light = NWScript.SPELL_LIGHT,
    LightningBolt = NWScript.SPELL_LIGHTNING_BOLT,
    MageArmor = NWScript.SPELL_MAGE_ARMOR,
    MagicCircleAgainstChaos = NWScript.SPELL_MAGIC_CIRCLE_AGAINST_CHAOS,
    MagicCircleAgainstEvil = NWScript.SPELL_MAGIC_CIRCLE_AGAINST_EVIL,
    MagicCircleAgainstGood = NWScript.SPELL_MAGIC_CIRCLE_AGAINST_GOOD,
    MagicCircleAgainstLaw = NWScript.SPELL_MAGIC_CIRCLE_AGAINST_LAW,
    MagicMissile = NWScript.SPELL_MAGIC_MISSILE,
    MagicVestment = NWScript.SPELL_MAGIC_VESTMENT,
    MassBlindnessAndDeafness = NWScript.SPELL_MASS_BLINDNESS_AND_DEAFNESS,
    MassCharm = NWScript.SPELL_MASS_CHARM,
    MassHaste = NWScript.SPELL_MASS_HASTE,
    MassHeal = NWScript.SPELL_MASS_HEAL,
    MelfsAcidArrow = NWScript.SPELL_MELFS_ACID_ARROW,
    MeteorSwarm = NWScript.SPELL_METEOR_SWARM,
    MindBlank = NWScript.SPELL_MIND_BLANK,
    MindFog = NWScript.SPELL_MIND_FOG,
    MinorGlobeOfInvulnerability = NWScript.SPELL_MINOR_GLOBE_OF_INVULNERABILITY,
    GhostlyVisage = NWScript.SPELL_GHOSTLY_VISAGE,
    EtherealVisage = NWScript.SPELL_ETHEREAL_VISAGE,
    MordenkainensDisjunction = NWScript.SPELL_MORDENKAINENS_DISJUNCTION,
    MordenkainensSword = NWScript.SPELL_MORDENKAINENS_SWORD,
    NaturesBalance = NWScript.SPELL_NATURES_BALANCE,
    NegativeEnergyProtection = NWScript.SPELL_NEGATIVE_ENERGY_PROTECTION,
    NeutralizePoison = NWScript.SPELL_NEUTRALIZE_POISON,
    PhantasmalKiller = NWScript.SPELL_PHANTASMAL_KILLER,
    PlanarBinding = NWScript.SPELL_PLANAR_BINDING,
    Poison = NWScript.SPELL_POISON,
    PolymorphSelf = NWScript.SPELL_POLYMORPH_SELF,
    PowerWordKill = NWScript.SPELL_POWER_WORD_KILL,
    PowerWordStun = NWScript.SPELL_POWER_WORD_STUN,
    Prayer = NWScript.SPELL_PRAYER,
    Premonition = NWScript.SPELL_PREMONITION,
    PrismaticSpray = NWScript.SPELL_PRISMATIC_SPRAY,
    ProtectionFromChaos = NWScript.SPELL_PROTECTION__FROM_CHAOS,
    ProtectionFromElements = NWScript.SPELL_PROTECTION_FROM_ELEMENTS,
    ProtectionFromEvil = NWScript.SPELL_PROTECTION_FROM_EVIL,
    ProtectionFromGood = NWScript.SPELL_PROTECTION_FROM_GOOD,
    ProtectionFromLaw = NWScript.SPELL_PROTECTION_FROM_LAW,
    ProtectionFromSpells = NWScript.SPELL_PROTECTION_FROM_SPELLS,
    RaiseDead = NWScript.SPELL_RAISE_DEAD,
    RayOfEnfeeblement = NWScript.SPELL_RAY_OF_ENFEEBLEMENT,
    RayOfFrost = NWScript.SPELL_RAY_OF_FROST,
    RemoveBlindnessAndDeafness = NWScript.SPELL_REMOVE_BLINDNESS_AND_DEAFNESS,
    RemoveCurse = NWScript.SPELL_REMOVE_CURSE,
    RemoveDisease = NWScript.SPELL_REMOVE_DISEASE,
    RemoveFear = NWScript.SPELL_REMOVE_FEAR,
    RemoveParalysis = NWScript.SPELL_REMOVE_PARALYSIS,
    ResistElements = NWScript.SPELL_RESIST_ELEMENTS,
    Resistance = NWScript.SPELL_RESISTANCE,
    Restoration = NWScript.SPELL_RESTORATION,
    Resurrection = NWScript.SPELL_RESURRECTION,
    Sanctuary = NWScript.SPELL_SANCTUARY,
    Scare = NWScript.SPELL_SCARE,
    SearingLight = NWScript.SPELL_SEARING_LIGHT,
    SeeInvisibility = NWScript.SPELL_SEE_INVISIBILITY,
    ShadowShield = NWScript.SPELL_SHADOW_SHIELD,
    Shapechange = NWScript.SPELL_SHAPECHANGE,
    ShieldOfLaw = NWScript.SPELL_SHIELD_OF_LAW,
    Silence = NWScript.SPELL_SILENCE,
    SlayLiving = NWScript.SPELL_SLAY_LIVING,
    Sleep = NWScript.SPELL_SLEEP,
    Slow = NWScript.SPELL_SLOW,
    SoundBurst = NWScript.SPELL_SOUND_BURST,
    SpellResistance = NWScript.SPELL_SPELL_RESISTANCE,
    SpellMantle = NWScript.SPELL_SPELL_MANTLE,
    SphereOfChaos = NWScript.SPELL_SPHERE_OF_CHAOS,
    StinkingCloud = NWScript.SPELL_STINKING_CLOUD,
    Stoneskin = NWScript.SPELL_STONESKIN,
    StormOfVengeance = NWScript.SPELL_STORM_OF_VENGEANCE,
    SummonCreatureI = NWScript.SPELL_SUMMON_CREATURE_I,
    SummonCreatureIi = NWScript.SPELL_SUMMON_CREATURE_II,
    SummonCreatureIii = NWScript.SPELL_SUMMON_CREATURE_III,
    SummonCreatureIv = NWScript.SPELL_SUMMON_CREATURE_IV,
    SummonCreatureIx = NWScript.SPELL_SUMMON_CREATURE_IX,
    SummonCreatureV = NWScript.SPELL_SUMMON_CREATURE_V,
    SummonCreatureVi = NWScript.SPELL_SUMMON_CREATURE_VI,
    SummonCreatureVii = NWScript.SPELL_SUMMON_CREATURE_VII,
    SummonCreatureViii = NWScript.SPELL_SUMMON_CREATURE_VIII,
    Sunbeam = NWScript.SPELL_SUNBEAM,
    TensersTransformation = NWScript.SPELL_TENSERS_TRANSFORMATION,
    TimeStop = NWScript.SPELL_TIME_STOP,
    TrueSeeing = NWScript.SPELL_TRUE_SEEING,
    UnholyAura = NWScript.SPELL_UNHOLY_AURA,
    VampiricTouch = NWScript.SPELL_VAMPIRIC_TOUCH,
    Virtue = NWScript.SPELL_VIRTUE,
    WailOfTheBanshee = NWScript.SPELL_WAIL_OF_THE_BANSHEE,
    WallOfFire = NWScript.SPELL_WALL_OF_FIRE,
    Web = NWScript.SPELL_WEB,
    Weird = NWScript.SPELL_WEIRD,
    WordOfFaith = NWScript.SPELL_WORD_OF_FAITH,
    AbilityAuraBlinding = NWScript.SPELLABILITY_AURA_BLINDING,
    AbilityAuraCold = NWScript.SPELLABILITY_AURA_COLD,
    AbilityAuraElectricity = NWScript.SPELLABILITY_AURA_ELECTRICITY,
    AbilityAuraFear = NWScript.SPELLABILITY_AURA_FEAR,
    AbilityAuraFire = NWScript.SPELLABILITY_AURA_FIRE,
    AbilityAuraMenace = NWScript.SPELLABILITY_AURA_MENACE,
    AbilityAuraProtection = NWScript.SPELLABILITY_AURA_PROTECTION,
    AbilityAuraStun = NWScript.SPELLABILITY_AURA_STUN,
    AbilityAuraUnearthlyVisage = NWScript.SPELLABILITY_AURA_UNEARTHLY_VISAGE,
    AbilityAuraUnnatural = NWScript.SPELLABILITY_AURA_UNNATURAL,
    AbilityBoltAbilityDrainCharisma = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_CHARISMA,
    AbilityBoltAbilityDrainConstitution = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_CONSTITUTION,
    AbilityBoltAbilityDrainDexterity = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_DEXTERITY,
    AbilityBoltAbilityDrainIntelligence = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_INTELLIGENCE,
    AbilityBoltAbilityDrainStrength = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_STRENGTH,
    AbilityBoltAbilityDrainWisdom = NWScript.SPELLABILITY_BOLT_ABILITY_DRAIN_WISDOM,
    AbilityBoltAcid = NWScript.SPELLABILITY_BOLT_ACID,
    AbilityBoltCharm = NWScript.SPELLABILITY_BOLT_CHARM,
    AbilityBoltCold = NWScript.SPELLABILITY_BOLT_COLD,
    AbilityBoltConfuse = NWScript.SPELLABILITY_BOLT_CONFUSE,
    AbilityBoltDaze = NWScript.SPELLABILITY_BOLT_DAZE,
    AbilityBoltDeath = NWScript.SPELLABILITY_BOLT_DEATH,
    AbilityBoltDisease = NWScript.SPELLABILITY_BOLT_DISEASE,
    AbilityBoltDominate = NWScript.SPELLABILITY_BOLT_DOMINATE,
    AbilityBoltFire = NWScript.SPELLABILITY_BOLT_FIRE,
    AbilityBoltKnockdown = NWScript.SPELLABILITY_BOLT_KNOCKDOWN,
    AbilityBoltLevelDrain = NWScript.SPELLABILITY_BOLT_LEVEL_DRAIN,
    AbilityBoltLightning = NWScript.SPELLABILITY_BOLT_LIGHTNING,
    AbilityBoltParalyze = NWScript.SPELLABILITY_BOLT_PARALYZE,
    AbilityBoltPoison = NWScript.SPELLABILITY_BOLT_POISON,
    AbilityBoltShards = NWScript.SPELLABILITY_BOLT_SHARDS,
    AbilityBoltSlow = NWScript.SPELLABILITY_BOLT_SLOW,
    AbilityBoltStun = NWScript.SPELLABILITY_BOLT_STUN,
    AbilityBoltWeb = NWScript.SPELLABILITY_BOLT_WEB,
    AbilityConeAcid = NWScript.SPELLABILITY_CONE_ACID,
    AbilityConeCold = NWScript.SPELLABILITY_CONE_COLD,
    AbilityConeDisease = NWScript.SPELLABILITY_CONE_DISEASE,
    AbilityConeFire = NWScript.SPELLABILITY_CONE_FIRE,
    AbilityConeLightning = NWScript.SPELLABILITY_CONE_LIGHTNING,
    AbilityConePoison = NWScript.SPELLABILITY_CONE_POISON,
    AbilityConeSonic = NWScript.SPELLABILITY_CONE_SONIC,
    AbilityDragonBreathAcid = NWScript.SPELLABILITY_DRAGON_BREATH_ACID,
    AbilityDragonBreathCold = NWScript.SPELLABILITY_DRAGON_BREATH_COLD,
    AbilityDragonBreathFear = NWScript.SPELLABILITY_DRAGON_BREATH_FEAR,
    AbilityDragonBreathFire = NWScript.SPELLABILITY_DRAGON_BREATH_FIRE,
    AbilityDragonBreathGas = NWScript.SPELLABILITY_DRAGON_BREATH_GAS,
    AbilityDragonBreathLightning = NWScript.SPELLABILITY_DRAGON_BREATH_LIGHTNING,
    AbilityDragonBreathParalyze = NWScript.SPELLABILITY_DRAGON_BREATH_PARALYZE,
    AbilityDragonBreathSleep = NWScript.SPELLABILITY_DRAGON_BREATH_SLEEP,
    AbilityDragonBreathSlow = NWScript.SPELLABILITY_DRAGON_BREATH_SLOW,
    AbilityDragonBreathWeaken = NWScript.SPELLABILITY_DRAGON_BREATH_WEAKEN,
    AbilityDragonWingBuffet = NWScript.SPELLABILITY_DRAGON_WING_BUFFET,
    AbilityFerocity1 = NWScript.SPELLABILITY_FEROCITY_1,
    AbilityFerocity2 = NWScript.SPELLABILITY_FEROCITY_2,
    AbilityFerocity3 = NWScript.SPELLABILITY_FEROCITY_3,
    AbilityGazeCharm = NWScript.SPELLABILITY_GAZE_CHARM,
    AbilityGazeConfusion = NWScript.SPELLABILITY_GAZE_CONFUSION,
    AbilityGazeDaze = NWScript.SPELLABILITY_GAZE_DAZE,
    AbilityGazeDeath = NWScript.SPELLABILITY_GAZE_DEATH,
    AbilityGazeDestroyChaos = NWScript.SPELLABILITY_GAZE_DESTROY_CHAOS,
    AbilityGazeDestroyEvil = NWScript.SPELLABILITY_GAZE_DESTROY_EVIL,
    AbilityGazeDestroyGood = NWScript.SPELLABILITY_GAZE_DESTROY_GOOD,
    AbilityGazeDestroyLaw = NWScript.SPELLABILITY_GAZE_DESTROY_LAW,
    AbilityGazeDominate = NWScript.SPELLABILITY_GAZE_DOMINATE,
    AbilityGazeDoom = NWScript.SPELLABILITY_GAZE_DOOM,
    AbilityGazeFear = NWScript.SPELLABILITY_GAZE_FEAR,
    AbilityGazeParalysis = NWScript.SPELLABILITY_GAZE_PARALYSIS,
    AbilityGazeStunned = NWScript.SPELLABILITY_GAZE_STUNNED,
    AbilityGolemBreathGas = NWScript.SPELLABILITY_GOLEM_BREATH_GAS,
    AbilityHellHoundFirebreath = NWScript.SPELLABILITY_HELL_HOUND_FIREBREATH,
    AbilityHowlConfuse = NWScript.SPELLABILITY_HOWL_CONFUSE,
    AbilityHowlDaze = NWScript.SPELLABILITY_HOWL_DAZE,
    AbilityHowlDeath = NWScript.SPELLABILITY_HOWL_DEATH,
    AbilityHowlDoom = NWScript.SPELLABILITY_HOWL_DOOM,
    AbilityHowlFear = NWScript.SPELLABILITY_HOWL_FEAR,
    AbilityHowlParalysis = NWScript.SPELLABILITY_HOWL_PARALYSIS,
    AbilityHowlSonic = NWScript.SPELLABILITY_HOWL_SONIC,
    AbilityHowlStun = NWScript.SPELLABILITY_HOWL_STUN,
    AbilityIntensity1 = NWScript.SPELLABILITY_INTENSITY_1,
    AbilityIntensity2 = NWScript.SPELLABILITY_INTENSITY_2,
    AbilityIntensity3 = NWScript.SPELLABILITY_INTENSITY_3,
    AbilityKrensharScare = NWScript.SPELLABILITY_KRENSHAR_SCARE,
    AbilityLesserBodyAdjustment = NWScript.SPELLABILITY_LESSER_BODY_ADJUSTMENT,
    AbilityMephitSaltBreath = NWScript.SPELLABILITY_MEPHIT_SALT_BREATH,
    AbilityMephitSteamBreath = NWScript.SPELLABILITY_MEPHIT_STEAM_BREATH,
    AbilityMummyBolsterUndead = NWScript.SPELLABILITY_MUMMY_BOLSTER_UNDEAD,
    AbilityPulseDrown = NWScript.SPELLABILITY_PULSE_DROWN,
    AbilityPulseSpores = NWScript.SPELLABILITY_PULSE_SPORES,
    AbilityPulseWhirlwind = NWScript.SPELLABILITY_PULSE_WHIRLWIND,
    AbilityPulseFire = NWScript.SPELLABILITY_PULSE_FIRE,
    AbilityPulseLightning = NWScript.SPELLABILITY_PULSE_LIGHTNING,
    AbilityPulseCold = NWScript.SPELLABILITY_PULSE_COLD,
    AbilityPulseNegative = NWScript.SPELLABILITY_PULSE_NEGATIVE,
    AbilityPulseHoly = NWScript.SPELLABILITY_PULSE_HOLY,
    AbilityPulseDeath = NWScript.SPELLABILITY_PULSE_DEATH,
    AbilityPulseLevelDrain = NWScript.SPELLABILITY_PULSE_LEVEL_DRAIN,
    AbilityPulseAbilityDrainIntelligence = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_INTELLIGENCE,
    AbilityPulseAbilityDrainCharisma = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_CHARISMA,
    AbilityPulseAbilityDrainConstitution = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_CONSTITUTION,
    AbilityPulseAbilityDrainDexterity = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_DEXTERITY,
    AbilityPulseAbilityDrainStrength = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_STRENGTH,
    AbilityPulseAbilityDrainWisdom = NWScript.SPELLABILITY_PULSE_ABILITY_DRAIN_WISDOM,
    AbilityPulsePoison = NWScript.SPELLABILITY_PULSE_POISON,
    AbilityPulseDisease = NWScript.SPELLABILITY_PULSE_DISEASE,
    AbilityRage3 = NWScript.SPELLABILITY_RAGE_3,
    AbilityRage4 = NWScript.SPELLABILITY_RAGE_4,
    AbilityRage5 = NWScript.SPELLABILITY_RAGE_5,
    AbilitySmokeClaw = NWScript.SPELLABILITY_SMOKE_CLAW,
    AbilitySummonSlaad = NWScript.SPELLABILITY_SUMMON_SLAAD,
    AbilitySummonTanarri = NWScript.SPELLABILITY_SUMMON_TANARRI,
    AbilityTrumpetBlast = NWScript.SPELLABILITY_TRUMPET_BLAST,
    AbilityTyrantFogMist = NWScript.SPELLABILITY_TYRANT_FOG_MIST,
    AbilityBarbarianRage = NWScript.SPELLABILITY_BARBARIAN_RAGE,
    AbilityTurnUndead = NWScript.SPELLABILITY_TURN_UNDEAD,
    AbilityWholenessOfBody = NWScript.SPELLABILITY_WHOLENESS_OF_BODY,
    AbilityQuiveringPalm = NWScript.SPELLABILITY_QUIVERING_PALM,
    AbilityEmptyBody = NWScript.SPELLABILITY_EMPTY_BODY,
    AbilityDetectEvil = NWScript.SPELLABILITY_DETECT_EVIL,
    AbilityLayOnHands = NWScript.SPELLABILITY_LAY_ON_HANDS,
    AbilityAuraOfCourage = NWScript.SPELLABILITY_AURA_OF_COURAGE,
    AbilitySmiteEvil = NWScript.SPELLABILITY_SMITE_EVIL,
    AbilityRemoveDisease = NWScript.SPELLABILITY_REMOVE_DISEASE,
    AbilitySummonAnimalCompanion = NWScript.SPELLABILITY_SUMMON_ANIMAL_COMPANION,
    AbilitySummonFamiliar = NWScript.SPELLABILITY_SUMMON_FAMILIAR,
    AbilityElementalShape = NWScript.SPELLABILITY_ELEMENTAL_SHAPE,
    AbilityWildShape = NWScript.SPELLABILITY_WILD_SHAPE,
    ShadesSummonShadow = NWScript.SPELL_SHADES_SUMMON_SHADOW,
    ShadesConeOfCold = NWScript.SPELL_SHADES_CONE_OF_COLD,
    ShadesFireball = NWScript.SPELL_SHADES_FIREBALL,
    ShadesStoneskin = NWScript.SPELL_SHADES_STONESKIN,
    ShadesWallOfFire = NWScript.SPELL_SHADES_WALL_OF_FIRE,
    ShadowConjurationSummonShadow = NWScript.SPELL_SHADOW_CONJURATION_SUMMON_SHADOW,
    ShadowConjurationDarkness = NWScript.SPELL_SHADOW_CONJURATION_DARKNESS,
    ShadowConjurationInivsibility = NWScript.SPELL_SHADOW_CONJURATION_INIVSIBILITY,
    ShadowConjurationMageArmor = NWScript.SPELL_SHADOW_CONJURATION_MAGE_ARMOR,
    ShadowConjurationMagicMissile = NWScript.SPELL_SHADOW_CONJURATION_MAGIC_MISSILE,
    GreaterShadowConjurationSummonShadow = NWScript.SPELL_GREATER_SHADOW_CONJURATION_SUMMON_SHADOW,
    GreaterShadowConjurationAcidArrow = NWScript.SPELL_GREATER_SHADOW_CONJURATION_ACID_ARROW,
    GreaterShadowConjurationMirrorImage = NWScript.SPELL_GREATER_SHADOW_CONJURATION_MIRROR_IMAGE,
    GreaterShadowConjurationWeb = NWScript.SPELL_GREATER_SHADOW_CONJURATION_WEB,
    GreaterShadowConjurationMinorGlobe = NWScript.SPELL_GREATER_SHADOW_CONJURATION_MINOR_GLOBE,
    EagleSpledor = NWScript.SPELL_EAGLE_SPLEDOR,
    OwlsWisdom = NWScript.SPELL_OWLS_WISDOM,
    FoxsCunning = NWScript.SPELL_FOXS_CUNNING,
    GreaterEagleSplendor = NWScript.SPELL_GREATER_EAGLE_SPLENDOR,
    GreaterOwlsWisdom = NWScript.SPELL_GREATER_OWLS_WISDOM,
    GreaterFoxsCunning = NWScript.SPELL_GREATER_FOXS_CUNNING,
    GreaterBullsStrength = NWScript.SPELL_GREATER_BULLS_STRENGTH,
    GreaterCatsGrace = NWScript.SPELL_GREATER_CATS_GRACE,
    GreaterEndurance = NWScript.SPELL_GREATER_ENDURANCE,
    Awaken = NWScript.SPELL_AWAKEN,
    CreepingDoom = NWScript.SPELL_CREEPING_DOOM,
    Darkvision = NWScript.SPELL_DARKVISION,
    Destruction = NWScript.SPELL_DESTRUCTION,
    HorridWilting = NWScript.SPELL_HORRID_WILTING,
    IceStorm = NWScript.SPELL_ICE_STORM,
    EnergyBuffer = NWScript.SPELL_ENERGY_BUFFER,
    NegativeEnergyBurst = NWScript.SPELL_NEGATIVE_ENERGY_BURST,
    NegativeEnergyRay = NWScript.SPELL_NEGATIVE_ENERGY_RAY,
    AuraOfVitality = NWScript.SPELL_AURA_OF_VITALITY,
    WarCry = NWScript.SPELL_WAR_CRY,
    Regenerate = NWScript.SPELL_REGENERATE,
    EvardsBlackTentacles = NWScript.SPELL_EVARDS_BLACK_TENTACLES,
    LegendLore = NWScript.SPELL_LEGEND_LORE,
    FindTraps = NWScript.SPELL_FIND_TRAPS,
    AbilitySummonMephit = NWScript.SPELLABILITY_SUMMON_MEPHIT,
    AbilitySummonCelestial = NWScript.SPELLABILITY_SUMMON_CELESTIAL,
    AbilityBattleMastery = NWScript.SPELLABILITY_BATTLE_MASTERY,
    AbilityDivineStrength = NWScript.SPELLABILITY_DIVINE_STRENGTH,
    AbilityDivineProtection = NWScript.SPELLABILITY_DIVINE_PROTECTION,
    AbilityNegativePlaneAvatar = NWScript.SPELLABILITY_NEGATIVE_PLANE_AVATAR,
    AbilityDivineTrickery = NWScript.SPELLABILITY_DIVINE_TRICKERY,
    AbilityRoguesCunning = NWScript.SPELLABILITY_ROGUES_CUNNING,
    AbilityActivateItem = NWScript.SPELLABILITY_ACTIVATE_ITEM,
    AbilityDragonFear = NWScript.SPELLABILITY_DRAGON_FEAR,
    DivineFavor = NWScript.SPELL_DIVINE_FAVOR,
    TrueStrike = NWScript.SPELL_TRUE_STRIKE,
    Flare = NWScript.SPELL_FLARE,
    Shield = NWScript.SPELL_SHIELD,
    EntropicShield = NWScript.SPELL_ENTROPIC_SHIELD,
    ContinualFlame = NWScript.SPELL_CONTINUAL_FLAME,
    OneWithTheLand = NWScript.SPELL_ONE_WITH_THE_LAND,
    Camoflage = NWScript.SPELL_CAMOFLAGE,
    BloodFrenzy = NWScript.SPELL_BLOOD_FRENZY,
    Bombardment = NWScript.SPELL_BOMBARDMENT,
    AcidSplash = NWScript.SPELL_ACID_SPLASH,
    Quillfire = NWScript.SPELL_QUILLFIRE,
    Earthquake = NWScript.SPELL_EARTHQUAKE,
    Sunburst = NWScript.SPELL_SUNBURST,
    ActivateItemSelf2 = NWScript.SPELL_ACTIVATE_ITEM_SELF2,
    Auraofglory = NWScript.SPELL_AURAOFGLORY,
    Banishment = NWScript.SPELL_BANISHMENT,
    InflictMinorWounds = NWScript.SPELL_INFLICT_MINOR_WOUNDS,
    InflictLightWounds = NWScript.SPELL_INFLICT_LIGHT_WOUNDS,
    InflictModerateWounds = NWScript.SPELL_INFLICT_MODERATE_WOUNDS,
    InflictSeriousWounds = NWScript.SPELL_INFLICT_SERIOUS_WOUNDS,
    InflictCriticalWounds = NWScript.SPELL_INFLICT_CRITICAL_WOUNDS,
    Balagarnsironhorn = NWScript.SPELL_BALAGARNSIRONHORN,
    Drown = NWScript.SPELL_DROWN,
    OwlsInsight = NWScript.SPELL_OWLS_INSIGHT,
    ElectricJolt = NWScript.SPELL_ELECTRIC_JOLT,
    Firebrand = NWScript.SPELL_FIREBRAND,
    WoundingWhispers = NWScript.SPELL_WOUNDING_WHISPERS,
    Amplify = NWScript.SPELL_AMPLIFY,
    Etherealness = NWScript.SPELL_ETHEREALNESS,
    UndeathsEternalFoe = NWScript.SPELL_UNDEATHS_ETERNAL_FOE,
    Dirge = NWScript.SPELL_DIRGE,
    Inferno = NWScript.SPELL_INFERNO,
    IsaacsLesserMissileStorm = NWScript.SPELL_ISAACS_LESSER_MISSILE_STORM,
    IsaacsGreaterMissileStorm = NWScript.SPELL_ISAACS_GREATER_MISSILE_STORM,
    Bane = NWScript.SPELL_BANE,
    ShieldOfFaith = NWScript.SPELL_SHIELD_OF_FAITH,
    PlanarAlly = NWScript.SPELL_PLANAR_ALLY,
    MagicFang = NWScript.SPELL_MAGIC_FANG,
    GreaterMagicFang = NWScript.SPELL_GREATER_MAGIC_FANG,
    SpikeGrowth = NWScript.SPELL_SPIKE_GROWTH,
    MassCamoflage = NWScript.SPELL_MASS_CAMOFLAGE,
    ExpeditiousRetreat = NWScript.SPELL_EXPEDITIOUS_RETREAT,
    TashasHideousLaughter = NWScript.SPELL_TASHAS_HIDEOUS_LAUGHTER,
    Displacement = NWScript.SPELL_DISPLACEMENT,
    BigbysInterposingHand = NWScript.SPELL_BIGBYS_INTERPOSING_HAND,
    BigbysForcefulHand = NWScript.SPELL_BIGBYS_FORCEFUL_HAND,
    BigbysGraspingHand = NWScript.SPELL_BIGBYS_GRASPING_HAND,
    BigbysClenchedFist = NWScript.SPELL_BIGBYS_CLENCHED_FIST,
    BigbysCrushingHand = NWScript.SPELL_BIGBYS_CRUSHING_HAND,
    GrenadeFire = NWScript.SPELL_GRENADE_FIRE,
    GrenadeTangle = NWScript.SPELL_GRENADE_TANGLE,
    GrenadeHoly = NWScript.SPELL_GRENADE_HOLY,
    GrenadeChoking = NWScript.SPELL_GRENADE_CHOKING,
    GrenadeThunderstone = NWScript.SPELL_GRENADE_THUNDERSTONE,
    GrenadeAcid = NWScript.SPELL_GRENADE_ACID,
    GrenadeChicken = NWScript.SPELL_GRENADE_CHICKEN,
    GrenadeCaltrops = NWScript.SPELL_GRENADE_CALTROPS,
    ActivateItemPortal = NWScript.SPELL_ACTIVATE_ITEM_PORTAL,
    DivineMight = NWScript.SPELL_DIVINE_MIGHT,
    DivineShield = NWScript.SPELL_DIVINE_SHIELD,
    ShadowDaze = NWScript.SPELL_SHADOW_DAZE,
    SummonShadow = NWScript.SPELL_SUMMON_SHADOW,
    ShadowEvade = NWScript.SPELL_SHADOW_EVADE,
    TymorasSmile = NWScript.SPELL_TYMORAS_SMILE,
    CraftHarperItem = NWScript.SPELL_CRAFT_HARPER_ITEM,
    FleshToStone = NWScript.SPELL_FLESH_TO_STONE,
    StoneToFlesh = NWScript.SPELL_STONE_TO_FLESH,
    TrapArrow = NWScript.SPELL_TRAP_ARROW,
    TrapBolt = NWScript.SPELL_TRAP_BOLT,
    TrapDart = NWScript.SPELL_TRAP_DART,
    TrapShuriken = NWScript.SPELL_TRAP_SHURIKEN,
    AbilityBreathPetrify = NWScript.SPELLABILITY_BREATH_PETRIFY,
    AbilityTouchPetrify = NWScript.SPELLABILITY_TOUCH_PETRIFY,
    AbilityGazePetrify = NWScript.SPELLABILITY_GAZE_PETRIFY,
    AbilityManticoreSpikes = NWScript.SPELLABILITY_MANTICORE_SPIKES,
    RodOfWonder = NWScript.SPELL_ROD_OF_WONDER,
    DeckOfManyThings = NWScript.SPELL_DECK_OF_MANY_THINGS,
    ElementalSummoningItem = NWScript.SPELL_ELEMENTAL_SUMMONING_ITEM,
    DeckAvatar = NWScript.SPELL_DECK_AVATAR,
    DeckGemspray = NWScript.SPELL_DECK_GEMSPRAY,
    DeckButterflyspray = NWScript.SPELL_DECK_BUTTERFLYSPRAY,
    Healingkit = NWScript.SPELL_HEALINGKIT,
    Powerstone = NWScript.SPELL_POWERSTONE,
    Spellstaff = NWScript.SPELL_SPELLSTAFF,
    Charger = NWScript.SPELL_CHARGER,
    Decharger = NWScript.SPELL_DECHARGER,
    KoboldJump = NWScript.SPELL_KOBOLD_JUMP,
    Crumble = NWScript.SPELL_CRUMBLE,
    InfestationOfMaggots = NWScript.SPELL_INFESTATION_OF_MAGGOTS,
    HealingSting = NWScript.SPELL_HEALING_STING,
    GreatThunderclap = NWScript.SPELL_GREAT_THUNDERCLAP,
    BallLightning = NWScript.SPELL_BALL_LIGHTNING,
    Battletide = NWScript.SPELL_BATTLETIDE,
    Combust = NWScript.SPELL_COMBUST,
    DeathArmor = NWScript.SPELL_DEATH_ARMOR,
    GedleesElectricLoop = NWScript.SPELL_GEDLEES_ELECTRIC_LOOP,
    HorizikaulsBoom = NWScript.SPELL_HORIZIKAULS_BOOM,
    Ironguts = NWScript.SPELL_IRONGUTS,
    MestilsAcidBreath = NWScript.SPELL_MESTILS_ACID_BREATH,
    MestilsAcidSheath = NWScript.SPELL_MESTILS_ACID_SHEATH,
    MonstrousRegeneration = NWScript.SPELL_MONSTROUS_REGENERATION,
    ScintillatingSphere = NWScript.SPELL_SCINTILLATING_SPHERE,
    StoneBones = NWScript.SPELL_STONE_BONES,
    UndeathToDeath = NWScript.SPELL_UNDEATH_TO_DEATH,
    VineMine = NWScript.SPELL_VINE_MINE,
    VineMineEntangle = NWScript.SPELL_VINE_MINE_ENTANGLE,
    VineMineHamperMovement = NWScript.SPELL_VINE_MINE_HAMPER_MOVEMENT,
    VineMineCamouflage = NWScript.SPELL_VINE_MINE_CAMOUFLAGE,
    BlackBladeOfDisaster = NWScript.SPELL_BLACK_BLADE_OF_DISASTER,
    ShelgarnsPersistentBlade = NWScript.SPELL_SHELGARNS_PERSISTENT_BLADE,
    BladeThirst = NWScript.SPELL_BLADE_THIRST,
    DeafeningClang = NWScript.SPELL_DEAFENING_CLANG,
    CloudOfBewilderment = NWScript.SPELL_CLOUD_OF_BEWILDERMENT,
    KeenEdge = NWScript.SPELL_KEEN_EDGE,
    Blackstaff = NWScript.SPELL_BLACKSTAFF,
    FlameWeapon = NWScript.SPELL_FLAME_WEAPON,
    IceDagger = NWScript.SPELL_ICE_DAGGER,
    MagicWeapon = NWScript.SPELL_MAGIC_WEAPON,
    GreaterMagicWeapon = NWScript.SPELL_GREATER_MAGIC_WEAPON,
    Stonehold = NWScript.SPELL_STONEHOLD,
    Darkfire = NWScript.SPELL_DARKFIRE,
    GlyphOfWarding = NWScript.SPELL_GLYPH_OF_WARDING,
    AbilityMindblast = NWScript.SPELLABILITY_MINDBLAST,
    AbilityCharmmonster = NWScript.SPELLABILITY_CHARMMONSTER,
    IounStoneDustyRose = NWScript.SPELL_IOUN_STONE_DUSTY_ROSE,
    IounStonePaleBlue = NWScript.SPELL_IOUN_STONE_PALE_BLUE,
    IounStoneScarletBlue = NWScript.SPELL_IOUN_STONE_SCARLET_BLUE,
    IounStoneBlue = NWScript.SPELL_IOUN_STONE_BLUE,
    IounStoneDeepRed = NWScript.SPELL_IOUN_STONE_DEEP_RED,
    IounStonePink = NWScript.SPELL_IOUN_STONE_PINK,
    IounStonePinkGreen = NWScript.SPELL_IOUN_STONE_PINK_GREEN,
    AbilityWhirlwind = NWScript.SPELLABILITY_WHIRLWIND,
    AbilityCommandTheHorde = NWScript.SPELLABILITY_COMMAND_THE_HORDE,
    AbilityAaImbueArrow = NWScript.SPELLABILITY_AA_IMBUE_ARROW,
    AbilityAaSeekerArrow1 = NWScript.SPELLABILITY_AA_SEEKER_ARROW_1,
    AbilityAaSeekerArrow2 = NWScript.SPELLABILITY_AA_SEEKER_ARROW_2,
    AbilityAaHailOfArrows = NWScript.SPELLABILITY_AA_HAIL_OF_ARROWS,
    AbilityAaArrowOfDeath = NWScript.SPELLABILITY_AA_ARROW_OF_DEATH,
    AbilityAsGhostlyVisage = NWScript.SPELLABILITY_AS_GHOSTLY_VISAGE,
    AbilityAsDarkness = NWScript.SPELLABILITY_AS_DARKNESS,
    AbilityAsInvisibility = NWScript.SPELLABILITY_AS_INVISIBILITY,
    AbilityAsImprovedInvisiblity = NWScript.SPELLABILITY_AS_IMPROVED_INVISIBLITY,
    AbilityBgCreatedead = NWScript.SPELLABILITY_BG_CREATEDEAD,
    AbilityBgFiendishServant = NWScript.SPELLABILITY_BG_FIENDISH_SERVANT,
    AbilityBgInflictSeriousWounds = NWScript.SPELLABILITY_BG_INFLICT_SERIOUS_WOUNDS,
    AbilityBgInflictCriticalWounds = NWScript.SPELLABILITY_BG_INFLICT_CRITICAL_WOUNDS,
    AbilityBgContagion = NWScript.SPELLABILITY_BG_CONTAGION,
    AbilityBgBullsStrength = NWScript.SPELLABILITY_BG_BULLS_STRENGTH,
    FlyingDebris = NWScript.SPELL_FLYING_DEBRIS,
    AbilityDcDivineWrath = NWScript.SPELLABILITY_DC_DIVINE_WRATH,
    AbilityPmAnimateDead = NWScript.SPELLABILITY_PM_ANIMATE_DEAD,
    AbilityPmSummonUndead = NWScript.SPELLABILITY_PM_SUMMON_UNDEAD,
    AbilityPmUndeadGraft1 = NWScript.SPELLABILITY_PM_UNDEAD_GRAFT_1,
    AbilityPmUndeadGraft2 = NWScript.SPELLABILITY_PM_UNDEAD_GRAFT_2,
    AbilityPmSummonGreaterUndead = NWScript.SPELLABILITY_PM_SUMMON_GREATER_UNDEAD,
    AbilityPmDeathlessMasterTouch = NWScript.SPELLABILITY_PM_DEATHLESS_MASTER_TOUCH,
    EpicHellball = NWScript.SPELL_EPIC_HELLBALL,
    EpicMummyDust = NWScript.SPELL_EPIC_MUMMY_DUST,
    EpicDragonKnight = NWScript.SPELL_EPIC_DRAGON_KNIGHT,
    EpicMageArmor = NWScript.SPELL_EPIC_MAGE_ARMOR,
    EpicRuin = NWScript.SPELL_EPIC_RUIN,
    AbilityDwDefensiveStance = NWScript.SPELLABILITY_DW_DEFENSIVE_STANCE,
    AbilityEpicMightyRage = NWScript.SPELLABILITY_EPIC_MIGHTY_RAGE,
    AbilityEpicCurseSong = NWScript.SPELLABILITY_EPIC_CURSE_SONG,
    AbilityEpicImprovedWhirlwind = NWScript.SPELLABILITY_EPIC_IMPROVED_WHIRLWIND,
    AbilityEpicShapeDragonkin = NWScript.SPELLABILITY_EPIC_SHAPE_DRAGONKIN,
    AbilityEpicShapeDragon = NWScript.SPELLABILITY_EPIC_SHAPE_DRAGON,
    CraftDyeClothcolor1 = NWScript.SPELL_CRAFT_DYE_CLOTHCOLOR_1,
    CraftDyeClothcolor2 = NWScript.SPELL_CRAFT_DYE_CLOTHCOLOR_2,
    CraftDyeLeathercolor1 = NWScript.SPELL_CRAFT_DYE_LEATHERCOLOR_1,
    CraftDyeLeathercolor2 = NWScript.SPELL_CRAFT_DYE_LEATHERCOLOR_2,
    CraftDyeMetalcolor1 = NWScript.SPELL_CRAFT_DYE_METALCOLOR_1,
    CraftDyeMetalcolor2 = NWScript.SPELL_CRAFT_DYE_METALCOLOR_2,
    CraftAddItemProperty = NWScript.SPELL_CRAFT_ADD_ITEM_PROPERTY,
    CraftPoisonWeaponOrAmmo = NWScript.SPELL_CRAFT_POISON_WEAPON_OR_AMMO,
    CraftCraftWeaponSkill = NWScript.SPELL_CRAFT_CRAFT_WEAPON_SKILL,
    CraftCraftArmorSkill = NWScript.SPELL_CRAFT_CRAFT_ARMOR_SKILL,
    AbilityDragonBreathNegative = NWScript.SPELLABILITY_DRAGON_BREATH_NEGATIVE,
    AbilitySeahagEvileye = NWScript.SPELLABILITY_SEAHAG_EVILEYE,
    AbilityAuraHorrificappearance = NWScript.SPELLABILITY_AURA_HORRIFICAPPEARANCE,
    AbilityTroglodyteStench = NWScript.SPELLABILITY_TROGLODYTE_STENCH,
    HorseMenu = NWScript.SPELL_HORSE_MENU,
    HorseMount = NWScript.SPELL_HORSE_MOUNT,
    HorseDismount = NWScript.SPELL_HORSE_DISMOUNT,
    HorsePartyMount = NWScript.SPELL_HORSE_PARTY_MOUNT,
    HorsePartyDismount = NWScript.SPELL_HORSE_PARTY_DISMOUNT,
    HorseAssignMount = NWScript.SPELL_HORSE_ASSIGN_MOUNT,
    PaladinSummonMount = NWScript.SPELL_PALADIN_SUMMON_MOUNT,
  }
}
