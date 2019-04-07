using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[ExecuteInEditMode]
public class Switch : MonoBehaviour
{
    [SerializeField]
    private UnityEvent events;

    private int eventCount;

    private void OnDrawGizmos()
    {
        SetHandles();
        eventCount = events.GetPersistentEventCount();
        for(int i = 0; i < eventCount; i++)
        {
            Component component = (Component)events.GetPersistentTarget(i);
            Transform tr = component.transform;
            Handles.DrawLine(tr.position, transform.position);
        }
    }

    private void SetHandles()
    {
        Handles.color = Color.red;
    }

    public void InvokeEvents()
    {
        events.Invoke();
    }
}
