using UnityEngine;

namespace ImGuiNET.Unity
{
	[CreateAssetMenu(menuName = "Dear ImGui/Font Atlas Configuration")]
	internal sealed class FontAtlasConfigAsset : ScriptableObject
	{
		public FontRasterizerType Rasterizer;
		public uint RasterizerFlags;
		public FontDefinition[] Fonts;
	}

	internal enum FontRasterizerType
	{
		StbTrueType,
		FreeType,
	}
}
