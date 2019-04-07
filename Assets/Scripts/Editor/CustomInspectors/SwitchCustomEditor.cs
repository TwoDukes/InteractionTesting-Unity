using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SwitchCircuit))]
public class SwitchCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SwitchCircuit myScript = (SwitchCircuit)target;
        if (GUILayout.Button("Activate"))
        {
            myScript.Activate();
        }

        DrawDefaultInspector();
    }
}
