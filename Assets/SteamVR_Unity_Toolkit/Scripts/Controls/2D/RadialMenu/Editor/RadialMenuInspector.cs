using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(RadialMenu))]
public class RadialMenuInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RadialMenu rMenu = (RadialMenu)target;
        if (GUILayout.Button("Regenerate Buttons"))
        {
            rMenu.RegenerateButtons();
        }
    }
}