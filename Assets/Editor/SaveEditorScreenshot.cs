/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System.Linq;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEditorInternal;

[InitializeOnLoad]
public class SaveEditorScreenshot
{
    #region Members
    private const string DName = nameof(SaveEditorScreenshot); // Debug name
    private const string GameViewMenuName = "RocketSlide/Save Game View Screenshot %#E";
    private const string EditorWindowMenuName = "RocketSlide/Save Focused Editor Window Screenshot %#W";
    #endregion Members

    #region Properties
    #endregion Properties

    #region Ctor
    static SaveEditorScreenshot() { }
    #endregion Ctor

    #region Methods
    #endregion Methods

    #region Helpers
    [MenuItem(GameViewMenuName)]
    private static void TakeScreenshot()
    {
        // The Game tab must be the active/focused tab to take the screenshot
        // The GameView class is not accessible so activate via the menu system
        _ = EditorApplication.ExecuteMenuItem("Window/General/Game");
        ScreenCapture.CaptureScreenshot($"{FullFilename("Screenshot")}");
    }
    [MenuItem(GameViewMenuName, true)]
    private static bool ValidateScreenshotOS() => ValidateWindows();
    [MenuItem(EditorWindowMenuName)]
    private static void EditorScreenshot()
    {
        var activeWindow = EditorWindow.focusedWindow;
        if (!activeWindow)
        {
            Debug.Log("Nothing to screenshot as no editor window is selected.");
            return;
        }
        var windowName = activeWindow.titleContent.text;
        var vector2Pos = activeWindow.position.position;
        var sizeX = (int)activeWindow.position.width;
        var sizeY = (int)activeWindow.position.height;

        var colors = InternalEditorUtility.ReadScreenPixel(vector2Pos, sizeX, sizeY).Cast<Color32>().ToArray();
        var result = new Texture2D(sizeX, sizeY);
        result.SetPixels32(colors);

        var bytes = result.EncodeToPNG();
        Object.DestroyImmediate(result);

        File.WriteAllBytes($"{FullFilename(windowName)}", bytes);
    }
    [MenuItem(EditorWindowMenuName, true)]
    private static bool ValidateEditorWindowOS() => ValidateWindows();
    private static string FullFilename(string name) => $@"{Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), "Downloads")}\{name} {System.DateTime.Now:yyyy-MM-dd-HHmmss}.png";
    private static bool ValidateWindows() => Application.platform == RuntimePlatform.WindowsEditor;
    #endregion Helpers
}