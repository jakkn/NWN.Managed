using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NWN.API.Constants;
using NWN.Core;
using NWN.Core.NWNX;
using Vector3 = System.Numerics.Vector3;

namespace NWN.API
{
  public abstract class NwGameObject : NwObject
  {
    internal NwGameObject(uint objectId) : base(objectId)
    {
      faction = new NwFaction(this);
    }

    /// <summary>
    /// Gets or sets the location of this object.
    /// </summary>
    public virtual Location Location
    {
      get => NWScript.GetLocation(this);
      set
      {
        ObjectPlugin.AddToArea(this, value.Area, value.Position);
        Rotation = value.Rotation;
      }
    }

    /// <summary>
    /// Gets the area this object is currently in.
    /// </summary>
    public NwArea Area
    {
      get => NWScript.GetArea(this).ToNwObject<NwArea>();
    }

    private readonly NwFaction faction;

    /// <summary>
    /// Gets or sets the faction of this object.
    /// </summary>
    public NwFaction Faction
    {
      get => faction;
      set => NWScript.ChangeFaction(this, value.GameObject);
    }

    /// <summary>
    /// Gets or sets the local area position of this GameObject.
    /// </summary>
    public Vector3 Position
    {
      get => NWScript.GetPosition(this);
      set => ObjectPlugin.SetPosition(this, value);
    }

    /// <summary>
    /// Gets or sets the transition target for this object.
    /// </summary>
    public NwGameObject TransitionTarget
    {
      get => NWScript.GetTransitionTarget(this).ToNwObject<NwGameObject>();
      set => NWScript.SetTransitionTarget(this, value);
    }

    /// <summary>
    /// Gets or sets the world rotation for this object.
    /// </summary>
    public virtual float Rotation
    {
      get => NWScript.GetFacing(this) % 360;
      set => ObjectPlugin.SetFacing(this, value % 360);
    }

    /// <summary>
    /// Gets or sets the visual transform for this object.
    /// </summary>
    public VisualTransform VisualTransform
    {
      get => new VisualTransform(this);
      set => value?.Apply(this);
    }

    /// <summary>
    /// Gets a value indicating whether this object is in a conversation.
    /// </summary>
    public bool IsInConversation
    {
      get => NWScript.IsInConversation(this).ToBool();
    }

    /// <summary>
    /// Gets or sets the Portrait ResRef for this object.
    /// </summary>
    public string PortraitResRef
    {
      get => NWScript.GetPortraitResRef(this);
      set => NWScript.SetPortraitResRef(this, value);
    }

    /// <summary>
    /// Gets the current HP for this object.
    /// </summary>
    public int HP
    {
      get => NWScript.GetCurrentHitPoints(this);
    }

    /// <summary>
    /// Gets the maximum HP for this object. Returns 0 if this object has no defined HP.
    /// </summary>
    public int MaxHP
    {
      get => NWScript.GetMaxHitPoints(this);
    }

    /// <summary>
    /// Gets or sets a value indicating whether the plot flag is enabled.
    /// </summary>
    public bool PlotFlag
    {
      get => NWScript.GetPlotFlag(this).ToBool();
      set => NWScript.SetPlotFlag(this, value.ToInt());
    }

    /// <summary>
    /// Sets the highlight color of this object.
    /// </summary>
    public Color HiliteColor
    {
      set => NWScript.SetObjectHiliteColor(this, value.ToInt());
    }

    /// <summary>
    /// Gets all items belonging to this object's inventory.
    /// </summary>
    public IEnumerable<NwItem> Items
    {
      get
      {
        for (uint item = NWScript.GetFirstItemInInventory(this); item != INVALID; item = NWScript.GetNextItemInInventory(this))
        {
          yield return item.ToNwObject<NwItem>();
        }
      }
    }

    /// <summary>
    /// Returns the distance to the target.<br/>
    /// If you only need to compare the distance, you can compare the squared distance using <see cref="SqrDistanceToObject"/> to avoid a costly sqrt operation.
    /// </summary>
    /// <param name="target">The other object to calculate distance from.</param>
    /// <returns>The distance in game units, or -1 if this target is in a different area.</returns>
    public float DistanceToObject(NwGameObject target)
    {
      if (target.Area != Area)
      {
        return -1.0f;
      }

      return (target.Position - Position).Length();
    }

    /// <summary>
    /// Returns the squared distance to the target.
    /// </summary>
    /// <param name="target">The other object to calculate distance from.</param>
    /// <returns>The squared distance in game units, or -1 if this target is in a different area.</returns>
    public float SqrDistanceToObject(NwGameObject target)
    {
      if (target.Area != Area)
      {
        return -1.0f;
      }

      return (target.Position - Position).LengthSquared();
    }

    /// <summary>
    /// Rotates this object to face the specified facing angle.
    /// </summary>
    /// <param name="facing">The angle to face.</param>
    public async Task SetFacing(float facing)
    {
      await WaitForObjectContext();
      NWScript.SetFacing(facing);
    }

    /// <summary>
    /// Rotates this object to face towards target.
    /// </summary>
    /// <param name="target">The target object to face.</param>
    public async Task FaceToObject(NwGameObject target)
    {
      await FaceToPoint(target.Position);
    }

    /// <summary>
    /// Rotates this object to face a position.
    /// </summary>
    /// <param name="point">The position to face towards.</param>
    public virtual async Task FaceToPoint(Vector3 point)
    {
      await WaitForObjectContext();
      NWScript.SetFacingPoint(point);
    }

    /// <summary>
    /// Gets the color for the specified color channel.
    /// </summary>
    /// @note A chart of available colors can be found here: https://nwnlexicon.com/index.php?title=Color_Charts
    /// <param name="colorChannel">The color channel that you want to get the color value of.</param>
    /// <returns>The current color index value of the specified channel.</returns>
    public int GetColor(ColorChannel colorChannel)
      => NWScript.GetColor(this, (int) colorChannel);

    /// <summary>
    /// Sets the color for the specified color channel.
    /// </summary>
    /// @note A chart of available colors can be found here: https://nwnlexicon.com/index.php?title=Color_Charts
    /// <param name="colorChannel">The color channel to modify.</param>
    /// <param name="newColor">The color channel's new color index.</param>
    public void SetColor(ColorChannel colorChannel, int newColor)
      => NWScript.SetColor(this, (int) colorChannel, newColor);

    /// <summary>
    /// Plays the specified animation.
    /// </summary>
    /// <param name="animation">Constant value representing the animation to play.</param>
    /// <param name="animSpeed">Speed to play the animation.</param>
    /// <param name="queueAsAction">If true, enqueues animation playback in the object's action queue.</param>
    /// <param name="duration">Duration to keep animating. Not used in fire and forget animations.</param>
    public async Task PlayAnimation(Animation animation, float animSpeed, bool queueAsAction = false, TimeSpan duration = default)
    {
      await WaitForObjectContext();
      if (!queueAsAction)
      {
        NWScript.PlayAnimation((int) animation, animSpeed, (float) duration.TotalSeconds);
      }
      else
      {
        NWScript.ActionPlayAnimation((int) animation, animSpeed, (float) duration.TotalSeconds);
      }
    }

    /// <summary>
    /// Returns the creatures closest to this object.
    /// </summary>
    public IEnumerable<NwCreature> GetNearestCreatures()
      => GetNearestCreatures(CreatureTypeFilter.None, CreatureTypeFilter.None, CreatureTypeFilter.None);

    /// <summary>
    /// Returns the creatures closest to this object, matching the specified criteria.
    /// </summary>
    /// <param name="filter1">A filter created using <see cref="CreatureTypeFilter"/>.</param>
    public IEnumerable<NwCreature> GetNearestCreatures(CreatureTypeFilter filter1)
      => GetNearestCreatures(filter1, CreatureTypeFilter.None, CreatureTypeFilter.None);

    /// <summary>
    /// Returns the creatures closest to this object, matching all of the specified criteria.
    /// </summary>
    /// <param name="filter1">A filter created using <see cref="CreatureTypeFilter"/>.</param>
    /// <param name="filter2">A 2nd filter created using <see cref="CreatureTypeFilter"/>.</param>
    public IEnumerable<NwCreature> GetNearestCreatures(CreatureTypeFilter filter1, CreatureTypeFilter filter2)
      => GetNearestCreatures(filter1, filter2, CreatureTypeFilter.None);

    /// <summary>
    /// Returns the creatures closest to this object, matching all of the specified criteria.
    /// </summary>
    /// <param name="filter1">A filter created using <see cref="CreatureTypeFilter"/>.</param>
    /// <param name="filter2">A 2nd filter created using <see cref="CreatureTypeFilter"/>.</param>
    /// <param name="filter3">A 3rd filter created using <see cref="CreatureTypeFilter"/>.</param>
    public IEnumerable<NwCreature> GetNearestCreatures(CreatureTypeFilter filter1, CreatureTypeFilter filter2, CreatureTypeFilter filter3)
    {
      int i;
      uint current;

      for (i = 1, current = NWScript.GetNearestCreature(
          filter1.Key,
          filter1.Value,
          this,
          i,
          filter2.Key,
          filter2.Value,
          filter3.Key,
          filter3.Value);
        current != INVALID;
        i++, current = NWScript.GetNearestCreature(
          filter1.Key,
          filter1.Value,
          this,
          i,
          filter2.Key,
          filter2.Value,
          filter3.Key,
          filter3.Value))
      {
        yield return current.ToNwObject<NwCreature>();
      }
    }

    /// <summary>
    /// Gets the nearest object that is of the specified type.
    /// </summary>
    /// <typeparam name="T">The type of object to search.</typeparam>
    public IEnumerable<T> GetNearestObjectsByType<T>() where T : NwGameObject
    {
      int objType = (int) NwObject.GetObjectType<T>();
      int i;
      uint current;

      for (i = 1, current = NWScript.GetNearestObject(objType, this, i); current != INVALID; i++, current = NWScript.GetNearestObject(objType, this, i))
      {
        T obj = current.ToNwObjectSafe<T>();
        if (obj != null)
        {
          yield return obj;
        }
      }
    }

    /// <summary>
    /// Plays the specified sound as mono audio from the location of this object.
    /// </summary>
    /// <param name="soundName">The name of the sound to play.</param>
    public async Task PlaySound(string soundName)
    {
      await WaitForObjectContext();
      NWScript.PlaySound(soundName);
    }

    /// <summary>
    /// Gets this creature's base save value for the specified saving throw.
    /// </summary>
    /// <param name="savingThrow">The type of saving throw.</param>
    /// <returns>The creature's base saving throw value.</returns>
    /// <exception cref="ArgumentOutOfRangeException">If savingThrow is not Fortitude, Reflex, or Will.</exception>
    public int GetBaseSavingThrow(SavingThrow savingThrow)
    {
      switch (savingThrow)
      {
        case SavingThrow.Fortitude:
          return NWScript.GetFortitudeSavingThrow(this);
        case SavingThrow.Reflex:
          return NWScript.GetReflexSavingThrow(this);
        case SavingThrow.Will:
          return NWScript.GetWillSavingThrow(this);
        default:
          throw new ArgumentOutOfRangeException(nameof(savingThrow), savingThrow, null);
      }
    }

    /// <summary>
    /// Performs a saving throw against the given dc.
    /// </summary>
    /// <param name="savingThrow">The type of saving throw to make (Fortitude/Reflex/Will).</param>
    /// <param name="dc">Difficulty class.</param>
    /// <param name="saveType">The sub-type of this save (Mind effect, etc).</param>
    /// <param name="saveVs">The creature this object is making the save against.</param>
    /// <exception cref="ArgumentOutOfRangeException">If savingThrow is not Fortitude, Reflex, or Will.</exception>
    /// <returns>The result of the saving throw.</returns>
    public SavingThrowResult RollSavingThrow(SavingThrow savingThrow, int dc, SavingThrowType saveType, NwGameObject saveVs = null)
    {
      switch (savingThrow)
      {
        case SavingThrow.Fortitude:
          return (SavingThrowResult) NWScript.FortitudeSave(this, dc, (int) saveType, saveVs);
        case SavingThrow.Reflex:
          return (SavingThrowResult) NWScript.ReflexSave(this, dc, (int) saveType, saveVs);
        case SavingThrow.Will:
          return (SavingThrowResult) NWScript.WillSave(this, dc, (int) saveType, saveVs);
        default:
          throw new ArgumentOutOfRangeException(nameof(savingThrow), savingThrow, null);
      }
    }

    /// <summary>
    /// Casts a spell at an object.
    /// </summary>
    /// <param name="spell">The spell to cast.</param>
    /// <param name="target">The target for the spell.</param>
    /// <param name="metaMagic">Metamagic that should be applied to the spell.</param>
    /// <param name="cheat">If true, this object doesn't have to be able to cast the spell.</param>
    /// <param name="domainLevel">Specifies the spell level if the spell is to be cast as a domain spell.</param>
    /// <param name="projectilePathType">The type of projectile path to use for this spell.</param>
    /// <param name="instant">If true, the spell is cast immediately.</param>
    public async Task ActionCastSpellAt(Spell spell, NwGameObject target, MetaMagic metaMagic = MetaMagic.Any, bool cheat = false, int domainLevel = 0, ProjectilePathType projectilePathType = ProjectilePathType.Default, bool instant = false)
    {
      await WaitForObjectContext();
      NWScript.ActionCastSpellAtObject((int) spell, target, (int) metaMagic, cheat.ToInt(), domainLevel, (int) projectilePathType, instant.ToInt());
    }

    /// <summary>
    /// Casts a spell at an location.
    /// </summary>
    /// <param name="spell">The spell to cast.</param>
    /// <param name="target">The target for the spell.</param>
    /// <param name="metaMagic">Metamagic that should be applied to the spell.</param>
    /// <param name="cheat">If true, this object doesn't have to be able to cast the spell.</param>
    /// <param name="projectilePathType">The type of projectile path to use for this spell.</param>
    /// <param name="instant">If true, the spell is cast immediately.</param>
    public async Task ActionCastSpellAt(Spell spell, Location target, MetaMagic metaMagic = MetaMagic.Any, bool cheat = false, ProjectilePathType projectilePathType = ProjectilePathType.Default, bool instant = false)
    {
      await WaitForObjectContext();
      NWScript.ActionCastSpellAtLocation((int) spell, target, (int) metaMagic, cheat.ToInt(), (int) projectilePathType, instant.ToInt());
    }

    /// <summary>
    /// Instructs this object to do nothing for the specified duration, before continuing with the next item in the action queue.
    /// </summary>
    /// <param name="duration">The time to wait.</param>
    public async Task ActionWait(TimeSpan duration)
    {
      await WaitForObjectContext();
      NWScript.ActionWait((float) duration.TotalSeconds);
    }

    /// <summary>
    /// Destroys this object (irrevocably).
    /// </summary>
    /// <param name="delay">Time in seconds until this object should be destroyed.</param>
    public void Destroy(float delay = 0.0f)
    {
      NWScript.DestroyObject(this, delay);
    }

    /// <summary>
    /// Gets or sets the appearance of this creature.
    /// </summary>
    public AppearanceType CreatureAppearanceType
    {
      get => (AppearanceType)NWScript.GetAppearanceType(this);
      set => NWScript.SetCreatureAppearanceType(this, (int)value);
    }
  }
}