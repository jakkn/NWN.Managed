using NWM.API;
using NWM.API.Constants;
using NWNX;

namespace NWMX.API
{
  public static class NwCreatureExtensions
  {
    static NwCreatureExtensions()
    {
      PluginUtils.AssertPluginExists<CreaturePlugin>();
    }

    public static void AddFeat(this NwCreature creature, Feat feat, int level = 0)
    {
      if (level > 0)
      {
        CreaturePlugin.AddFeatByLevel(creature, (int) feat, level);
      }
      else
      {
        CreaturePlugin.AddFeat(creature, (int) feat);
      }
    }

    public static bool KnowsFeat(this NwCreature creature, Feat feat)
    {
      return CreaturePlugin.GetKnowsFeat(creature, (int) feat).ToBool();
    }

    public static void RemoveFeat(this NwCreature creature, Feat feat)
    {
      CreaturePlugin.RemoveFeat(creature, (int) feat);
    }

    public static int GetFeatGrantLevel(this NwCreature creature, Feat feat)
    {
      return CreaturePlugin.GetFeatGrantLevel(creature, (int) feat);
    }

    public static int GetMemorisedSpellCountByLevel(this NwCreature creature, ClassType classType, int spellLevel)
    {
      return CreaturePlugin.GetMemorisedSpellCountByLevel(creature, (int) classType, spellLevel);
    }

    public static void ClearMemorisedSpell(this NwCreature creature, ClassType classType, int spellLevel, int index)
    {
      CreaturePlugin.ClearMemorisedSpell(creature, (int) classType, spellLevel, index);
    }

    public static ClassType GetClassByLevel(this NwCreature creature, int level)
    {
      return (ClassType) CreaturePlugin.GetClassByLevel(creature, level);
    }

    public static bool CheckUseMagicDeviceSkill(this NwCreature creature, NwItem item)
    {
      return CreaturePlugin.CheckUseMagicDeviceSkill(creature, item, 1).ToBool();
    }
  }
}