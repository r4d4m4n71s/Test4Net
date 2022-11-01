﻿using Test4Net.UI.Browser.Interfaces;

namespace Test4Net.UI.Page.Interfaces
{
    /// <summary>
    /// Provide page objects
    /// </summary>
    public interface IPageFactory
    {
        /// <summary>
        /// Get page instance
        /// </summary>
        /// <typeparam name="T">Page type</typeparam>
        /// <param name="browser">Browser instance</param>
        /// <returns></returns>
        public T GetPage<T>(IBrowser browser) where T : IPage;
    }
}
