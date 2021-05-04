using System.Runtime.InteropServices;

namespace ImGuiNET
{
	internal static unsafe partial class ImFreetypeNative
	{
		[DllImport("cimgui-freetype", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool frBuildFontAtlas(ImFontAtlas* atlas, uint extra_flags);
	}
}
