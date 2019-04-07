using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(RepeatingCircuitWires))]
public class RepeatingCircuit : Circuit
{
    [SerializeField]
    private UnityEvent events;
    [SerializeField]
    private float delay;

    private bool isCurrentlyActive = false;

    public UnityEvent GetEvents()
    {
        return events;
    }

    public float GetDelay()
    {
        return delay;
    }

    public bool IsCurrentlyActive()
    {
        return isCurrentlyActive;
    }

    public override void Activate()
    {
        if (isCurrentlyActive)
        {
            StopAllCoroutines();
            isCurrentlyActive = false;
            return;
        }
        StartCoroutine(RepeatingActivator());
        isCurrentlyActive = true;

    }

    IEnumerator RepeatingActivator()
    {
        while (true)
        {
            events.Invoke();
            yield return new WaitForSeconds(delay);
        }
    }
}
