using UnityEngine;
using UnityEngine.Events;

public class Circuit : MonoBehaviour
{
    [Header("Events Every Activation")]
    [Tooltip("These methods are called everytime this circuit is activated")]
    public UnityEvent events;

    public virtual void Activate()
    {
        events.Invoke();
    }
}
