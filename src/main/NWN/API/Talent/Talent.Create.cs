using NWN.API.Constants;
using NWN.Core;

namespace NWN.API
{
  public partial class Talent
  {
    public static implicit operator Talent(Skill skill) => NWScript.TalentSkill((int) skill);

    public static implicit operator Talent(Spell spell) => NWScript.TalentSpell((int) spell);

    public static implicit operator Talent(Feat feat) => NWScript.TalentFeat((int) feat);
  }
}