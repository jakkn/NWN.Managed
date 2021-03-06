using System;
using System.Runtime.InteropServices;
using Anvil.API.Events;
using Anvil.Services;
using NWN.Native.API;

namespace Anvil.API.Events
{
  public sealed class OnItemValidateEquip : IEvent
  {
    public NwCreature UsedBy { get; private init; }

    public NwItem Item { get; private init; }

    public InventorySlot Slot { get; private init; }

    public EquipValidationResult Result { get; set; }

    NwObject IEvent.Context
    {
      get => UsedBy;
    }

    internal sealed unsafe class Factory : SingleHookEventFactory<Factory.CanEquipItemHook>
    {
      internal delegate int CanEquipItemHook(void* pCreature, void* pItem, uint* pEquipToSLot, int bEquipping, int bLoading, int bDisplayFeedback, void* pFeedbackPlayer);

      protected override FunctionHook<CanEquipItemHook> RequestHook()
      {
        delegate* unmanaged<void*, void*, uint*, int, int, int, void*, int> pHook = &OnCanEquipItem;
        return HookService.RequestHook<CanEquipItemHook>(pHook, FunctionsLinux._ZN12CNWSCreature12CanEquipItemEP8CNWSItemPjiiiP10CNWSPlayer, HookOrder.Early);
      }

      [UnmanagedCallersOnly]
      private static int OnCanEquipItem(void* pCreature, void* pItem, uint* pEquipToSLot, int bEquipping, int bLoading, int bDisplayFeedback, void* pFeedbackPlayer)
      {
        OnItemValidateEquip eventData = ProcessEvent(new OnItemValidateEquip
        {
          UsedBy = CNWSCreature.FromPointer(pCreature).ToNwObject<NwCreature>(),
          Item = CNWSItem.FromPointer(pItem).ToNwObject<NwItem>(),
          Slot = (InventorySlot)Math.Round(Math.Log2(*pEquipToSLot)),
          Result = (EquipValidationResult)Hook.CallOriginal(pCreature, pItem, pEquipToSLot, bEquipping, bLoading, bDisplayFeedback, pFeedbackPlayer),
        });

        return (int)eventData.Result;
      }
    }
  }
}

namespace Anvil.API
{
  public sealed partial class NwCreature
  {
    /// <inheritdoc cref="Events.OnItemValidateEquip"/>
    public event Action<OnItemValidateEquip> OnItemValidateEquip
    {
      add => EventService.Subscribe<OnItemValidateEquip, OnItemValidateEquip.Factory>(this, value);
      remove => EventService.Unsubscribe<OnItemValidateEquip, OnItemValidateEquip.Factory>(this, value);
    }
  }

  public sealed partial class NwModule
  {
    /// <inheritdoc cref="Events.OnItemValidateEquip"/>
    public event Action<OnItemValidateEquip> OnItemValidateEquip
    {
      add => EventService.SubscribeAll<OnItemValidateEquip, OnItemValidateEquip.Factory>(value);
      remove => EventService.UnsubscribeAll<OnItemValidateEquip, OnItemValidateEquip.Factory>(value);
    }
  }
}
