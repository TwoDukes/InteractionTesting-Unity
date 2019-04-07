using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class DelayCircuitWires : MonoBehaviour
{
    public Color wireColor = Color.red;

    private DelayCircuit circuit;
    private int eventCount;

    private void Awake()
    {
        circuit = GetComponent<DelayCircuit>();
    }

    private void OnDrawGizmos()
    {
        if (!circuit) return;

        Handles.color = wireColor;
        eventCount = circuit.GetEvents().GetPersistentEventCount();
        for (int i = 0; i < eventCount; i++)
        {
            Component component = circuit.GetEvents().GetPersistentTarget(i) as Component;
            if (!component) continue;
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
        }
    }
}
