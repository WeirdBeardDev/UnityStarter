/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOFactory : MonoBehaviour
{
    #region Members
    private const string DName = nameof(SOFactory);  // Debug name

    [SerializeField] private List<ScriptableObject> _choices = default;
    #endregion Members

    #region Properties
    public int Count => _choices.Count;
    public ScriptableObject this[int i] => _choices[i];
    public ScriptableObject RandomChoice => _choices[Random.Range(0, _choices.Count)];
    #endregion Properties

    #region MonoBehaviours
    public IEnumerator GetEnumerator() => _choices.GetEnumerator();
    #endregion MonoBehaviours

    #region Methods
    #endregion Methods

    #region Helpers
    #endregion Helpers
}
