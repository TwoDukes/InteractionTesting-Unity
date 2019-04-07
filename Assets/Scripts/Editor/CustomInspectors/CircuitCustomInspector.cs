using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Circuit))]
public class CircuitCustomInspector : Editor
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
