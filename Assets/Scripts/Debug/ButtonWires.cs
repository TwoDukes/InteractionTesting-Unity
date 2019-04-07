using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
[RequireComponent(typeof(ButtonCircuit))]
public class ButtonWires : MonoBehaviour
{

    public Color wireColor = Color.red;

    private ButtonCircuit circuit;
    private int eventCount;

    private void Awake()
    {
        circuit = GetComponent<ButtonCircuit>();
    }

    private void OnDrawGizmos()
    {
        if (!circuit) return;

        Handles.color = Color.red;
        eventCount = circuit.events.GetPersistentEventCount();
        for (int i = 0; i < eventCount; i++)
        {
            Component component = circuit.events.GetPersistentTarget(i) as Component;
            if (!component) continue;
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
        }
    }
}
