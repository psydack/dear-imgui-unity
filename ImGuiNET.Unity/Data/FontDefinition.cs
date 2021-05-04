using UnityEngine;

namespace ImGuiNET.Unity
{
	[System.Serializable]
	internal struct FontDefinition
	{
		[SerializeField] private Object _fontAsset; // to drag'n'drop file from the inspector
		public string FontPath;
		public FontConfig Config;
	}
}
