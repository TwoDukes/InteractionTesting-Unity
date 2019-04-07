using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(DelayCircuitWires))]
public class DelayCircuit : Circuit
{

    [SerializeField]
    private UnityEvent events;
    [SerializeField]
    private float delay;

    public UnityEvent GetEvents()
    {
        return events;
    }

    public float GetDelay()
    {
        return delay;
    }

    public override void Activate()
    {
        StartCoroutine(ActivateAfterDelay());
    }

    IEnumerator ActivateAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        events.Invoke();
    }
}
