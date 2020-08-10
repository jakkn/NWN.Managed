using NWN.API.Constants;

namespace NWN.API
{
  public static class TalentExtensions
  {
    public static Talent ToTalent(this Skill skill) => skill;

    public static Talent ToTalent(this Spell spell) => spell;

    public static Talent ToTalent(this Feat feat) => feat;
  }
}