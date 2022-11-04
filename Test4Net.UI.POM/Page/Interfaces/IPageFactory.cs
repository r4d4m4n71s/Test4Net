﻿namespace Test4Net.UI.POM.Page.Interfaces
{
    /// <summary>
    /// Provide page objects
    /// </summary>
    public interface IPageFactory : IDisposable
    {
        /// <summary>
        /// Get page instance
        /// </summary>
        /// <typeparam name="T">Page type</typeparam>
        /// <returns></returns>
        public T GetPage<T>(params object[] args) where T : IPage;
    }
}
