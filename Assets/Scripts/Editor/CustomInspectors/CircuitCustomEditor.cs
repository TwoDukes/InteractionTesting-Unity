using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Circuit))]
public class CircutCustomEditor : Editor
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
