/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class GameFile
{
    #region Imports
#if UNITY_WEBGL
    [DllImport("__Internal")] private static extern void SyncFiles();
#endif
    #endregion Imports

    #region Members
    private const string DName = nameof(GameFile);  // Debug name
    private static readonly string _fileName = "SaveFile";
    private static readonly string _extension = "save";
    #endregion Members

    #region Properties
    public static string SaveDirectory { get; } = Application.persistentDataPath + @"\Saves\";
    #endregion Properties

    #region Methods
    public static void Delete(SaveSlot slot)
    {
        // TODO make the Delete method more robust
        try
        {
            File.Delete(FullPath(slot));
        }
        finally { }
    }
    public static bool Exists(SaveSlot slot) => File.Exists(FullPath(slot));
    public static DateTime? GetLastAccessTime(SaveSlot slot)
    {
        DateTime? ans;
        try
        {
            ans = File.GetLastAccessTime(FullPath(slot));
        }
        catch (Exception)
        {
            ans = null;
        }
        return ans;
    }
    public static SaveData Load(SaveSlot slot)
    {
        // TODO add code for Loading game data
        SaveData ans = null;
        // TODO research File.Read* methods
        return ans;
    }
    public static void Save(SaveSlot slot, SaveData data)
    {
        Directory.CreateDirectory(SaveDirectory);
        // TODO add code for Saving game data
        // TODO research File.Write* methods
#if UNITY_WEBGL
		SaveWebGL();
#endif
    }
    #endregion Methods

    #region Helpers
    private static string FullPath(SaveSlot slot) => $"{SaveDirectory}{_fileName}{(int)slot}.{_extension}";
#if UNITY_WEBGL
    private static void SaveWebGL() => SyncFiles();
#endif
    #endregion Helpers
}

public enum SaveSlot
{
    Save1 = 1,
    Save2 = 2,
    Save3 = 3
}