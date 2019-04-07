using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DelayCircuit))]
public class DelayCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DelayCircuit myScript = (DelayCircuit)target;
        if (GUILayout.Button("Activate"))
        {
            myScript.Activate();
        }

        DrawDefaultInspector();
    }
}
