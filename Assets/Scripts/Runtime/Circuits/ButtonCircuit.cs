using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ButtonWires))]
public class ButtonCircuit : Circuit
{
    [Header("Events Every Activation")]
    [SerializeField]
    [Tooltip("These methods are called everytime this circuit is activated")]
    private UnityEvent events;

    public UnityEvent GetEvents()
    {
        return events;
    }

    public override void Activate()
    {
        events.Invoke();
    }
}
