﻿using Test4Net.Test.Interfaces;
using Test4Net.UITest.Interfaces;

namespace Test4Net.UITest.Models;

/// <summary>
/// Test execution context
/// </summary>
public class TestContext : ITestContext<IUiTestConfiguration>
{
    /// <summary>
    /// Test case configuration
    /// </summary>
    public IUiTestConfiguration Configuration { get; set; }

    /// <summary>
    /// Constructor from json dic
    /// </summary>
    /// <param name="configurationName"></param>
    /// <param name="fromJsonDic"></param>
    public TestContext(string configurationName, string fromJsonDic)
    {
        Configuration = new UiTestConfiguration(fromJsonDic, configurationName);
    }
}