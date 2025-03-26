# ASP.NET Framework 4.7.2 Sample Application

## Overview
This is a sample ASP.NET Framework application targeting version 4.7.2. The purpose of this application is to demonstrate the usage of ASP.NET sessions in different configurations, including native InProc session management and integration with NCache for distributed session storage.

## Session Management Testing
### 1. InProc Session State
Initially, the application was configured to use ASP.NET's native session state with the following setting in `web.config`:
```xml
<sessionState mode="InProc" timeout="20" />
```
This configuration allowed sessions to be stored in the application's memory.

### 2. NCache-Based Session State
After testing with InProc sessions, the above configuration was commented out, and the `AspNet.SessionState.NCache` package was added to the project. This introduced the following session state configuration in `web.config`:
```xml
<sessionState cookieless="false" regenerateExpiredSessionId="true" mode="Custom"
customProvider="NCacheSessionProvider" timeout="20">
    <providers>
        <add name="NCacheSessionProvider"
             type="Alachisoft.NCache.Web.SessionState.NSessionStoreProvider"
             exceptionsEnabled="true"
             enableSessionLocking="true"
             emptySessionWhenLocked="false"
             sessionLockingRetry="-1"
             sessionAppId="NCacheTest"
             useInProc="false"
             enableLogs="false"
             cacheName="SKOnly"
             writeExceptionsToEventLog="false"
             AsyncSession="false"
             useJsonSerialization="false"
             userId="shoaib_khalid"
             password="4Islamabad"/>
    </providers>
</sessionState>
```
- `cacheName` was specified.
- If the cache was remote, IP addresses were added in `client.ncconf` for proper communication.

### 3. Session Behavior with NCache
- No code changes were required to enable NCache-based session management.
- The application seamlessly started using NCache for session storage.
- The session entries could be monitored in the **NCache dashboard**.

## Conclusion
This project demonstrates the ease of transitioning from **InProc** session management to a **distributed session store using NCache**, without modifying the application code. The switch is achieved simply by updating the `web.config` configuration.

