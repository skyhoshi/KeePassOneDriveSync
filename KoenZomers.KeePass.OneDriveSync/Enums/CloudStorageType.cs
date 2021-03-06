﻿namespace KoenZomers.KeePass.OneDriveSync.Enums
{
    /// <summary>
    /// Defines the types of cloud storage that can be used
    /// </summary>
    public enum CloudStorageType : short
    {
        /// <summary>
        /// Consumer OneDrive
        /// </summary>
        OneDriveConsumer = 0,

        /// <summary>
        /// Microsoft Graph API
        /// </summary>
        MicrosoftGraph = 2,

        /// <summary>
        /// Microsoft SharePoint
        /// </summary>
        SharePoint = 3,

        /// <summary>
        /// Microsoft Graph API Device Login
        /// </summary>
        MicrosoftGraphDeviceLogin = 4,

        /// <summary>
        /// Do not sync
        /// </summary>
        None = 99
    }
}
