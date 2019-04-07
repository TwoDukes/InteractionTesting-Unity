using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ButtonCircuit))]
public class ButtonCustomEditor : Editor
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
