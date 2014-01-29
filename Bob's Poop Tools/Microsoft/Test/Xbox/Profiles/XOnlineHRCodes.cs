﻿namespace Microsoft.Test.Xbox.Profiles
{
    using System;

    internal enum XOnlineHRCodes : uint
    {
        XONLINE_E_ACCOUNTS_NAME_TAKEN = 0x80154000,
        XONLINE_E_ACCOUNTS_OFFLINE_XUID_ALREADY_USED = 0x8015401d,
        XONLINE_E_LOGON_DNS_LOOKUP_FAILED = 0x80151903,
        XONLINE_E_LOGON_MACS_FAILED = 0x80151906,
        XONLINE_E_LOGON_MACS_TIMEDOUT = 0x80151907,
        XONLINE_E_LOGON_NOT_LOGGED_ON = 0x80151802,
        XONLINE_E_LOGON_UNKNOWN_TITLE = 0x80151912,
        XONLINE_E_SESSION_NOT_LOGGED_ON = 0x80155209,
        XONLINE_S_LOGON_CONNECTION_ESTABLISHED = 0x1510f0
    }
}
