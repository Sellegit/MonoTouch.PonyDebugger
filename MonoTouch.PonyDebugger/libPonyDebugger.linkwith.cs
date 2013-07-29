using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libPonyDebugger.a", LinkTarget.Simulator, ForceLoad = true)]
