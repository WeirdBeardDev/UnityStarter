/*
 * This file is subject to the terms and conditions defined in the file License.md, which is part of the source code package.
 * All Rights Reserved.  Copyright (c) 2021 Rocket Slide
*/

using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class PlayTime
{
    #region Members
    private const string DName = nameof(PlayTime); // Debug name
    private DateTime _lastActiveUpdate = default;
    #endregion Members

    #region Properties
    public DateTime CompanyStart { get; set; } = default;
    public TimeSpan TotalGameTime { get; set; } = default;
    public TimeSpan TimeInHeadquarters { get; set; } = default;
    public TimeSpan TimeInCrawler { get; set; } = default;
    #endregion Properties

    #region Ctor
    public PlayTime() { }
    #endregion Ctor

    #region Methods
    public void Setup()
    {
        CompanyStart = _lastActiveUpdate = DateTime.Now;
        TotalGameTime = new TimeSpan();
        TimeInHeadquarters = new TimeSpan();
        TimeInCrawler = new TimeSpan();
    }
    public void Load(PlayTime savedTime)
    {
        if (savedTime is object)
        {
            CompanyStart = savedTime.CompanyStart;
            _lastActiveUpdate = DateTime.Now;
        }
    }
    public void UpdateTime(DateTime dt, TimeTracker tracker)
    {
        // TODO add code for tracking specific time to the correct tracker
    }
    #endregion Methods

    #region Helpers
    #endregion Helpers
}

public enum TimeTracker
{
    InHeadquarters = 0,
    InCrawler = 1
}