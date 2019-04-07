using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;

[ExecuteInEditMode]
public class SwitchWires : MonoBehaviour
{
    public Color mainWireColor, switchWireColor;

    private Switch _switch;
    private int mainEventCount;

    private void Awake()
    {
        _switch = GetComponent<Switch>();
    }

    private void OnDrawGizmos()
    {
        Handles.color = mainWireColor;
        mainEventCount = _switch.events.GetPersistentEventCount();
        for (int i = 0; i < mainEventCount; i++)
        {
            Component component = _switch.events.GetPersistentTarget(i) as Component;
            if (!component) continue;
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
            Handles.Label(tr.position, "Main");
        }

        Handles.color = switchWireColor;
        for (int i = 0; i < _switch.eventList.Count; i++)
        {
            UnityEvent curEvent = _switch.eventList[i];
            int curEventCount = curEvent.GetPersistentEventCount();
            for (int j = 0; j < curEventCount; j++)
            {
                Component component = curEvent.GetPersistentTarget(j) as Component;
                if (!component) continue;
                Transform tr = component.transform;
                Handles.DrawLine(tr.position, transform.position);
                Handles.Label(tr.position, "#" + (i+1));
            }

        }
    }
}
