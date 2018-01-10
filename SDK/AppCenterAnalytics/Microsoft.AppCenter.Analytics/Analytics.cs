﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AppCenter.Analytics
{
    /// <summary>
    /// Analytics feature.
    /// </summary>
    public class Analytics : IAppCenterService
    {
        internal Analytics()
        {
        }

        /// <summary>
        /// Check whether the Analytics service is enabled or not.
        /// </summary>
        /// <returns>A task with result being true if enabled, false if disabled.</returns>
        public static Task<bool> IsEnabledAsync()
        {
            return Task.FromResult(false);
        }

        /// <summary>
        /// Enable or disable the Analytics service.
        /// </summary>
        /// <returns>A task to monitor the operation.</returns>
        public static Task SetEnabledAsync(bool enabled)
        {
            return Task.FromResult(default(object));
        }

        ///// <summary>
        ///// Enable or disable automatic page tracking.
        ///// Set this to false to if you plan to call <see cref="TrackPage"/> manually.
        ///// </summary>
        //public static bool AutoPageTrackingEnabled { get; set; }

        /// <summary>
        /// Track a custom event.
        /// </summary>
        /// <param name="name">An event name.</param>
        /// <param name="properties">Optional properties.</param>
        /// <seealso cref="TrackEventAsync"/>
        public static void TrackEvent(string name, IDictionary<string, string> properties = null)
        {
        }

        /// <summary>
        /// Track a custom event.
        /// </summary>
        /// <param name="name">An event name.</param>
        /// <param name="properties">Optional properties.</param>
        public static Task TrackEventAsync(string name, IDictionary<string, string> properties = null)
        {
            return Task.FromResult(default(object));
        }

        ///// <summary>
        ///// Track a custom page.
        ///// </summary>
        ///// <param name="name">A page name.</param>
        ///// <param name="properties">Optional properties.</param>
        //public static void TrackPage(string name, [Optional] IDictionary<string, string> properties)
        //{
        //    throw new NotImplementedException();
        //}
    }
}