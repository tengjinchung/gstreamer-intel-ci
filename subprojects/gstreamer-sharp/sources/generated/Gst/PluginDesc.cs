// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PluginDesc : IEquatable<PluginDesc> {

		public int MajorVersion;
		public int MinorVersion;
		public string Name;
		public string Description;
		private GstSharp.PluginInitFuncNative _plugin_init;
		public Gst.PluginInitFunc PluginInit {
			get {
				return GstSharp.PluginInitFuncWrapper.GetManagedDelegate (_plugin_init);
			}
		}
		public string Version;
		public string License;
		public string Source;
		public string Package;
		public string Origin;
		public string ReleaseDatetime;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.PluginDesc Zero = new Gst.PluginDesc ();

		public static Gst.PluginDesc New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.PluginDesc.Zero;
			return (Gst.PluginDesc) Marshal.PtrToStructure (raw, typeof (Gst.PluginDesc));
		}

		public bool Equals (PluginDesc other)
		{
			return true && MajorVersion.Equals (other.MajorVersion) && MinorVersion.Equals (other.MinorVersion) && Name.Equals (other.Name) && Description.Equals (other.Description) && PluginInit.Equals (other.PluginInit) && Version.Equals (other.Version) && License.Equals (other.License) && Source.Equals (other.Source) && Package.Equals (other.Package) && Origin.Equals (other.Origin) && ReleaseDatetime.Equals (other.ReleaseDatetime);
		}

		public override bool Equals (object other)
		{
			return other is PluginDesc && Equals ((PluginDesc) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ MajorVersion.GetHashCode () ^ MinorVersion.GetHashCode () ^ Name.GetHashCode () ^ Description.GetHashCode () ^ PluginInit.GetHashCode () ^ Version.GetHashCode () ^ License.GetHashCode () ^ Source.GetHashCode () ^ Package.GetHashCode () ^ Origin.GetHashCode () ^ ReleaseDatetime.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}