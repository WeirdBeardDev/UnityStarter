/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SpaceMonkeys.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketSlide : Singleton<RocketSlide>
{
    #region Members
    private const string DNAME = nameof(RocketSlide);
    #endregion Members

    #region Properties
    #endregion Properties

    #region MonoBehaviours
    protected override void Awake()
    {
        base.Awake();
        Log(DNAME, "starting the game...");
    }
    protected override void OnApplicationQuit()
    {
        base.OnApplicationQuit();
        // FIX Android, iOS, and WebGL don't use this method
        // TODO research how each system triggers the app exit
        QuitGame();
    }
    #endregion MonoBehaviours

    #region Methods
    public void QuitGame()
    {
        Log(DNAME, "quitting the game.");
        Application.Quit();
    }
	[Conditional("ENABLE_LOGS")]
    public static void Log(string className, string text) => print($"{className}: {text}");
    #endregion Methods

    #region Helpers
    #endregion Helpers
}
