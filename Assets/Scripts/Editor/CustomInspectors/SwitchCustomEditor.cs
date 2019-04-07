using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Switch))]
public class SwitchCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Circuit myScript = (Circuit)target;
        if (GUILayout.Button("Activate"))
        {
            myScript.Activate();
        }

        DrawDefaultInspector();
    }
}
