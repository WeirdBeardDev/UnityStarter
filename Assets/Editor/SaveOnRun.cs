/*
 * This work by Jason "Aj" Comfort (https://weirdbearddev.com) is licensed under 
 * CC BY-SA 4.0. To view a copy of this license, visit https://creativecommons.org/licenses/by-sa/4.0
*/

using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class SaveOnRun
{
    #region Members
    public const string MenuName = "Beardo/Save On Run";
    private static bool _isEnabled = false;
    #endregion Members

    #region Ctor
    static SaveOnRun()
    {
        EditorApplication.delayCall += () =>
         {
             _isEnabled = EditorPrefs.GetBool(MenuName, false);
             Menu.SetChecked(MenuName, _isEnabled);
             SetMode();
         };
    }
    #endregion Ctor

    #region Helpers
    [MenuItem(MenuName)]
    private static void ToggleMode()
    {
        _isEnabled = !_isEnabled;
        Menu.SetChecked(MenuName, _isEnabled);
        EditorPrefs.SetBool(MenuName, _isEnabled);
        SetMode();
    }
    private static void SetMode()
    {
        if (_isEnabled)
        {
            EditorApplication.playModeStateChanged += SaveScene;
        }
        else
        {
            EditorApplication.playModeStateChanged -= SaveScene;
        }
    }
    private static void SaveScene(PlayModeStateChange stateChange)
    {
        if (stateChange == PlayModeStateChange.ExitingEditMode)
        {
            Debug.Log("Saving scene before entering Play mode...");
            _ = EditorSceneManager.SaveOpenScenes();
            AssetDatabase.SaveAssets();
        }
    }
    #endregion Helpers
}
