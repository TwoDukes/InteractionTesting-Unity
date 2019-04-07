using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RepeatingCircuit))]
public class RepeatingCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        RepeatingCircuit myScript = (RepeatingCircuit)target;
        if (GUILayout.Button("Activate"))
        {
            myScript.Activate();
        }

        DrawDefaultInspector();
    }
}
