using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Switch))]
public class SwitchCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Switch myScript = (Switch)target;
        if (GUILayout.Button("Invoke Events"))
        {
            myScript.InvokeEvents();
        }
    }
}
