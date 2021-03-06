using System;
using System.Collections.Generic;
using NLog;
using NWN.Core;

namespace Anvil.Internal
{
  internal sealed class CoreInteropHandler : ICoreFunctionHandler, ICoreEventHandler
  {
    private static readonly Logger Log = LogManager.GetCurrentClassLogger();

    private readonly Stack<uint> scriptContexts = new Stack<uint>();
    private readonly Dictionary<ulong, Action> closures = new Dictionary<ulong, Action>();

    private readonly ICoreSignalHandler signalHandler;
    private ICoreRunScriptHandler scriptHandler;
    private ICoreLoopHandler loopHandler;

    private uint objectSelf;
    private ulong nextEventId;

    uint ICoreFunctionHandler.ObjectSelf
    {
      get => objectSelf;
    }

    public CoreInteropHandler(ICoreSignalHandler signalHandler)
    {
      this.signalHandler = signalHandler;
    }

    public void Init(ICoreRunScriptHandler scriptHandler, ICoreLoopHandler loopHandler)
    {
      this.scriptHandler = scriptHandler;
      this.loopHandler = loopHandler;
    }

    void ICoreEventHandler.OnSignal(string signal)
    {
      switch (signal)
      {
        case "ON_MODULE_LOAD_FINISH":
          signalHandler.OnStart();
          break;
        case "ON_DESTROY_SERVER":
          signalHandler.OnShutdown();
          break;
        default:
          Log.Debug($"Unhandled Signal: \"{signal}\"");
          break;
      }
    }

    void ICoreEventHandler.OnMainLoop(ulong frame)
    {
      try
      {
        loopHandler?.OnLoop();
      }
      catch (Exception e)
      {
        Log.Error(e);
      }
    }

    int ICoreEventHandler.OnRunScript(string script, uint oidSelf)
    {
      int retVal = 0;
      objectSelf = oidSelf;
      scriptContexts.Push(oidSelf);

      try
      {
        // Ignored Scripts
        if (script == EnvironmentConfig.ModStartScript || script == EnvironmentConfig.CoreShutdownScript)
        {
          return retVal;
        }

        retVal = scriptHandler.OnRunScript(script, oidSelf);
      }
      catch (Exception e)
      {
        Log.Error(e);
      }

      scriptContexts.Pop();
      objectSelf = scriptContexts.Count == 0 ? NWScript.OBJECT_INVALID : scriptContexts.Peek();
      return retVal;
    }

    void ICoreEventHandler.OnClosure(ulong eid, uint oidSelf)
    {
      uint old = objectSelf;
      objectSelf = oidSelf;

      try
      {
        closures[eid].Invoke();
      }
      catch (Exception e)
      {
        Log.Error(e);
      }

      closures.Remove(eid);
      objectSelf = old;
    }

    void ICoreFunctionHandler.ClosureAssignCommand(uint obj, Action func)
    {
      if (VM.ClosureAssignCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureDelayCommand(uint obj, float duration, Action func)
    {
      if (VM.ClosureDelayCommand(obj, duration, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureActionDoCommand(uint obj, Action func)
    {
      if (VM.ClosureActionDoCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }
  }
}
