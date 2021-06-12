/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public abstract class SaveData
{
    #region Members
    private const string DName = nameof(SaveData); // Debug name
    protected float _saveFormatVersion = default; // see comments at end of file for version definitions
    protected PlayTime _gameTime = default;
    #endregion Members

    #region Properties
    #endregion Properties

    #region Ctor
    public SaveData() { }
    #endregion Ctor

    #region Methods
    #endregion Methods

    #region Helpers
    #endregion Helpers
}

/* Save Format Version
* This represents all the data needed for saving/loading the game.
* Keep a list of all major changes between save versions, this will help in ensuring compatibility bewteen save formats.
* *****
* v0.1 - initial save file format
*/