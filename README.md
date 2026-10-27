# JavaLangObjectCastIssueNet11

Run the NET 10 project with:

```bash
dotnet run --project net10cast/net10cast.csproj /p:Configuration=Release
```

All is good.

Run the NET 11 project with:

```bash
dotnet run --project net11cast/net11cast.csproj /p:Configuration=Release
```

Boom `InvalidCastException` is thrown like:

```
10-27 15:38:04.500  1508  1508 D AndroidRuntime: Shutting down VM
10-27 15:38:04.500  1508  1508 E AndroidRuntime: FATAL EXCEPTION: main
10-27 15:38:04.500  1508  1508 E AndroidRuntime: Process: com.companyname.net11cast, PID: 1508
10-27 15:38:04.500  1508  1508 E AndroidRuntime: android.runtime.JavaProxyThrowable: [System.InvalidCastException]: Unable to cast object of type 'Java.Lang.Object' to type 'Android.App.Usage.StorageStatsManager'.
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.<IsInstanceOf_NoCacheLookup>g____PInvoke|4_0(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.<IsInstanceOf_NoCacheLookup>g____PInvoke|4_0(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.IsInstanceOf_NoCacheLookup + 0x5(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup + 0x0(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.ChkCast_Helper + 0x16(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial + 0x4b(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at System.Runtime.CompilerServices.CastHelpers.ChkCastClass + 0xe(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at net11cast.MainActivity+<GetStorageInformation>d__1.MoveNext + 0x26(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at net11cast.MainActivity.OnCreate + 0x3f(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at Android.App.Activity.__n_OnCreate_Landroid_os_Bundle_ + 0x0(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at Java.Interop.JniMarshal.SafeInvokeAction + 0x10(Unknown Source)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at scrc648536b707fa8b2047.MainActivity.n_OnCreate_Landroid_os_Bundle_(Native Method)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at scrc648536b707fa8b2047.MainActivity.onCreate(r8-map-id-36836d1d3470e82bd783ca3e552fdc39854a9895817d0fb5a9b359a5c4c62e10:1)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.Activity.performCreate(Activity.java:7825)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.Activity.performCreate(Activity.java:7814)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.Instrumentation.callActivityOnCreate(Instrumentation.java:1307)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.ActivityThread.performLaunchActivity(ActivityThread.java:3246)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.ActivityThread.handleLaunchActivity(ActivityThread.java:3410)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.servertransaction.LaunchActivityItem.execute(LaunchActivityItem.java:83)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.servertransaction.TransactionExecutor.executeCallbacks(TransactionExecutor.java:135)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.servertransaction.TransactionExecutor.execute(TransactionExecutor.java:95)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.ActivityThread$H.handleMessage(ActivityThread.java:2017)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.os.Handler.dispatchMessage(Handler.java:107)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.os.Looper.loop(Looper.java:214)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at android.app.ActivityThread.main(ActivityThread.java:7397)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at java.lang.reflect.Method.invoke(Native Method)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at com.android.internal.os.RuntimeInit$MethodAndArgsCaller.run(RuntimeInit.java:492)
10-27 15:38:04.500  1508  1508 E AndroidRuntime:        at com.android.internal.os.ZygoteInit.main(ZygoteInit.java:935)
10-27 15:38:04.508  1508  1508 I MonoDroid: UNHANDLED EXCEPTION:
10-27 15:38:04.519  1508  1508 I MonoDroid: Android.Runtime.JavaProxyThrowable: Exception_WasThrown, Android.Runtime.JavaProxyThrowable
10-27 15:38:04.519  1508  1508 I MonoDroid:
10-27 15:38:04.519  1508  1508 I MonoDroid:   --- End of managed Android.Runtime.JavaProxyThrowable stack trace ---
10-27 15:38:04.519  1508  1508 I MonoDroid: android.runtime.JavaProxyThrowable
10-27 15:38:04.519  1508  1508 I MonoDroid:
10-27 15:38:04.525  3252  4030 W ActivityTaskManager:   Force finishing activity com.companyname.net11cast/scrc648536b707fa8b2047.MainActivity
10-27 15:38:04.525  3252  1539 I DropBoxManagerService: add tag=data_app_crash isTagEnabled=true flags=0x2
10-27 15:38:04.558  3252  4030 D ActivityTrigger: ActivityTrigger activityPauseTrigger
10-27 15:38:04.566  1508  1508 I Process : Sending signal. PID: 1508 SIG: 9
10-27 15:38:04.570  3252 23572 I AdrenoGLES: QUALCOMM build                   : 99d190e401, I5e6feab613
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Build Date                       : 12/06/21
10-27 15:38:04.570  3252 23572 I AdrenoGLES: OpenGL ES Shader Compiler Version: EV031.27.05.11_01
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Local Branch                     :
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Remote Branch                    : quic/LA.UM.8.11.1.c25
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Remote Branch                    : NONE
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Reconstruct Branch               : NOTHING
10-27 15:38:04.570  3252 23572 I AdrenoGLES: Build Config                     : S P 8.0.12 AArch64
10-27 15:38:04.576  3252 23572 I AdrenoGLES: PFP: 0x016ee187, ME: 0x00000000
10-27 15:38:04.589  3252  6425 I ActivityManager: Process com.companyname.net11cast (pid 1508) has died: fore TOP
```

When `AndroidTypeMapImplementation` is removed from net11cast.csproj it works, or if I use `.JavaCast<StorageStatsManager>()` instead of a regular cast `(StorageStatsManager?)` it works.
