using NWN.Core;

namespace NWN.API.Constants
{
  public enum EventScriptType
  {
    ModuleOnHeartbeat = NWScript.EVENT_SCRIPT_MODULE_ON_HEARTBEAT,
    ModuleOnUserDefinedEvent = NWScript.EVENT_SCRIPT_MODULE_ON_USER_DEFINED_EVENT,
    ModuleOnModuleLoad = NWScript.EVENT_SCRIPT_MODULE_ON_MODULE_LOAD,
    ModuleOnModuleStart = NWScript.EVENT_SCRIPT_MODULE_ON_MODULE_START,
    ModuleOnClientEnter = NWScript.EVENT_SCRIPT_MODULE_ON_CLIENT_ENTER,
    ModuleOnClientExit = NWScript.EVENT_SCRIPT_MODULE_ON_CLIENT_EXIT,
    ModuleOnActivateItem = NWScript.EVENT_SCRIPT_MODULE_ON_ACTIVATE_ITEM,
    ModuleOnAcquireItem = NWScript.EVENT_SCRIPT_MODULE_ON_ACQUIRE_ITEM,
    ModuleOnLoseItem = NWScript.EVENT_SCRIPT_MODULE_ON_LOSE_ITEM,
    ModuleOnPlayerDeath = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_DEATH,
    ModuleOnPlayerDying = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_DYING,
    ModuleOnRespawnButtonPressed = NWScript.EVENT_SCRIPT_MODULE_ON_RESPAWN_BUTTON_PRESSED,
    ModuleOnPlayerRest = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_REST,
    ModuleOnPlayerLevelUp = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_LEVEL_UP,
    ModuleOnPlayerCancelCutscene = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_CANCEL_CUTSCENE,
    ModuleOnEquipItem = NWScript.EVENT_SCRIPT_MODULE_ON_EQUIP_ITEM,
    ModuleOnUnequipItem = NWScript.EVENT_SCRIPT_MODULE_ON_UNEQUIP_ITEM,
    ModuleOnPlayerChat = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_CHAT,
    ModuleOnPlayerTarget = NWScript.EVENT_SCRIPT_MODULE_ON_PLAYER_TARGET,
    AreaOnHeartbeat = NWScript.EVENT_SCRIPT_AREA_ON_HEARTBEAT,
    AreaOnUserDefinedEvent = NWScript.EVENT_SCRIPT_AREA_ON_USER_DEFINED_EVENT,
    AreaOnEnter = NWScript.EVENT_SCRIPT_AREA_ON_ENTER,
    AreaOnExit = NWScript.EVENT_SCRIPT_AREA_ON_EXIT,
    AreaOfEffectOnHeartbeat = NWScript.EVENT_SCRIPT_AREAOFEFFECT_ON_HEARTBEAT,
    AreaOfEffectOnUserDefinedEvent = NWScript.EVENT_SCRIPT_AREAOFEFFECT_ON_USER_DEFINED_EVENT,
    AreaOfEffectOnObjectEnter = NWScript.EVENT_SCRIPT_AREAOFEFFECT_ON_OBJECT_ENTER,
    AreaOfEffectOnObjectExit = NWScript.EVENT_SCRIPT_AREAOFEFFECT_ON_OBJECT_EXIT,
    CreatureOnHeartbeat = NWScript.EVENT_SCRIPT_CREATURE_ON_HEARTBEAT,
    CreatureOnNotice = NWScript.EVENT_SCRIPT_CREATURE_ON_NOTICE,
    CreatureOnSpellCastAt = NWScript.EVENT_SCRIPT_CREATURE_ON_SPELLCASTAT,
    CreatureOnMeleeAttacked = NWScript.EVENT_SCRIPT_CREATURE_ON_MELEE_ATTACKED,
    CreatureOnDamaged = NWScript.EVENT_SCRIPT_CREATURE_ON_DAMAGED,
    CreatureOnDisturbed = NWScript.EVENT_SCRIPT_CREATURE_ON_DISTURBED,
    CreatureOnEndCombatRound = NWScript.EVENT_SCRIPT_CREATURE_ON_END_COMBATROUND,
    CreatureOnDialogue = NWScript.EVENT_SCRIPT_CREATURE_ON_DIALOGUE,
    CreatureOnSpawnIn = NWScript.EVENT_SCRIPT_CREATURE_ON_SPAWN_IN,
    CreatureOnRested = NWScript.EVENT_SCRIPT_CREATURE_ON_RESTED,
    CreatureOnDeath = NWScript.EVENT_SCRIPT_CREATURE_ON_DEATH,
    CreatureOnUserDefinedEvent = NWScript.EVENT_SCRIPT_CREATURE_ON_USER_DEFINED_EVENT,
    CreatureOnBlockedByDoor = NWScript.EVENT_SCRIPT_CREATURE_ON_BLOCKED_BY_DOOR,
    TriggerOnHeartbeat = NWScript.EVENT_SCRIPT_TRIGGER_ON_HEARTBEAT,
    TriggerOnObjectEnter = NWScript.EVENT_SCRIPT_TRIGGER_ON_OBJECT_ENTER,
    TriggerOnObjectExit = NWScript.EVENT_SCRIPT_TRIGGER_ON_OBJECT_EXIT,
    TriggerOnUserDefinedEvent = NWScript.EVENT_SCRIPT_TRIGGER_ON_USER_DEFINED_EVENT,
    TriggerOnTrapTriggered = NWScript.EVENT_SCRIPT_TRIGGER_ON_TRAPTRIGGERED,
    TriggerOnDisarmed = NWScript.EVENT_SCRIPT_TRIGGER_ON_DISARMED,
    TriggerOnClicked = NWScript.EVENT_SCRIPT_TRIGGER_ON_CLICKED,
    PlaceableOnClosed = NWScript.EVENT_SCRIPT_PLACEABLE_ON_CLOSED,
    PlaceableOnDamaged = NWScript.EVENT_SCRIPT_PLACEABLE_ON_DAMAGED,
    PlaceableOnDeath = NWScript.EVENT_SCRIPT_PLACEABLE_ON_DEATH,
    PlaceableOnDisarm = NWScript.EVENT_SCRIPT_PLACEABLE_ON_DISARM,
    PlaceableOnHeartbeat = NWScript.EVENT_SCRIPT_PLACEABLE_ON_HEARTBEAT,
    PlaceableOnInventoryDisturbed = NWScript.EVENT_SCRIPT_PLACEABLE_ON_INVENTORYDISTURBED,
    PlaceableOnLock = NWScript.EVENT_SCRIPT_PLACEABLE_ON_LOCK,
    PlaceableOnMeleeAttacked = NWScript.EVENT_SCRIPT_PLACEABLE_ON_MELEEATTACKED,
    PlaceableOnOpen = NWScript.EVENT_SCRIPT_PLACEABLE_ON_OPEN,
    PlaceableOnSpellCastAt = NWScript.EVENT_SCRIPT_PLACEABLE_ON_SPELLCASTAT,
    PlaceableOnTrapTriggered = NWScript.EVENT_SCRIPT_PLACEABLE_ON_TRAPTRIGGERED,
    PlaceableOnUnlock = NWScript.EVENT_SCRIPT_PLACEABLE_ON_UNLOCK,
    PlaceableOnUsed = NWScript.EVENT_SCRIPT_PLACEABLE_ON_USED,
    PlaceableOnUserDefinedEvent = NWScript.EVENT_SCRIPT_PLACEABLE_ON_USER_DEFINED_EVENT,
    PlaceableOnDialogue = NWScript.EVENT_SCRIPT_PLACEABLE_ON_DIALOGUE,
    PlaceableOnLeftClick = NWScript.EVENT_SCRIPT_PLACEABLE_ON_LEFT_CLICK,
    DoorOnOpen = NWScript.EVENT_SCRIPT_DOOR_ON_OPEN,
    DoorOnClose = NWScript.EVENT_SCRIPT_DOOR_ON_CLOSE,
    DoorOnDamage = NWScript.EVENT_SCRIPT_DOOR_ON_DAMAGE,
    DoorOnDeath = NWScript.EVENT_SCRIPT_DOOR_ON_DEATH,
    DoorOnDisarm = NWScript.EVENT_SCRIPT_DOOR_ON_DISARM,
    DoorOnHeartbeat = NWScript.EVENT_SCRIPT_DOOR_ON_HEARTBEAT,
    DoorOnLock = NWScript.EVENT_SCRIPT_DOOR_ON_LOCK,
    DoorOnMeleeAttacked = NWScript.EVENT_SCRIPT_DOOR_ON_MELEE_ATTACKED,
    DoorOnSpellCastAt = NWScript.EVENT_SCRIPT_DOOR_ON_SPELLCASTAT,
    DoorOnTrapTriggered = NWScript.EVENT_SCRIPT_DOOR_ON_TRAPTRIGGERED,
    DoorOnUnlock = NWScript.EVENT_SCRIPT_DOOR_ON_UNLOCK,
    DoorOnUserDefined = NWScript.EVENT_SCRIPT_DOOR_ON_USERDEFINED,
    DoorOnClicked = NWScript.EVENT_SCRIPT_DOOR_ON_CLICKED,
    DoorOnDialogue = NWScript.EVENT_SCRIPT_DOOR_ON_DIALOGUE,
    DoorOnFailToOpen = NWScript.EVENT_SCRIPT_DOOR_ON_FAIL_TO_OPEN,
    EncounterOnObjectEnter = NWScript.EVENT_SCRIPT_ENCOUNTER_ON_OBJECT_ENTER,
    EncounterOnObjectExit = NWScript.EVENT_SCRIPT_ENCOUNTER_ON_OBJECT_EXIT,
    EncounterOnHeartbeat = NWScript.EVENT_SCRIPT_ENCOUNTER_ON_HEARTBEAT,
    EncounterOnEncounterExhausted = NWScript.EVENT_SCRIPT_ENCOUNTER_ON_ENCOUNTER_EXHAUSTED,
    EncounterOnUserDefinedEvent = NWScript.EVENT_SCRIPT_ENCOUNTER_ON_USER_DEFINED_EVENT,
    StoreOnOpen = NWScript.EVENT_SCRIPT_STORE_ON_OPEN,
    StoreOnClose = NWScript.EVENT_SCRIPT_STORE_ON_CLOSE
  }
}
