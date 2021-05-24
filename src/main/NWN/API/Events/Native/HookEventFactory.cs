using System;
using NWN.Services;

namespace NWN.API.Events
{
  public abstract class HookEventFactory
  {
    protected static Lazy<EventService> EventService { get; private set; }

    protected static HookService HookService { get; private set; }

    [ServiceBinding(typeof(APIBindings))]
    [ServiceBindingOptions(BindingOrder.API)]
    internal sealed class APIBindings
    {
      public APIBindings(Lazy<EventService> eventService, HookService hookService)
      {
        EventService = eventService;
        HookService = hookService;
      }
    }

    protected static TEvent ProcessEvent<TEvent>(TEvent eventData) where TEvent : IEvent
    {
      VirtualMachine.Instance.ExecuteInScriptContext(() => { eventData = EventService.Value.ProcessEvent(eventData); }, eventData.Context);
      return eventData;
    }
  }
}