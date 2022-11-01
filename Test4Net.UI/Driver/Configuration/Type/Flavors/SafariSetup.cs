﻿using OpenQA.Selenium.Safari;
using Test4Net.UI.Driver.Configuration.Models;
using Test4Net.UI.Util;

namespace Test4Net.UI.Driver.Configuration.Type.Flavors;

/// <summary>
/// Local safari driver setup
/// </summary>
public class SafariSetup : AbstractSetup<SafariOptions>
{
    /// <summary>
    /// Creates setup from a options set
    /// <see cref="FirefoxBuilder"/>
    /// </summary>
    /// <param name="setup">Setup as dic</param>
    public SafariSetup(IDictionary<string, object> setup) : base(new SafariBuilder(setup))
    { }

    /// <summary>
    /// Creates setup from driverOptions
    /// </summary>
    /// <param name="options"></param>
    public SafariSetup(SafariOptions options) : base(new SafariBuilder(options))
    { }

    /// <summary>
    /// Creates setup from dic and driverOptions
    /// </summary>
    /// <param name="setup"></param>
    /// <param name="options"></param>
    public SafariSetup(IDictionary<string, object> setup, SafariOptions options) :
        base(new SafariBuilder(setup, options))
    { }

    /// <inheritdoc/>
    public override SafariDriver Create() => string.IsNullOrEmpty(Builder.Options.AsDic()["driverPath"].ToString()) ?
        new SafariDriver(Builder.Options) :
        new SafariDriver(Builder.Options.AsDic()["driverPath"].ToString(), Builder.Options);
}