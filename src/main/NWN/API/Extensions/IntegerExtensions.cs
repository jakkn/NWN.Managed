using System;
using NWN.Core;

namespace NWN.API
{
  public static class IntegerExtensions
  {
    public static bool ToBool(this int value) => value == NWScript.TRUE;

    public static int ToInt(this bool value) => value ? NWScript.TRUE : NWScript.FALSE;

    public static T ToNwObjectSafe<T>(this uint objectId) where T : NwObject => NwObjectFactory.CreateInternal(objectId) as T;

    public static Lazy<NwObject> ToNwObjectLazy(this uint objectId) => 
      new Lazy<NwObject>(() => ToNwObject(objectId));
    

    public static T ToNwObject<T>(this uint objectId) where T : NwObject => (T) NwObjectFactory.CreateInternal(objectId);

    public static NwObject ToNwObject(this uint objectId) => NwObjectFactory.CreateInternal(objectId);
  }
}