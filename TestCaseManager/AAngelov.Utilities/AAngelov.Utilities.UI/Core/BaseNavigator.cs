﻿// <copyright file="BaseNavigator.cs" company="Automate The Planet Ltd.">
// Copyright 2016 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
namespace AAngelov.Utilities.UI.Core
{
    using System;
    using System.Windows;
    using FirstFloor.ModernUI.Windows.Navigation;

    /// <summary>
    /// Contains methods which navigate to different views with option to set different parameters
    /// </summary>
    public class BaseNavigator
    {
        /// <summary>
        /// Navigates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="url">The URL.</param>
        public void Navigate(FrameworkElement source, string url)
        {
            DefaultLinkNavigator navigator = new DefaultLinkNavigator();
            navigator.Navigate(new Uri(url, UriKind.Relative), source, null);
        }

        /// <summary>
        /// Navigates the back.
        /// </summary>
        /// <param name="source">The source.</param>
        public void NavigateBack(FrameworkElement source)
        {
            string url = "cmd://browseback";
            DefaultLinkNavigator navigator = new DefaultLinkNavigator();
            navigator.Navigate(new Uri(url, UriKind.Absolute), source, "_self");
        }
    }
}