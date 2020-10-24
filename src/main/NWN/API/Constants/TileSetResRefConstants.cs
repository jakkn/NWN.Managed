using System;
using NWN.Core;

namespace NWN.API.Constants
{
  public enum TileSetTypes
  {
    BeholderCaves,
    CastleInterior,
    CityExterior,
    CityInterior,
    Crypt,
    Desert,
    DrowInterior,
    Dungeon,
    Forest,
    FrozenWastes,
    IllithidInterior,
    Microset,
    MinesAndCaverns,
    Ruins,
    Rural,
    RuralWinter,
    Sewers,
    Underdark,
    LizardfolkInterior,
    MedievalCity2,
    MedievalRural2,
    EarlyWinter2,
    SeaShips,
    ForestFacelift,
    RuralWinterFacelift,
    Steamworks,
    BarrowsInterior,
    SeaCaves,
    CityInterior2,
    CastleInterior2,
    CastleExteriorRural,
    Tropical,
    FortInterior
  }

  public class NwTileset
  {
    public readonly TileSetTypes Tileset;

    public readonly string Resref;

    public NwTileset(TileSetTypes tileset)
    {
      this.Tileset = tileset;
      this.Resref = tileset switch
      {
        TileSetTypes.BeholderCaves => NWScript.TILESET_RESREF_BEHOLDER_CAVES,
        TileSetTypes.CastleInterior => NWScript.TILESET_RESREF_CASTLE_INTERIOR,
        TileSetTypes.CityExterior => NWScript.TILESET_RESREF_CITY_EXTERIOR,
        TileSetTypes.CityInterior => NWScript.TILESET_RESREF_CITY_INTERIOR,
        TileSetTypes.Crypt => NWScript.TILESET_RESREF_CRYPT,
        TileSetTypes.Desert => NWScript.TILESET_RESREF_DESERT,
        TileSetTypes.DrowInterior => NWScript.TILESET_RESREF_DROW_INTERIOR,
        TileSetTypes.Dungeon => NWScript.TILESET_RESREF_DUNGEON,
        TileSetTypes.Forest => NWScript.TILESET_RESREF_FOREST,
        TileSetTypes.FrozenWastes => NWScript.TILESET_RESREF_FROZEN_WASTES,
        TileSetTypes.IllithidInterior => NWScript.TILESET_RESREF_ILLITHID_INTERIOR,
        TileSetTypes.Microset => NWScript.TILESET_RESREF_MICROSET,
        TileSetTypes.MinesAndCaverns => NWScript.TILESET_RESREF_MINES_AND_CAVERNS,
        TileSetTypes.Ruins => NWScript.TILESET_RESREF_RUINS,
        TileSetTypes.Rural => NWScript.TILESET_RESREF_RURAL,
        TileSetTypes.RuralWinter => NWScript.TILESET_RESREF_RURAL_WINTER,
        TileSetTypes.Sewers => NWScript.TILESET_RESREF_SEWERS,
        TileSetTypes.Underdark => NWScript.TILESET_RESREF_UNDERDARK,
        TileSetTypes.LizardfolkInterior => "dag01",
        TileSetTypes.MedievalCity2 => "tcm02",
        TileSetTypes.MedievalRural2 => "trm02",
        TileSetTypes.EarlyWinter2 => "trs02",
        TileSetTypes.SeaShips => "tss13",
        TileSetTypes.ForestFacelift => "ttf02",
        TileSetTypes.RuralWinterFacelift => "tts02",
        TileSetTypes.Steamworks => "tsw01",
        TileSetTypes.BarrowsInterior => "tbw01",
        TileSetTypes.SeaCaves => "tdt01",
        TileSetTypes.CityInterior2 => "tni01",
        TileSetTypes.CastleInterior2 => "tni02",
        TileSetTypes.CastleExteriorRural => "tno01",
        TileSetTypes.Tropical => "ttz01",
        TileSetTypes.FortInterior => "twc03",
        _ => throw new ArgumentOutOfRangeException(nameof(tileset), tileset, null)
      };
    }
  }
}
