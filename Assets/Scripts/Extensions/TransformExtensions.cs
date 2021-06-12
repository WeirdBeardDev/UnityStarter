/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using UnityEngine;

public static class TransformExtensions
{
    #region Members
    private const string DName = nameof(TransformExtensions);  // Debug name
    #endregion Members

    #region Properties
    #endregion Properties

    #region Methods
    public static Transform[] GetTransformsOfChildrenOnly(this Transform transform)
    {
        var items = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            items[i] = transform.GetChild(i);
        }
        return items;
    }
    #endregion Methods

    #region Helpers
    #endregion Helpers
}
