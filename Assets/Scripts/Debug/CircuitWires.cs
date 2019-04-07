using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class CircuitWires : MonoBehaviour
{

    public Color wireColor;

    private Circuit circuit;
    private int eventCount;

    private void Awake()
    {
        circuit = GetComponent<Circuit>();
    }

    private void OnDrawGizmos()
    {
        Handles.color = Color.red;
        eventCount = circuit.events.GetPersistentEventCount();
        for (int i = 0; i < eventCount; i++)
        {
            Component component = circuit.events.GetPersistentTarget(i) as Component;
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
        }
    }
}
