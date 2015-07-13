﻿namespace FormulaOne.Helpers
{
    /// <summary>
    /// Device Families
    /// </summary>
    public enum DeviceFamily
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Desktop
        /// </summary>
        Desktop = 1,
        /// <summary>
        /// Mobile
        /// </summary>
        Mobile = 2,
        /// <summary>
        /// Team
        /// </summary>
        Team = 3,
        /// <summary>
        /// Windows universal (for some reason this is returned by IoT)
        /// </summary>
        Universal = 255
    }
    public static class DeviceFamilyHelper
    {
        public static DeviceFamily GetDeviceFamily()
        {
            var deviceFamily = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;
            if (deviceFamily == "Windows.Mobile")
                return DeviceFamily.Mobile;
            else if (deviceFamily == "Windows.Desktop")
                return DeviceFamily.Desktop;
            else if (deviceFamily == "Windows.Team")
                return DeviceFamily.Team;
            else if (deviceFamily == "Windows.Universal")
                return DeviceFamily.Universal;
            else
                return DeviceFamily.Unknown;
        }
    }
}