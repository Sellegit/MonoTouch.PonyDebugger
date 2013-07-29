using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSocketRocket.a",  LinkTarget.ArmV7 | LinkTarget.Simulator,
                     Frameworks = "Security CFNetwork Foundation CoreGraphics UIKit CoreData", ForceLoad = true, LinkerFlags = "-ObjC -licucore")]
