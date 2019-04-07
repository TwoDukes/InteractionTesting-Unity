using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ButtonWires))]
public class ButtonCircuit : Circuit
{
    [Header("Events Every Activation")]
    [Tooltip("These methods are called everytime this circuit is activated")]
    public UnityEvent events;

    public override void Activate()
    {
        events.Invoke();
    }
}
