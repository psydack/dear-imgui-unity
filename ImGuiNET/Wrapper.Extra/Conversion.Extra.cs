using System.Runtime.InteropServices;
using UnityEngine;
using NumericsV2f = System.Numerics.Vector2;
using NumericsV4f = System.Numerics.Vector4;

namespace ImGuiNET
{
	public static class Helper
	{
		public static Vector2 V2f(NumericsV2f v2) { return new Vector2(v2.X, v2.Y); }
		public static NumericsV2f V2f(Vector2 v2) { return new NumericsV2f(v2.x, v2.y); }
		public static Vector4 V4f(NumericsV4f v4) { return new Vector4(v4.X, v4.Y, v4.Z, v4.W); }
		public static NumericsV4f V4f(Vector4 v4) { return new NumericsV4f(v4.x, v4.y, v4.z, v4.w); }
		public static Color Color(NumericsV4f v4) { return new Color(v4.X, v4.Y, v4.Z, v4.W); }
		public static NumericsV4f Color(Color c) { return new NumericsV4f(c.r, c.g, c.b, c.a); }

		public static T CopyStruct<T>(ref object obj) where T : struct
		{
			GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
			T typedStruct = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
			handle.Free();
			return typedStruct;
		}
	}
}
