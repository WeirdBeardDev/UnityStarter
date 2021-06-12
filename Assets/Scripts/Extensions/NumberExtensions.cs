/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using UnityEngine;

[System.Serializable]
public static class NumberExtensions
{
    #region Members
    private const string DName = nameof(NumberExtensions); // Debug name
    #endregion Members

    #region Methods
    public static string Pluralize(this int number, string word, string singularSuffix = "", string pluralSuffix = "s") => $"{number} {word}{(number == 1 ? singularSuffix : pluralSuffix)}";
    public static string Pluralize(this int number, string singularForm, string pluralForm) => $"{number} {(number == 1 ? singularForm : pluralForm)}";
    public static string Pluralize(this float number, string word, string singularSuffix = "", string pluralSuffix = "s") => $"{number} {word}{(Mathf.Approximately(number, 1.0f) ? singularSuffix : pluralSuffix)}";
    public static string Pluralize(this float number, string singularForm, string pluralForm) => $"{number} {(Mathf.Approximately(number, 1.0f) ? singularForm : pluralForm)}";
    #endregion Methods

    #region Helpers
    #endregion Helpers
}