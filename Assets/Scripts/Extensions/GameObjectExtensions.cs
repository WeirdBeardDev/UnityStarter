/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class GameObjectExtensions
{
    #region Members
    private const string DName = nameof(GameObjectExtensions); // Debug name
    #endregion Members

    #region Properties
    #endregion Properties

    #region Ctor
    #endregion Ctor

    #region Methods
    public static T[] GetComponentsOfChildrenOnly<T>(this GameObject gameObject) where T : Component
    {
        int count = gameObject.transform.childCount;
        var items = new T[count];
        for (int i = 0; i < count; i++)
        {
            items[i] = gameObject.transform.GetChild(i).TryGetComponent(out T component) ? component : null;
        }
        return items;
    }
    #endregion Methods

    #region Helpers
    #endregion Helpers
}