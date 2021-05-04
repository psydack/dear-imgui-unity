using UnityEditor;
using UnityEngine;

namespace ImGuiNET.Unity.Editor
{
	[CustomEditor(typeof(StyleAsset))]
	internal class StyleAssetEditor : UnityEditor.Editor
	{
		private bool _showColors;

		public override void OnInspectorGUI()
		{
			StyleAsset styleAsset = target as StyleAsset;

			bool noContext = ImGui.GetCurrentContext() == System.IntPtr.Zero;
			if (noContext)
				EditorGUILayout.HelpBox("Can't save or apply Style.\n"
									  + "No active ImGui context.", MessageType.Warning, true);

			// apply and save buttons only when a context is active
			if (!noContext)
			{
				ImGuiStylePtr style = ImGui.GetStyle();

				GUILayout.BeginHorizontal();
				if (GUILayout.Button("Apply"))
					styleAsset.ApplyTo(style);

				if (GUILayout.Button("Save")
				&& EditorUtility.DisplayDialog("Save Style", "Do you want to save the current style to this asset?", "Ok", "Cancel"))
				{
					styleAsset.SetFrom(style);
					EditorUtility.SetDirty(target);
				}
				GUILayout.EndHorizontal();
			}

			// default
			DrawDefaultInspector();

			// colors
			bool changed = false;
			_showColors = EditorGUILayout.Foldout(_showColors, "Colors", true);
			if (_showColors)
			{
				for (int i = 0; i < (int)ImGuiCol.COUNT; ++i)
				{
					Color indexColor = styleAsset.Colors[i];
					Color newColor = EditorGUILayout.ColorField(ImGui.GetStyleColorName((ImGuiCol)i), indexColor);
					changed |= (newColor != indexColor);
					styleAsset.Colors[i] = newColor;
				}
			}

			if (changed)
				EditorUtility.SetDirty(target);
		}
	}
}
