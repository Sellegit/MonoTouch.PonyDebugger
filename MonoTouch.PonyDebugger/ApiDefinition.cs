using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace PonyDebugger {


	[BaseType (typeof (NSObject))]
	public partial interface PDDebugger {

		[Static, Export ("defaultInstance")]
		PDDebugger DefaultInstance { get; }

		[Export ("domainForName:")]
		NSObject DomainForName (string name);

		[Export ("sendEventWithName:parameters:")]
		void SendEventWithName (string name, NSObject parameters);

		[Export ("autoConnect")]
		void AutoConnect ();

		[Export ("autoConnectToBonjourServiceNamed:")]
		void AutoConnectToBonjourServiceNamed (string serviceName);

		[Export ("connectToURL:")]
		void ConnectToURL (NSUrl url);

		[Export ("isConnected")]
		bool IsConnected { get; }

		[Export ("disconnect")]
		void Disconnect ();

		[Export ("enableNetworkTrafficDebugging")]
		void EnableNetworkTrafficDebugging ();

		[Export ("forwardAllNetworkTraffic")]
		void ForwardAllNetworkTraffic ();

		[Export ("forwardNetworkTrafficFromDelegateClass:")]
		void ForwardNetworkTrafficFromDelegateClass (Class cls);

		/*[Static, Export ("registerPrettyStringPrinter:")]
		void RegisterPrettyStringPrinter (PDPrettyStringPrinting prettyStringPrinter);

		[Static, Export ("unregisterPrettyStringPrinter:")]
		void UnregisterPrettyStringPrinter (PDPrettyStringPrinting prettyStringPrinter);*/

		[Export ("enableCoreDataDebugging")]
		void EnableCoreDataDebugging ();

		/*[Export ("addManagedObjectContext:")]
		void AddManagedObjectContext (NSManagedObjectContext context);

		[Export ("addManagedObjectContext:withName:")]
		void AddManagedObjectContext (NSManagedObjectContext context, string name);

		[Export ("removeManagedObjectContext:")]
		void RemoveManagedObjectContext (NSManagedObjectContext context);*/

		[Export ("enableViewHierarchyDebugging")]
		void EnableViewHierarchyDebugging ();

		[Export ("displayedViewAttributeKeyPaths")]
		NSObject [] DisplayedViewAttributeKeyPaths { set; }

		[Export ("enableRemoteLogging")]
		void EnableRemoteLogging ();

		[Export ("clearConsole")]
		void ClearConsole ();
	}
}
