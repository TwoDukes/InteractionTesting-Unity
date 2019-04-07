using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class RepeatingCircuitWires : MonoBehaviour
{
    public Color activeWireColor = Color.green, disabledWireColor = Color.magenta;

    private RepeatingCircuit circuit;
    private int eventCount;

    private void Awake()
    {
        circuit = GetComponent<RepeatingCircuit>();
    }

    private void OnDrawGizmos()
    {
        if (!circuit) return;

        if(circuit.IsCurrentlyActive()) Handles.color = activeWireColor;
        else Handles.color = disabledWireColor;

        eventCount = circuit.GetEvents().GetPersistentEventCount();
        for (int i = 0; i < eventCount; i++)
        {
            Component component = circuit.GetEvents().GetPersistentTarget(i) as Component;
            if (!component) continue;
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
            Handles.Label(transform.position, circuit.GetDelay() + "s");
        }
    }
}
