using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityTrigger : MonoBehaviour
{
    Circuit circuit;

    private void Awake()
    {
        circuit = GetComponent<Circuit>();
    }

    private void OnTriggerEnter(Collider other)
    {
        circuit.Activate();
    }
}
