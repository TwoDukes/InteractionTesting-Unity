using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ButtonCircuit))]
public class CircutCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ButtonCircuit myScript = (ButtonCircuit)target;
        if (GUILayout.Button("Activate"))
        {
            myScript.Activate();
        }

        DrawDefaultInspector();
    }
}
