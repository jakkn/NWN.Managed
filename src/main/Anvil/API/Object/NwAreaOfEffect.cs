using System;
using System.Collections.Generic;
using NWN.Core;
using NWN.Native.API;

namespace Anvil.API
{
  [NativeObjectInfo(ObjectTypes.AreaOfEffect, ObjectType.AreaOfEffect)]
  public sealed partial class NwAreaOfEffect : NwGameObject
  {
    internal readonly CNWSAreaOfEffectObject AreaOfEffect;

    internal NwAreaOfEffect(CNWSAreaOfEffectObject areaOfEffectObject) : base(areaOfEffectObject)
    {
      AreaOfEffect = areaOfEffectObject;
    }

    public static implicit operator CNWSAreaOfEffectObject(NwAreaOfEffect areaOfEffect)
    {
      return areaOfEffect?.AreaOfEffect;
    }

    /// <summary>
    /// Gets the creator of this Area of Effect.
    /// </summary>
    public NwGameObject Creator
    {
      get => NWScript.GetAreaOfEffectCreator(this).ToNwObject<NwGameObject>();
    }

    /// <summary>
    /// Gets all objects of the given type that are currently in this area of effect.
    /// </summary>
    /// <typeparam name="T">The type of objects to return.</typeparam>
    /// <returns>An enumerable containing all objects currently in the effect area.</returns>
    public IEnumerable<T> GetObjectsInEffectArea<T>() where T : NwGameObject
    {
      int objType = (int)GetObjectType<T>();
      for (uint obj = NWScript.GetFirstInPersistentObject(this, objType); obj != Invalid; obj = NWScript.GetNextInPersistentObject(this, objType))
      {
        T gameObject = obj.ToNwObjectSafe<T>();
        if (gameObject != null)
        {
          yield return gameObject;
        }
      }
    }

    /// <summary>
    /// Gets all objects of the given types that are currently in this area of effect.
    /// </summary>
    /// <param name="objectTypes">The types of object to return.</param>
    /// <returns>An enumerable containing all objects currently in the effect area.</returns>
    public IEnumerable<NwGameObject> GetObjectsInEffectArea(ObjectTypes objectTypes)
    {
      int objType = (int)objectTypes;
      for (uint obj = NWScript.GetFirstInPersistentObject(this, objType); obj != Invalid; obj = NWScript.GetNextInPersistentObject(this, objType))
      {
        yield return obj.ToNwObject<NwGameObject>();
      }
    }

    public override byte[] Serialize()
    {
      throw new NotSupportedException();
    }

    private protected override void AddToArea(CNWSArea area, float x, float y, float z)
    {
      AreaOfEffect.AddToArea(area, x, y, z, true.ToInt());
    }
  }
}
