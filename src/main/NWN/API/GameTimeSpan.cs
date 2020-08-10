using System;
using NWN.Core;

namespace NWN.API
{
  public static class GameTimeSpan
  {
    public static TimeSpan FromRounds(int rounds) => TimeSpan.FromSeconds(NWScript.RoundsToSeconds(rounds));

    public static TimeSpan FromHours(int hours) => TimeSpan.FromSeconds(NWScript.HoursToSeconds(hours));

    public static TimeSpan FromTurns(int turns) => TimeSpan.FromSeconds(NWScript.TurnsToSeconds(turns));
  }
}