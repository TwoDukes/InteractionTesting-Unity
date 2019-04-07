using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[ExecuteInEditMode]
public class Switch : Circuit
{
    [Space]
    [Header("Cycling Events")]
    [SerializeField]
    [Tooltip("Each set of events will trigger in order per activation and then cycle")]
    public List<UnityEvent> eventList;

    private int eventIterator = 0;

    private void Awake()
    {
        if (eventList.Count <= 1)
        {
            Debug.LogWarning("If you are only using one set of events you should use a circuit instead of a switch");
        }
    }

    public override void Activate()
    {
        events.Invoke();
        eventList[eventIterator].Invoke();
        if(eventIterator + 1 == eventList.Count)
        {
            eventIterator = 0;
            return;
        }
        ++eventIterator;
    }

    //private void OnDrawGizmos()
    //{
    //    Handles.color = Color.red;
    //    eventCount = events.GetPersistentEventCount();
    //    for(int i = 0; i < eventCount; i++)
    //    {
    //        Component component = (Component)events.GetPersistentTarget(i);
    //        Transform tr = component.transform;
    //        Handles.DrawLine(tr.position, transform.position);
    //    }
    //}
}
