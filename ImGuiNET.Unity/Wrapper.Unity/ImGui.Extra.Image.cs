using ImGuiNET.Unity;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using NumericsV2f = System.Numerics.Vector2;

namespace ImGuiNET
{
	// ImGui extra functionality related with Images
	public static partial class ImGuiUn
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Image(Texture tex)
		{
			ImGui.Image((IntPtr)GetTextureId(tex), new NumericsV2f(tex.width, tex.height));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe void Image(Texture tex, Vector2 size)
		{
			ImGui.Image((IntPtr)GetTextureId(tex), *(NumericsV2f*)&size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Image(Sprite sprite)
		{
			SpriteInfo info = GetSpriteInfo(sprite);
			ImGui.Image((IntPtr)GetTextureId(info.texture), info.size, info.uv0, info.uv1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe void Image(Sprite sprite, Vector2 size)
		{
			SpriteInfo info = GetSpriteInfo(sprite);
			ImGui.Image((IntPtr)GetTextureId(info.texture), *(NumericsV2f*)&size, info.uv0, info.uv1);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImageButton(Texture tex)
		{
			ImGui.ImageButton((IntPtr)GetTextureId(tex), new NumericsV2f(tex.width, tex.height));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe void ImageButton(Texture tex, Vector2 size)
		{
			ImGui.ImageButton((IntPtr)GetTextureId(tex), *(NumericsV2f*)&size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImageButton(Sprite sprite)
		{
			SpriteInfo info = GetSpriteInfo(sprite);
			ImGui.ImageButton((IntPtr)GetTextureId(info.texture), info.size, info.uv0, info.uv1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe void ImageButton(Sprite sprite, Vector2 size)
		{
			SpriteInfo info = GetSpriteInfo(sprite);
			ImGui.ImageButton((IntPtr)GetTextureId(info.texture), *(NumericsV2f*)&size, info.uv0, info.uv1);
		}
	}
}
