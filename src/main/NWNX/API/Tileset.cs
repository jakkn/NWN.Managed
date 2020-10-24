git pusing System;
using NWN.API;
using NWN.API.Constants;
using NWN.Core.NWNX;

namespace NWNX.API
{
  public static class Tileset
  {
    static Tileset()
    {
      PluginUtils.AssertPluginExists<TilesetPlugin>();
    }

    public static TilesetData GetTilesetData(NwTileset tileset)
      => TilesetPlugin.GetTilesetData(tileset.Resref);




    public struct TilesetData
    {
      public int NumTileData;
      public float HeightTransition;
      public int NumTerrain;
      public int NumCrossers;
      public int NumGroups;
      public string BorderTerrain;
      public string DefaultTerrain;
      public string FloorTerrain;
      public int DisplayNameStrRef;
      public string UnlocalizedName;
      public int Interior;
      public int HasHeightTransition;

      public static implicit operator NWN.Core.NWNX.TilesetData(TilesetData tilesetData)
      {
        return new NWN.Core.NWNX.TilesetData
        {
          nNumTileData = tilesetData.NumTileData,
          fHeightTransition = tilesetData.HeightTransition,
          nNumTerrain = tilesetData.NumTerrain,
          nNumCrossers = tilesetData.NumCrossers,
          nNumGroups = tilesetData.NumGroups,
          sBorderTerrain = tilesetData.BorderTerrain,
          sDefaultTerrain = tilesetData.DefaultTerrain,
          sFloorTerrain = tilesetData.FloorTerrain,
          nDisplayNameStrRef = tilesetData.DisplayNameStrRef,
          sUnlocalizedName = tilesetData.UnlocalizedName,
          bInterior = tilesetData.Interior,
          bHasHeightTransition = tilesetData.HasHeightTransition
        };
      }

      public static implicit operator TilesetData(NWN.Core.NWNX.TilesetData tilesetData)
      {
        return new TilesetData
        {
          NumTileData = tilesetData.nNumTileData,
          HeightTransition = tilesetData.fHeightTransition,
          NumTerrain = tilesetData.nNumTerrain,
          NumCrossers = tilesetData.nNumCrossers,
          NumGroups = tilesetData.nNumGroups,
          BorderTerrain = tilesetData.sBorderTerrain,
          DefaultTerrain = tilesetData.sDefaultTerrain,
          FloorTerrain = tilesetData.sFloorTerrain,
          DisplayNameStrRef = tilesetData.nDisplayNameStrRef,
          UnlocalizedName = tilesetData.sUnlocalizedName,
          Interior = tilesetData.bInterior,
          HasHeightTransition = tilesetData.bHasHeightTransition
        };
      }
    }
  }
}

/// @brief Get general data of sTileset.
/// @param sTileset The tileset.
/// @return A NWNX_Tileset_TilesetData struct.


/// @brief Get the name of sTileset's terrain at nIndex.
/// @param sTileset The tileset.
/// @param nIndex The index of the terrain. Range: NWNX_Tileset_TilesetData.nNumTerrain > nIndex >= 0
/// @return The terrain name or "" on error.
string NWNX_Tileset_GetTilesetTerrain(string sTileset, int nIndex);

/// @brief Get the name of sTileset's crosser at nIndex.
/// @param sTileset The tileset.
/// @param nIndex The index of the crosser. Range: NWNX_Tileset_TilesetData.nNumCrossers > nIndex >= 0
/// @return The crosser name or "" on error.
string NWNX_Tileset_GetTilesetCrosser(string sTileset, int nIndex);

/// @brief Get general data of the group at nIndex in sTileset.
/// @param sTileset The tileset.
/// @param nIndex The index of the group. Range: NWNX_Tileset_TilesetData.nNumGroups > nIndex >= 0
/// @return A NWNX_Tileset_TilesetGroupData struct.
struct NWNX_Tileset_TilesetGroupData NWNX_Tileset_GetTilesetGroupData(string sTileset, int nIndex);

/// @brief Get tile ID of the tile at nIndex.
/// @note NWNX_Tileset_GetTilesetGroupData() needs to be called first.
/// @param nIndex The index of the tile. Range: (NWNX_Tileset_TilesetGroupData.nRows * NWNX_Tileset_TilesetGroupData.nColumns) > nIndex >= 0
/// @return The tile ID or 0 on error.
int NWNX_Tileset_GetTilesetGroupTile(int nIndex);

/// @brief Get the model name of a tile in sTileset.
/// @param sTileset The tileset.
/// @param nTileID The tile ID.
/// @return The model name or "" on error.
string NWNX_Tileset_GetTileModel(string sTileset, int nTileID);

/// @brief Get the minimap texture name of a tile in sTileset.
/// @param sTileset The tileset.
/// @param nTileID The tile ID.
/// @return The minimap texture name or "" on error.
string NWNX_Tileset_GetTileMinimapTexture(string sTileset, int nTileID);

/// @brief Get the edges and corners of a tile in sTileset.
/// @param sTileset The tileset.
/// @param nTileID The tile ID.
/// @return A NWNX_Tileset_TileEdgesAndCorners struct.
struct NWNX_Tileset_TileEdgesAndCorners NWNX_Tileset_GetTileEdgesAndCorners(string sTileset, int nTileID);

/// @brief Get the number of doors of a tile in sTileset.
/// @param sTileset The tileset.
/// @param nTileID The tile ID.
/// @return The amount of doors.
int NWNX_Tileset_GetTileNumDoors(string sTileset, int nTileID);

/// @brief Get the door data of a tile in sTileset.
/// @param sTileset The tileset.
/// @param nTileID The tile ID.
/// @param nIndex The index of the door. Range: NWNX_Tileset_GetTileNumDoors() > nIndex >= 0
/// @return A NWNX_Tileset_TileDoorData struct.
struct NWNX_Tileset_TileDoorData NWNX_Tileset_GetTileDoorData(string sTileset, int nTileID, int nIndex = 0);

/// @brief Override the tiles of sAreaResRef with data in sOverrideName.
/// @param sAreaResRef The resref of the area to override.
/// @param sOverrideName The name of the override containing the custom tile data or "" to remove the override.
void NWNX_Tileset_SetAreaTileOverride(string sAreaResRef, string sOverrideName);

/// @brief Create a tile override named sOverrideName.
/// @param sOverrideName The name of the override.
/// @param sTileSet The tileset the override should use.
/// @param nWidth The width of the area. Valid values: 1-32.
/// @param nHeight The height of the area. Valid values: 1-32.
void NWNX_Tileset_CreateTileOverride(string sOverrideName, string sTileSet, int nWidth, int nHeight);

/// @brief Delete a tile override named sOverrideName.
/// @note This will also delete all custom tile data associated with sOverrideName.
/// @param sOverrideName The name of the override.
void NWNX_Tileset_DeleteTileOverride(string sOverrideName);

/// @brief Set custom tile data for the tile at nIndex in sOverrideName.
/// @note An override must first be created with NWNX_Tileset_CreateTileOverride().
/// @param sOverrideName The name of the override.
/// @param nIndex The index of the tile.
/// @param strCustomTileData A NWNX_Tileset_CustomTileData struct.
void NWNX_Tileset_SetOverrideTileData(string sOverrideName, int nIndex, struct NWNX_Tileset_CustomTileData strCustomTileData);

/// @brief Delete custom tile data of the tile at nIndex in sOverrideName.
/// @param sOverrideName The name of the override.
/// @param nIndex The tile's index or -1 to remove all custom tile data.
void NWNX_Tileset_DeleteOverrideTileData(string sOverrideName, int nIndex);
