// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int ValueCompareFuncNative(IntPtr value1, IntPtr value2);

	internal class ValueCompareFuncInvoker {

		ValueCompareFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ValueCompareFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ValueCompareFuncInvoker (ValueCompareFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ValueCompareFuncInvoker (ValueCompareFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ValueCompareFuncInvoker (ValueCompareFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.ValueCompareFunc Handler {
			get {
				return new Gst.ValueCompareFunc(InvokeNative);
			}
		}

		int InvokeNative (GLib.Value value1, GLib.Value value2)
		{
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			int __result = native_cb (native_value1, native_value2);
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return __result;
		}
	}

	internal class ValueCompareFuncWrapper {

		public int NativeCallback (IntPtr value1, IntPtr value2)
		{
			try {
				int __ret = managed ((GLib.Value) Marshal.PtrToStructure (value1, typeof (GLib.Value)), (GLib.Value) Marshal.PtrToStructure (value2, typeof (GLib.Value)));
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ValueCompareFuncNative NativeDelegate;
		Gst.ValueCompareFunc managed;

		public ValueCompareFuncWrapper (Gst.ValueCompareFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ValueCompareFuncNative (NativeCallback);
		}

		public static Gst.ValueCompareFunc GetManagedDelegate (ValueCompareFuncNative native)
		{
			if (native == null)
				return null;
			ValueCompareFuncWrapper wrapper = (ValueCompareFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}